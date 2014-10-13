using System;
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
            readXmls();
        }


            
        private void readXmls()
        {
            // このバイナリが実行されているパスを取得する
            string path = Application.ExecutablePath;
            int yenPosition = path.LastIndexOf('\\');
            path = path.Substring(0, yenPosition);


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

            for (int k=0; k < allProducts.Count; k++)
            {
                product myProduct = (product)allProducts[k];
                listProducts.Items.Add(myProduct.title);
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
                }

                ptrEnd = stResult.IndexOf("</member>",ptrStart);
                if (ptrEnd < 0)
                {
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
        /// メニューを選択したとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listProducts_Click(object sender, EventArgs e)
        {
            //選択されたメニューのタイトル文面を取得
            string title = (string)listProducts.SelectedItem;

            //タイトルに合致するものをallProductsから探す
            product targetProduct = searchProduct(title);

            // ViewMapWindowを表示する
            ViewMapWindow myViewMapWindow = new ViewMapWindow(targetProduct);
            myViewMapWindow.ShowDialog();
            myViewMapWindow.Dispose();
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
    }
}
