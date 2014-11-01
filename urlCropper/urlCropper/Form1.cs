using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace urlCropper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //場所名を取得
            if (txtPlace.Text == "")
            {
                return;
            }

            string placeName = txtPlace.Text;


            // ストリートビューのURLを取得
            int start = txtSv.Text.IndexOf("http");
            int end = txtSv.Text.IndexOf("\">");

            if (start < 0 || end < 0)
            {
                return;
            }

            string urlSv = txtSv.Text.Substring(start, end - start);


            // 地図のURLを取得
            start = txtMap.Text.IndexOf("http");
            end = txtMap.Text.IndexOf("\">");

            if (start < 0 || end < 0)
            {
                return;
            }

            string urlMap = txtMap.Text.Substring(start, end - start);

            // 参考サイトURLを取得
            string urlRef = txtRef.Text;

            //現場写真URLを取得
            string urlPhoto = txtPhoto.Text;


            // XMLの生成

            string xmlCode = "<member>\r\n";

            xmlCode += "  <place>" + placeName + "</place>\r\n";
            xmlCode += "  <sv>" + urlSv + "</sv>\r\n";
            xmlCode += "  <map>" + urlMap + "</map>\r\n";
            xmlCode += "  <ref>" + urlRef + "</ref>\r\n";
            xmlCode += "  <photo>" + urlPhoto + "</photo>\r\n";
            xmlCode += "</member>\r\n\r\n\r\n";

            txtXml.Text = xmlCode;

            txtXml.Select();

            txtPlace.Text = "";
            txtSv.Text = "";
            txtMap.Text = "";
            txtRef.Text = "";
            txtPhoto.Text = "";
        }
    }
}
