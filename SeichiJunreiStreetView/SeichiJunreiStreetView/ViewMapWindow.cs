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
        static string proxy = "http://slcp.sourceforge.jp/seichiJunrei/generator.php";

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
           
            labelTitle.Text = myProduct.title;
            Text = myProduct.title;

            /*
            member firstMember = (member)myProduct.members[0];
            navigator(webSV, webSV.Width, webSV.Height, firstMember.sv);


            navigator(webMap, webMap.Width, webMap.Height, firstMember.map);

            labelPlace.Text = firstMember.place; */

            for (int i = 0; i < myProduct.members.Count; i++)
            {
                member myMember = (member)myProduct.members[i];
                lstPlaces.Items.Add(myMember.place);
            }

            lstPlaces.SelectedIndex = 0;

            refresh();

            //最大化表示
            //this.WindowState = FormWindowState.Maximized;
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
            webSV.Height = webSV.Width / 2;
            
            // 場所一覧表の当該箇所をアクティブにする
            lstPlaces.SelectedIndex = pageNumber;

            // 場所情報を取得する
            member myMember = (member)myProduct.members[pageNumber];

            navigator(webSV, webSV.Width, webSV.Height, myMember.sv);



            loading = new loadingWindow();
            loading.Show();

            nextMember = myMember;

            timerResizeSv.Start();
        }

        private void timerReloadSv_Tick(object sender, EventArgs e)
        {
            timerResizeSv.Stop();

            webSV.Height = webSV.Width;

            navigator(webMap, webMap.Width, webMap.Height, nextMember.map);

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
            target.Navigate(proxy);

            //パラメータの指定
            string param1 = "width=" + HttpUtility.UrlEncode(width+"");
            string param2 = "height=" + HttpUtility.UrlEncode(height+"");
            string param3 = "url=" + HttpUtility.UrlEncode(url);

            //パラメータをバイト配列に変換
            byte[] postData = Encoding.ASCII.GetBytes(param1 + "&" + param2 + "&" + param3);

            //WebBrowserコントロールに表示
            target.Navigate(proxy, null, postData,"Content-Type: application/x-www-form-urlencoded\r\n");
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

        

        

        
        
    }
}
