using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Text;

namespace SeichiJunreiStreetView
{
    class settings
    {
        public static int resize_second = 10;

        public static void loadIni()
        {
            // このバイナリが実行されているパスを取得する
            string path = System.Windows.Forms.Application.ExecutablePath;
            int yenPosition = path.LastIndexOf('\\');
            path = path.Substring(0, yenPosition);

            path += "\\settings\\settings.ini";

            StreamReader sr = new StreamReader(path, Encoding.GetEncoding("Shift_JIS"));

            string text = sr.ReadToEnd();

            sr.Close();

            
            if(text.IndexOf("resize_second:") != -1){
                int startPoint = text.IndexOf("resize_second:") + 14;
                int endPoint = text.IndexOf("\r", startPoint);

                string second = text.Substring(startPoint, endPoint - startPoint);
                resize_second = int.Parse(second);

            }

            
        }
    }

    
}
