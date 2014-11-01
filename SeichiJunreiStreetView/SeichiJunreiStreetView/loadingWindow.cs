using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeichiJunreiStreetView
{
    public partial class loadingWindow : Form
    {
        public loadingWindow()
        {
            InitializeComponent();
        }

        private void loadingWindow_Load(object sender, EventArgs e)
        {
            timerClose.Interval = settings.resize_millisecond;
            timerClose.Start();
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadingWindow_Leave(object sender, EventArgs e)
        {
            this.Activate();
        }
    }
}
