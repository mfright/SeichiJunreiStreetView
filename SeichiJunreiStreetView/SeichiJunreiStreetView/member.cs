using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;         //追加

namespace SeichiJunreiStreetView
{
    // １聖地を格納
    public class member
    {
        public string place = "";   //地名　秩父橋とか
        public string sv = "";      //StreetViewの埋め込みURL
        public string photo = "";    //写真のURL
        public string map = "";     //GoogleMapの埋め込みURL
        public string refpage = ""; //アニメ比較画像掲載URL
        public string message = "";  //ひとことメッセージ
        public Boolean noIframe = false;    //iframeでの表示をせず、ストリートビューを直に表示するか
    }

}
