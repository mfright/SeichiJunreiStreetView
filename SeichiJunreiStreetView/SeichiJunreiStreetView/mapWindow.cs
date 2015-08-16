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

namespace SeichiJunreiStreetView
{
    public partial class mapWindow : Form
    {
        static string proxy = "https://slcp.osdn.jp/seichiJunrei/generator_map.php";

        string mapUrl = "";

        public mapWindow(string targetUrl)
        {
            InitializeComponent();

            mapUrl = targetUrl;
        }

        private void mapWindow_Load(object sender, EventArgs e)
        {
            // ウィンドウのアイコンを変更
            setIcon();


            //webBrowser1.Navigate(mapUrl);

            navigate(mapUrl);
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


        private void navigate(string url)
        {
            int width = webBrowser1.Width;
            int height = webBrowser1.Height;

            //パラメータの指定
            string param1 = "width=" + HttpUtility.UrlEncode(width + "");
            string param2 = "height=" + HttpUtility.UrlEncode(height + "");
            string param3 = "url=" + HttpUtility.UrlEncode(url);

            //パラメータをバイト配列に変換
            byte[] postData = Encoding.ASCII.GetBytes(param1 + "&" + param2 + "&" + param3);

            //WebBrowserコントロールに表示
            webBrowser1.Navigate(proxy, null, postData, "Content-Type: application/x-www-form-urlencoded\r\n");
        }

    }
}
