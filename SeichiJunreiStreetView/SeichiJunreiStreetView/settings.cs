using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace SeichiJunreiStreetView
{
    class settings
    {
        public static int resize_millisecond = 1;

        public static MenuWindow menuWindow = null;

        public static int onlineVersion = -1; // -1のとき、読み込み失敗
        public static int localVersion = -1; // -1のとき、読み込み失敗


        public static void loadIni()
        {
            try
            {
                // このバイナリが実行されているパスを取得する
                string path = System.Windows.Forms.Application.ExecutablePath;
                int yenPosition = path.LastIndexOf('\\');
                path = path.Substring(0, yenPosition);

                path += "\\settings\\revision.ini";

                StreamReader sr = new StreamReader(path, Encoding.GetEncoding("Shift_JIS"));

                string text = sr.ReadToEnd();

                sr.Close();

                // 設定を読み込む

                localVersion = int.Parse(text);

            }
            catch (Exception ex)
            {

            }
        }
    }

    
}
