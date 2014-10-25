using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;         //追加

namespace SeichiJunreiStreetView
{
    //１作品分の聖地を格納
    public class product
    {
        public string title;   //作品のタイトル
        public string buttonImageFileName;  //ボタンの画像ファイル名
        public ArrayList members = new ArrayList();  //memberのインスタンスを格納。 作品に登場する聖地。
    }
}
