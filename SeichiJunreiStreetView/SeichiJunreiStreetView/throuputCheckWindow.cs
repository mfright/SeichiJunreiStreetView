using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Net;
using System.IO;
using System.Text;

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

            // オンラインのリビジョンのダウンロード
            Thread threadA = new Thread(new ThreadStart(loadRevision));
            threadA.Start();

            //calculator.pngを読み込む
            string url = "http://slcp.sourceforge.jp/seichiJunrei/calculator.png?id="+generateRandom();
            //string url = "https://maps.google.co.jp/maps?source=embed&amp;hl=ja&amp;ie=UTF8&amp;ll=35.571674,139.376636&amp;spn=0.011327,0.021093&amp;t=h&amp;z=16&amp;brcurrent=3,0x6018fd7cb5d648df:0x35324c2e09988f42,1&amp;layer=c&amp;cbll=35.571674,139.376636&amp;panoid=V_IAnyQ1TPhmvldJEbt_0w&amp;cbp=12,174.73,,0,0&amp;output=svembed" + "&gomi=" + generateRandom();
            //string url = "http://slcp.sourceforge.jp/seichiJunrei/calculator2.bmp?id=" + generateRandom();

            webBrowserImage.Navigate(url);

            myTimer.Start();

            
        }

        void loadRevision()
        {
            try
            {
                string url = "http://slcp.sourceforge.jp/seichiJunrei/repository.txt";

                WebClient wc = new WebClient();
                Stream st = wc.OpenRead(url);

                StreamReader sr = new StreamReader(st,
                                    Encoding.GetEncoding("Shift_JIS"));
                //Console.WriteLine(sr.ReadToEnd());
                string onVer = sr.ReadToEnd();
                settings.onlineVersion = int.Parse(onVer);

                sr.Close();
                st.Close();
            }
            catch (Exception ex)
            {

            }
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


            //settings.resize_millisecond = handredMilliSecond * 90;
            settings.resize_millisecond = handredMilliSecond * 150 ;

            if (settings.menuWindow == null)
            {
                settings.menuWindow = new MenuWindow();
                settings.menuWindow.Show();
            }

            this.Visible = false;
        }
    }
}
