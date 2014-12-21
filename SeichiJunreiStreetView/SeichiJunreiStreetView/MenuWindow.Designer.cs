namespace SeichiJunreiStreetView
{
    partial class MenuWindow
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
            this.picHead = new System.Windows.Forms.PictureBox();
            this.btnAnimeLocations = new System.Windows.Forms.Button();
            this.btn_UpdateSite = new System.Windows.Forms.Button();
            this.btnDDHOST = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picHead)).BeginInit();
            this.SuspendLayout();
            // 
            // picHead
            // 
            this.picHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picHead.Location = new System.Drawing.Point(12, 0);
            this.picHead.Name = "picHead";
            this.picHead.Size = new System.Drawing.Size(1200, 100);
            this.picHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picHead.TabIndex = 1;
            this.picHead.TabStop = false;
            // 
            // btnAnimeLocations
            // 
            this.btnAnimeLocations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnimeLocations.Location = new System.Drawing.Point(1007, 2);
            this.btnAnimeLocations.Name = "btnAnimeLocations";
            this.btnAnimeLocations.Size = new System.Drawing.Size(205, 45);
            this.btnAnimeLocations.TabIndex = 2;
            this.btnAnimeLocations.UseVisualStyleBackColor = true;
            this.btnAnimeLocations.Click += new System.EventHandler(this.btnAnimeLocations_Click);
            // 
            // btn_UpdateSite
            // 
            this.btn_UpdateSite.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_UpdateSite.Location = new System.Drawing.Point(12, 12);
            this.btn_UpdateSite.Name = "btn_UpdateSite";
            this.btn_UpdateSite.Size = new System.Drawing.Size(168, 48);
            this.btn_UpdateSite.TabIndex = 3;
            this.btn_UpdateSite.Text = "より新しいバージョンがあります。ウェブサイトからダウンロード。";
            this.btn_UpdateSite.UseVisualStyleBackColor = true;
            this.btn_UpdateSite.Visible = false;
            this.btn_UpdateSite.Click += new System.EventHandler(this.btn_UpdateSite_Click);
            // 
            // btnDDHOST
            // 
            this.btnDDHOST.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDDHOST.Location = new System.Drawing.Point(1007, 56);
            this.btnDDHOST.Name = "btnDDHOST";
            this.btnDDHOST.Size = new System.Drawing.Size(205, 45);
            this.btnDDHOST.TabIndex = 4;
            this.btnDDHOST.UseVisualStyleBackColor = true;
            this.btnDDHOST.Click += new System.EventHandler(this.btnDDHOST_Click);
            // 
            // MenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1224, 521);
            this.Controls.Add(this.btnDDHOST);
            this.Controls.Add(this.btn_UpdateSite);
            this.Controls.Add(this.btnAnimeLocations);
            this.Controls.Add(this.picHead);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "MenuWindow";
            this.Text = "聖地巡礼ストリートビュー";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuWindow_FormClosed);
            this.Load += new System.EventHandler(this.MenuWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHead)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picHead;
        private System.Windows.Forms.Button btnAnimeLocations;
        private System.Windows.Forms.Button btn_UpdateSite;
        private System.Windows.Forms.Button btnDDHOST;
    }
}