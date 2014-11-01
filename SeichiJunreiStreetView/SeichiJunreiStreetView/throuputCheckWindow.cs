using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeichiJunreiStreetView
{
    public partial class throuputCheckWindow : Form
    {  //本ウィンドウでは、ウェブサーバ上にある1MBの画像ファイルをダウンロードし、通信速度を測定する。


        // calculator.pngを読み込むのに要した時間(100ミリ秒単位)
        int handredMilliSecond = 0;

        public throuputCheckWindow()
        {
            InitializeComponent();
        }

        private void throuputCheckWindow_Load(object sender, EventArgs e)
        {
            setIcon();

            setHeadPic();
            

            //calculator.pngを読み込む
            string url = "http://slcp.sourceforge.jp/seichiJunrei/calculator.png?id="+generateRandom();
            webBrowserImage.Navigate(url);

            myTimer.Start();
        }

        int generateRandom()
        {
            int seed = Environment.TickCount;
            Random rnd = new Random(seed++);
            return rnd.Next(1, 1000);
        }

        //アイコンをセットする
        private void setIcon()
        {
            string path = getCurrentPath();
            path += "\\settings\\icon.ico";
            this.Icon = new Icon(path);
        }

        // このバイナリが実行されているパスを取得する
        private string getCurrentPath()
        {

            string path = Application.ExecutablePath;
            int yenPosition = path.LastIndexOf('\\');
            path = path.Substring(0, yenPosition);

            return path;
        }

        void setHeadPic()
        {
            // このバイナリが実行されているパスを取得する
            string path = getCurrentPath();

            path += "\\settings\\loading-banner.png";

            picLoading.Image = System.Drawing.Image.FromFile(path);


        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            handredMilliSecond++;

            lblSec.Text = handredMilliSecond+"";
        }

        private void webBrowserImage_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            myTimer.Stop();

            //label1.Text = handredMilliSecond + "　×100ミリ秒";

            settings.resize_millisecond = handredMilliSecond * 90;

            MenuWindow menuWin = new MenuWindow();
            menuWin.Show();

            this.Visible = false;
        }
    }
}
