using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace DD_HOST_Explorer
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string targetUrl = null;
            if(args.Length > 0){
                targetUrl = args[0];
            }
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 myForm1 = new Form1(targetUrl);

            Application.Run(myForm1);

            
        }
    }
}
