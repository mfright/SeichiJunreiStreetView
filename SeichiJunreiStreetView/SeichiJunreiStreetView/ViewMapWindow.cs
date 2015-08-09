using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Web;
using System.Diagnostics;


namespace SeichiJunreiStreetView
{
    public partial class ViewMapWindow : Form
    {
        product myProduct;
        int pageNumber = 0;
        //static string proxy = "http://slcp.sourceforge.jp/seichiJunrei/generator.php";
        static string proxy = "http://slcp.osdn.jp/seichiJunrei/generator.php";
        static string proxy_nonssl = "http://slcp.osdn.jp/seichiJunrei/generator_nonssl.php";

        member nextMember;

        loadingWindow loading;



        /// <summary>
        /// コンストラクタでproductを受け取る
        /// </summary>
        /// <param name="tgt"></param>
        public ViewMapWindow(product tgt)
        {
            InitializeComponent();

            myProduct = tgt;
        }

        private void ViewMapWindow_Load(object sender, EventArgs e)
        {
            // ウィンドウのアイコンを変更
            setIcon();

            // ウィンドウタイトルに作品のタイトルを表示
            Text = myProduct.title;

            
            // listBoxへ場所項目を追加
            for (int i = 0; i < myProduct.members.Count; i++)
            {
                member myMember = (member)myProduct.members[i];
                lstPlaces.Items.Add(myMember.place);
            }

            //lstPlaces.SelectedIndex = 0;
            
            //SV読み込み
            //最大化表示する場合は、そこでリサイズが発生しrefresh()が呼ばれるので不要
            //refresh();

            //最大化表示
            this.WindowState = FormWindowState.Maximized;

            //StreetViewのブラウザコンポーネントのリサイズの秒数を設定
            //timerResizeSv.Interval = settings.resize_millisecond;

            //イラストを表示
            setPicture();

            // Loading画像を表示
            setLoadingPicture();

            /*
            lblMessage.BackColor = Color.Transparent;
            lblMessage.Parent = pictureBox1;
            lblMessage.Location -= (Size)pictureBox1.Location;

            pictureBox1.Image = getWhite();
            pictureBox1.Parent = pic;
            pictureBox1.Location -= (Size)pic.Location; */
        }

        private void setPicture()
        {
            string path = getCurrentPath();

            path += "\\xml\\" + myProduct.buttonImageFileName;

            pic.Image = System.Drawing.Image.FromFile(path);
        }

        private void setLoadingPicture()
        {
            string path = getCurrentPath();

            path += "\\settings\\loading.png";

            //pic_loading.Image = System.Drawing.Image.FromFile(path);
            setOpacityImage(pic_loading, path);

            //pic_photoLoading.Image = System.Drawing.Image.FromFile(path);
            setOpacityImage(pic_photoLoading, path);
        }

        // このバイナリが実行されているパスを取得する
        private string getCurrentPath()
        {
            
            string path = Application.ExecutablePath;
            int yenPosition = path.LastIndexOf('\\');
            path = path.Substring(0, yenPosition);

            return path;
        }

        /// <summary>
        /// 「次へ」ボタンを押したとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pageNumber+1 >= lstPlaces.Items.Count)
            {
                return;
            }

            pageNumber++;

            refresh();
            
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (pageNumber - 1 < 0)
            {
                return;
            }

            pageNumber--;

            refresh();
        }

        private void refresh()
        {
            webSV.Width = lstPlaces.Location.X - 20;

            //webSV.Height = webSV.Width / 2;

            pic_photoLoading.Visible = true;
            
            
            // 場所一覧表の当該箇所をアクティブにする
            //この処理はなぜか例外を吐くことがあるのでtryで囲む
            try{
                lstPlaces.SelectedIndex = pageNumber;
            }
            catch (Exception ex)
            {

            }

            // 場所情報を取得する
            member myMember = (member)myProduct.members[pageNumber];

            navigator(webSV, webSV.Width, webSV.Height, myMember.sv);

            labelPlace.Text = myMember.place;

            lblMessage.Text = myMember.message;

            loading = new loadingWindow();
            loading.Show();

            nextMember = myMember;

            //timerResizeSv.Stop();   //タイマーインターバル初期化
            //timerResizeSv.Start();
            pic_photoLoading.Visible = false;
            webPhoto.Navigate(nextMember.photo);
        }

        //指定した画像ファイルを半透明で指定のPictureBoxに表示する
        private void setOpacityImage(PictureBox PictureBox1,string imageFilePath)
        {
            //描画先とするImageオブジェクトを作成する
            Bitmap canvas = new Bitmap(PictureBox1.Width, PictureBox1.Height);
            //ImageオブジェクトのGraphicsオブジェクトを作成する
            Graphics g = Graphics.FromImage(canvas);

            //画像を読み込む
            Image img = Image.FromFile(imageFilePath);

            //ColorMatrixオブジェクトの作成
            System.Drawing.Imaging.ColorMatrix cm =
                new System.Drawing.Imaging.ColorMatrix();
            //ColorMatrixの行列の値を変更して、アルファ値が0.5に変更されるようにする
            cm.Matrix00 = 1;
            cm.Matrix11 = 1;
            cm.Matrix22 = 1;
            cm.Matrix33 = 0.5F;
            cm.Matrix44 = 1;

            //ImageAttributesオブジェクトの作成
            System.Drawing.Imaging.ImageAttributes ia =
                new System.Drawing.Imaging.ImageAttributes();
            //ColorMatrixを設定する
            ia.SetColorMatrix(cm);

            //ImageAttributesを使用して画像を描画
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height),
                0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

            //リソースを解放する
            img.Dispose();
            g.Dispose();

            //PictureBox1に表示する
            PictureBox1.Image = canvas;
        }

        private void timerReloadSv_Tick(object sender, EventArgs e)
        {
            //timerResizeSv.Stop();

            //webSV.Height = webSV.Width;

            pic_photoLoading.Visible = false;

            webPhoto.Navigate(nextMember.photo);

            try
            {
                loading.Dispose();
            }catch{

            }
        }



        /// <summary>
        /// 指定したブラウザへ指定したURLを表示する
        /// </summary>
        /// <param name="target"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="url"></param>
        private void navigator(WebBrowser target,int width,int height,string url)
        {
            //target.Navigate(proxy);

            //パラメータの指定
            string param1 = "width=" + HttpUtility.UrlEncode(width+"");
            string param2 = "height=" + HttpUtility.UrlEncode(height+"");
            string param3 = "url=" + HttpUtility.UrlEncode(url);

            //パラメータをバイト配列に変換
            byte[] postData = Encoding.ASCII.GetBytes(param1 + "&" + param2 + "&" + param3);

            //WebBrowserコントロールに表示
            if (url.IndexOf("google") > 0)
            {
                target.Navigate(proxy, null, postData, "Content-Type: application/x-www-form-urlencoded\r\n");
            }
            else
            {
                target.Navigate(proxy_nonssl, null, postData, "Content-Type: application/x-www-form-urlencoded\r\n");
            }
        }



        

        private void ViewMapWindow_Resize(object sender, EventArgs e)
        {
            refresh();
        }

        private void lstPlaces_Click(object sender, EventArgs e)
        {
            pageNumber = lstPlaces.SelectedIndex;

            refresh();
        }

        private void btnRefer_Click(object sender, EventArgs e)
        {
            member myMember = (member)myProduct.members[pageNumber];
            
            Process.Start(myMember.refpage);
            /*
            string command = getCurrentPath() + "\\alex " + myMember.refpage;

            //Processオブジェクトを作成
            System.Diagnostics.Process p = new System.Diagnostics.Process();

            //ComSpec(cmd.exe)のパスを取得して、FileNameプロパティに指定
            p.StartInfo.FileName = System.Environment.GetEnvironmentVariable("ComSpec");
            //出力を読み取れるようにする
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = false;
            //ウィンドウを表示しないようにする
            p.StartInfo.CreateNoWindow = true;
            //コマンドラインを指定（"/c"は実行後閉じるために必要）
            p.StartInfo.Arguments = @"/c " +command + @" /w";

            //起動
            p.Start();

            //出力を読み取る
            string results = p.StandardOutput.ReadToEnd();

            //プロセス終了まで待機する
            //WaitForExitはReadToEndの後である必要がある
            //(親プロセス、子プロセスでブロック防止のため)
            p.WaitForExit();
            p.Close();
            
            //*/
        }

        private void btnYugami_Click(object sender, EventArgs e)
        {
            webSV.Height = webSV.Width / 2;

            

            // 場所情報を取得する
            member myMember = (member)myProduct.members[pageNumber];
            navigator(webSV, webSV.Width, webSV.Height, myMember.sv);


            loading = new loadingWindow();
            loading.Show();

            timerYugamiFix.Start();

            //timerResizeSv.Interval += 2000;
        }

        private void timerYugamiFix_Tick(object sender, EventArgs e)
        {
            webSV.Height = webSV.Width;

            try
            {
                loading.Dispose();
            }
            catch
            {

            }

            timerYugamiFix.Stop();
        }



        //アイコンをセットする
        private void setIcon()
        {
            string path = getCurrentPath();
            path += "\\settings\\icon.ico";
            this.Icon = new Icon(path);
        }

        private void btnCallMap_Click(object sender, EventArgs e)
        {
            member myMember = (member)myProduct.members[pageNumber];

            string mapUrl = myMember.map;

            mapWindow mapw = new mapWindow(mapUrl);

            mapw.Show();
        }
        /*
        Bitmap getWhite()
        {
            //描画先とするImageオブジェクトを作成する
            Bitmap canvas = new Bitmap(lblMessage.Width, lblMessage.Height);
            //ImageオブジェクトのGraphicsオブジェクトを作成する
            Graphics g = Graphics.FromImage(canvas);

            //画像を読み込む
            Image img = Image.FromFile(getCurrentPath()+"\\settings\\white.png");

            //ColorMatrixオブジェクトの作成
            System.Drawing.Imaging.ColorMatrix cm =
                new System.Drawing.Imaging.ColorMatrix();
            //ColorMatrixの行列の値を変更して、アルファ値が0.5に変更されるようにする
            cm.Matrix00 = 1;
            cm.Matrix11 = 1;
            cm.Matrix22 = 1;
            cm.Matrix33 = 0.5F;
            cm.Matrix44 = 1;

            //ImageAttributesオブジェクトの作成
            System.Drawing.Imaging.ImageAttributes ia =
                new System.Drawing.Imaging.ImageAttributes();
            //ColorMatrixを設定する
            ia.SetColorMatrix(cm);

            //ImageAttributesを使用して画像を描画
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height),
                0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

            //リソースを解放する
            img.Dispose();
            g.Dispose();

            return canvas;

        }*/
        
    }
}
