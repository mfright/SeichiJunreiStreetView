namespace SeichiJunreiStreetView
{
    partial class throuputCheckWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.webBrowserImage = new System.Windows.Forms.WebBrowser();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.lblSec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // picLoading
            // 
            this.picLoading.Location = new System.Drawing.Point(0, 0);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(500, 300);
            this.picLoading.TabIndex = 0;
            this.picLoading.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.White;
            this.lblMessage.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.lblMessage.Location = new System.Drawing.Point(22, 89);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(176, 20);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "通信速度を計測中...";
            // 
            // webBrowserImage
            // 
            this.webBrowserImage.Location = new System.Drawing.Point(155, 185);
            this.webBrowserImage.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserImage.Name = "webBrowserImage";
            this.webBrowserImage.Size = new System.Drawing.Size(142, 70);
            this.webBrowserImage.TabIndex = 2;
            this.webBrowserImage.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowserImage_DocumentCompleted);
            // 
            // myTimer
            // 
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.BackColor = System.Drawing.Color.White;
            this.lblSec.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.lblSec.Location = new System.Drawing.Point(197, 89);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(29, 20);
            this.lblSec.TabIndex = 3;
            this.lblSec.Text = "00";
            // 
            // throuputCheckWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 299);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.webBrowserImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "throuputCheckWindow";
            this.Text = "throuputCheckWindow";
            this.Load += new System.EventHandler(this.throuputCheckWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLoading;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.WebBrowser webBrowserImage;
        private System.Windows.Forms.Timer myTimer;
        private System.Windows.Forms.Label lblSec;
    }
}