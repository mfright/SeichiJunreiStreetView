using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace DD_HOST_Explorer
{
    public partial class Form1 : Form
    {
        //フルスクリーンモードか
        public bool fullscreen = false;

        //透過してるか
        public bool opacity = false;

        //ホームページのＵＲＬ
        public string homeurl;

        //設定ファイル名
        string inifile = "alex.ini";

        //設定ファイルのパス
        string location2;

        public Form1()
        {
            InitializeComponent();

            if (opacity == false)
            {
                this.Opacity = 0.9;  // 不透明度設定
            }

            //このバイナリのパスを取得
            string location = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            //設定ファイルのパス
            location2 = location + "\\" + inifile;

            if (!File.Exists(location2))
            {
                //設定ファイルがないとき
                StreamWriter sw = new StreamWriter(location2, true, Encoding.Default);
                sw.WriteLine("http://www.ddhost.jp");
                sw.Close();
            }

            //設定ファイル読み込み
            StreamReader sr = new StreamReader(location2, Encoding.Default);

            //ホームのアドレス取得
            homeurl = sr.ReadLine();

            sr.Close();

            //ブラウザにホームを表示
            webBrowser1.Navigate(homeurl);

            //ブラウザにフォーカスを当てる
            webBrowser1.Focus();
        }
        

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void screenModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fullscreen == false)
            {
                this.FormBorderStyle = FormBorderStyle.None;

                this.WindowState = FormWindowState.Maximized;

                fullscreen = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;

                this.FormBorderStyle = FormBorderStyle.FixedSingle;

                fullscreen = false;
            }
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Opacity = 0.8;  // 不透明度設定

            Form modalDialog = new Version();
            DialogResult result = modalDialog.ShowDialog();

            switch (result)
            {
                case DialogResult.Yes:
                    //　適当な処理
                    webBrowser1.Navigate("http://www.ddhost.jp");
                    break;
                
            }

            //this.Opacity = 1;  // 不透明度設定
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtURL.Text != "")
            {
                webBrowser1.Navigate(txtURL.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            googleSearch();
        }

        public void googleSearch()
        {
            string url = "http://www.google.co.jp/search?q=";

            if (txtURL.Text != "")
            {
                webBrowser1.Navigate(url + txtURL.Text);
                toolStripStatusLabel1.Text = "Now loading...";
            }
        }

        private void txtURL_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            
            e.SuppressKeyPress = true;
            
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(txtURL.Text);
                toolStripStatusLabel1.Text = "Now loading...";
            }
        }

        private void changeOpacityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (opacity == true)
            {
                opacity = false;
                this.Opacity = 0.9;
            }
            else
            {
                opacity = true;
                this.Opacity = 1;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtURL.Text);
            toolStripStatusLabel1.Text = "Now loading...";
        }

        private void newTab_Paint(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            txtURL.Text = webBrowser1.Url.OriginalString;
            toolStripStatusLabel1.Text = "Fin";

            //tabPage1.Text = webBrowser1.DocumentTitle;
            this.Text = "Alex - " + webBrowser1.DocumentTitle;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void forwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void googleSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            googleSearch();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowSaveAsDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Print();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(homeurl);
            toolStripStatusLabel1.Text = "Now loading...";
        }

        private void setThisPageAsHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homeurl = webBrowser1.Url.AbsoluteUri;

            StreamWriter sw = new StreamWriter(location2, false, Encoding.Default);
            sw.WriteLine(homeurl);
            sw.Close();
        }

        /*
        private void btnNewTab_Click(object sender, EventArgs e)
        {
            browseTab myTabPage = new browseTab("myTabPage");
            tabBrowse.TabPages.Add(myTabPage);

        }*/
    }
}
