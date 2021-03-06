﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using System.Collections;         //追加
using System.Web;
using System.Diagnostics;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.Windows.Forms;



namespace SeichiJunreiStreetView
{
    public partial class MenuWindow : Form
    {
        ArrayList allProducts = new ArrayList();    //productを格納する

        


        public MenuWindow()
        {
            InitializeComponent();
        }

        private void MenuWindow_Load(object sender, EventArgs e)
        {
            setIcon();

            setBannerImage();

            setHeadPic();

            settings.loadIni();

            readXmls();

            //もしオンラインにもっと最新版があれば、ダウンロードを促すボタンを表示
            if (settings.onlineVersion != -1 && settings.onlineVersion > settings.localVersion)
            {
                btn_UpdateSite.Visible = true;
            }

            editRegistry();

        }

        // webBrowserコンポーネントでIE11を使用するよう設定
        void editRegistry()
        {
            string FBE = @"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION";
            Microsoft.Win32.RegistryKey regkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(FBE);
            
            string pname = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe";
            string dname = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".vshost.exe";

            regkey.SetValue(pname, 11001, Microsoft.Win32.RegistryValueKind.DWord);
            regkey.SetValue(dname, 11001, Microsoft.Win32.RegistryValueKind.DWord);

        }

        // webBrowserコンポーネントでIE11を使用する設定を削除
        void deleteRegistory()
        {
            string FBE = @"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION";
            Microsoft.Win32.RegistryKey regkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(FBE);

            string pname = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe";
            string dname = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".vshost.exe";

            regkey.DeleteValue(pname);
            regkey.DeleteValue(dname);

        }

        void setHeadPic()
        {
            // このバイナリが実行されているパスを取得する
            string path = getCurrentPath();

            path += "\\settings\\head.png";

            picHead.Image = System.Drawing.Image.FromFile(path);


        }

        //座標と画像ファイル名を指定して、ボタンを作成。
        private void createButton(string name,int x,int y,int z,string fileName)
        {
            // タブページが不足していたら、追加する
            for (; true; )
            {
                if (tabControl.TabPages.Count < z + 1)
                {
                    tabControl.TabPages.Add("PAGE-" + (tabControl.TabPages.Count + 1));
                }
                else
                {
                    break;
                }
            }

            //Buttonクラスのインスタンスを作成する
            Button Button1 = new System.Windows.Forms.Button();
            
            //Buttonコントロールのプロパティを設定する
            Button1.Name = name;
            Button1.Text = "";
            //サイズと位置を設定する
            Button1.Location = new Point(x, y);
            Button1.Size = new System.Drawing.Size(400, 200);

            // このバイナリが実行されているパスを取得する
            string path = Application.ExecutablePath;
            int yenPosition = path.LastIndexOf('\\');
            path = path.Substring(0, yenPosition);

            Button1.BackgroundImage = System.Drawing.Image.FromFile(path + "\\xml\\" + fileName);
            Button1.BackgroundImageLayout = ImageLayout.Center;

            Button1.Click += new EventHandler(menuButton_Click);

            //フォームに追加する
            //this.Controls.Add(Button1);
            this.tabControl.TabPages[z].Controls.Add(Button1);
        }

        // メニューのボタンが押された時
        void menuButton_Click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            int index = int.Parse(senderButton.Name);
            
            //タイトルに合致するものをallProductsから探す
            product targetProduct = (product)allProducts[index];

            // ViewMapWindowを表示する
            ViewMapWindow myViewMapWindow = new ViewMapWindow(targetProduct);
            myViewMapWindow.ShowDialog();
            myViewMapWindow.Dispose();
        }




            
        private void readXmls()
        {
            string path = getCurrentPath();


            //ファイル一覧を取得する
            string[] files = Directory.GetFiles(path + "\\xml\\");


            for (int i = 0; i < files.Length; i++)
            {
                // xmlファイルのとき
                if (files[i].Substring(files[i].Length - 4, 4).Equals(".xml"))
                {
                    // そのxmlを読み込み、allProductsへ追加
                    product myProduct = readXml(files[i]);
                    allProducts.Add(myProduct);
                }
            }

            // メニュー一覧へ項目を追加
            for (int k=0; k < allProducts.Count; k++)
            {
                product myProduct = (product)allProducts[k];
                //listProducts.Items.Add(myProduct.title);


                int pointY = 0 + ((k % 6) / 3) * 200;   //X座標
                int pointX = 0 + (k % 3) * 400;         //y座標
                int pointZ = k / 6;                     //Tabインデックス

                createButton(k + "", pointX, pointY,pointZ, myProduct.buttonImageFileName);
            }
        }


        /// <summary>
        /// xmlを読み込み、product型で返す
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private product readXml(string filePath)
        {
            
            // StreamReader の新しいインスタンスを生成する
            System.IO.StreamReader cReader = (
                new System.IO.StreamReader(filePath, System.Text.Encoding.Default)
            );

            // 読み込んだ結果をすべて格納するための変数を宣言する
            string stResult = string.Empty;

            // 読み込みできる文字がなくなるまで繰り返す
            while (cReader.Peek() >= 0)
            {
                // ファイルを 1 行ずつ読み込む
                string stBuffer = cReader.ReadLine();

                // 読み込んだものを追加で格納する
                stResult += stBuffer + System.Environment.NewLine;
            }

            // cReader を閉じる (正しくは オブジェクトの破棄を保証する を参照)
            cReader.Close();




            // 数える用の文字列ポインタ
            int ptrStart = 0;
            int ptrEnd = 0;
            int cursor = 0;

            //productを作成
            product myProduct = new product();

            
            //聖地のタイトルを保存
            ptrStart = stResult.IndexOf("<title>") + 7;
            ptrEnd = stResult.IndexOf("</title>", ptrStart);
            myProduct.title = stResult.Substring(ptrStart, ptrEnd - ptrStart);

            //ボタンの画像ファイル名を保存
            ptrStart = stResult.IndexOf("<button>") + 8;
            ptrEnd = stResult.IndexOf("</button>", ptrStart);
            myProduct.buttonImageFileName = stResult.Substring(ptrStart, ptrEnd - ptrStart);

            


            //聖地のmemberらを取得する

            ptrStart = 0;
            ptrEnd = 0;
            cursor = 0;
            for (int j = 0; true; j++)
            {
                // <member>～</member>までを抽出
                ptrStart = stResult.IndexOf("<member>",cursor);
                if (ptrStart < 0)
                {
                    break;
                    MessageBox.Show("<member>タグが見つかりません","エラー");
                }

                ptrEnd = stResult.IndexOf("</member>",ptrStart);                
                if (ptrEnd < 0)
                {
                    MessageBox.Show("</member>タグが見つかりません", "エラー");
                    break;
                }

                //カーソルを進める。
                cursor = ptrEnd + 9;




                

                string strMember = stResult.Substring(ptrStart,ptrEnd-ptrStart);



                member myMember = new member();

                // place要素を保管
                ptrStart = strMember.IndexOf("<place>") + 7;
                ptrEnd = strMember.IndexOf("</place>");
                myMember.place = strMember.Substring(ptrStart, ptrEnd - ptrStart);

                // sv要素を保管
                ptrStart = strMember.IndexOf("<sv>") + 4;
                ptrEnd = strMember.IndexOf("</sv>");
                string url = strMember.Substring(ptrStart, ptrEnd - ptrStart);
                if (url.IndexOf("http") != -1)
                {
                    url = url.Substring(url.IndexOf("//")+2);
                }
                myMember.sv = url;

                // photo要素を保管
                ptrStart = strMember.IndexOf("<photo>") + 7;
                ptrEnd = strMember.IndexOf("</photo>");
                string photo = strMember.Substring(ptrStart, ptrEnd - ptrStart);
                if (photo.IndexOf("http") != -1)
                {
                    photo = photo.Substring(photo.IndexOf("//") + 2);
                }
                myMember.photo = photo;

                // mapを保管
                ptrStart = strMember.IndexOf("<map>") + 5;
                ptrEnd = strMember.IndexOf("</map>");
                url = strMember.Substring(ptrStart, ptrEnd - ptrStart);
                if (url.IndexOf("http") != -1)
                {
                    url = url.Substring(url.IndexOf("//")+2);
                }
                myMember.map = url;

                // refpageを保管
                ptrStart = strMember.IndexOf("<ref>") + 5;
                ptrEnd = strMember.IndexOf("</ref>");
                url = strMember.Substring(ptrStart, ptrEnd - ptrStart);
                
                myMember.refpage = url;


                // messageを保管
                ptrStart = strMember.IndexOf("<message>") + 9;
                ptrEnd = strMember.IndexOf("</message>", ptrStart);
                if (ptrStart > 0 && ptrEnd > 0)
                {
                    //もしmessageがあれば、改行を入れて保存
                    string mes = strMember.Substring(ptrStart, ptrEnd - ptrStart);
                    for(int i=40;i<mes.Length; i+=40){

                        mes = mes.Insert(i, "\r\n");
                    }
                    myMember.message = mes;

                }

                // noIframe属性を確認
                if (strMember.IndexOf("<noiframe>true</noiframe>") > 0)
                {
                    // <noiframe>true</noiframe>　が含まれていれば、iframeで表示しない
                    myMember.noIframe = true;
                }


                //myMemberをmyProductへ追加
                myProduct.members.Add(myMember);


                

                //カーソルが最後まで行ったら終了
                if (cursor >= stResult.Length)
                {
                    break;
                }
            }

            return myProduct;

        }

        

        


        /// <summary>
        /// タイトルでallProductから探す
        /// </summary>
        /// <param name="searchTitle"></param>
        /// <returns></returns>
        private product searchProduct(string searchTitle)
        {
            for (int i = 0; i < allProducts.Count; i++)
            {
                product myProduct = (product)allProducts[i];

                if (myProduct.title.Equals(searchTitle))
                {
                    return myProduct;
                }
            }

            return null;
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

        private void setBannerImage()
        {
            // このバイナリが実行されているパスを取得する
            string path = getCurrentPath();
            string pathA = path + "\\settings\\animelocations.jpg";
            string pathD = path + "\\settings\\ddhost.png";

            btnAnimeLocations.BackgroundImage = System.Drawing.Image.FromFile(pathA);
            btnAnimeLocations.BackgroundImageLayout = ImageLayout.Center;

            btnDDHOST.BackgroundImage = System.Drawing.Image.FromFile(pathD);
            btnDDHOST.BackgroundImageLayout = ImageLayout.Center;
        }

        private void btnAnimeLocations_Click(object sender, EventArgs e)
        {
            //Process.Start("http://animelocations.iza-yoi.net");

            ViewMapWindow.alexNavigate("http://animelocations.iza-yoi.net");
        }

        private void MenuWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            deleteRegistory(); 

            Application.Exit();
        }

        private void btn_UpdateSite_Click(object sender, EventArgs e)
        {
            //Process.Start("http://animelocations.iza-yoi.net/sjsv.html");

            ViewMapWindow.alexNavigate("http://animelocations.iza-yoi.net/sjsv.html");
        }

        private void btnDDHOST_Click(object sender, EventArgs e)
        {
            //Process.Start("http://www.ddhost.jp");

            ViewMapWindow.alexNavigate("http://www.ddhost.jp");
        }
    }
}
