namespace SeichiJunreiStreetView
{
    partial class ViewMapWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.webSV = new System.Windows.Forms.WebBrowser();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnRefer = new System.Windows.Forms.Button();
            this.labelPlace = new System.Windows.Forms.Label();
            this.webPhoto = new System.Windows.Forms.WebBrowser();
            this.lstPlaces = new System.Windows.Forms.ListBox();
            this.timerResizeSv = new System.Windows.Forms.Timer(this.components);
            this.pic = new System.Windows.Forms.PictureBox();
            this.pic_loading = new System.Windows.Forms.PictureBox();
            this.btnCallMap = new System.Windows.Forms.Button();
            this.pic_photoLoading = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_loading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_photoLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // webSV
            // 
            this.webSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webSV.IsWebBrowserContextMenuEnabled = false;
            this.webSV.Location = new System.Drawing.Point(14, 34);
            this.webSV.MinimumSize = new System.Drawing.Size(20, 20);
            this.webSV.Name = "webSV";
            this.webSV.ScriptErrorsSuppressed = true;
            this.webSV.ScrollBarsEnabled = false;
            this.webSV.Size = new System.Drawing.Size(570, 553);
            this.webSV.TabIndex = 0;
            this.webSV.Url = new System.Uri("", System.UriKind.Relative);
            this.webSV.WebBrowserShortcutsEnabled = false;
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPrev.Location = new System.Drawing.Point(4, -1);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(125, 33);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "ひとつ前へ";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNext.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btnNext.Location = new System.Drawing.Point(135, -1);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(420, 33);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "次へ";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnRefer
            // 
            this.btnRefer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRefer.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btnRefer.Location = new System.Drawing.Point(803, 0);
            this.btnRefer.Name = "btnRefer";
            this.btnRefer.Size = new System.Drawing.Size(291, 33);
            this.btnRefer.TabIndex = 3;
            this.btnRefer.Text = "この場面のアニメ比較ページ";
            this.btnRefer.UseVisualStyleBackColor = false;
            this.btnRefer.Click += new System.EventHandler(this.btnRefer_Click);
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.labelPlace.Location = new System.Drawing.Point(10, 49);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(82, 24);
            this.labelPlace.TabIndex = 6;
            this.labelPlace.Text = "場所名";
            // 
            // webPhoto
            // 
            this.webPhoto.AllowWebBrowserDrop = false;
            this.webPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.webPhoto.IsWebBrowserContextMenuEnabled = false;
            this.webPhoto.Location = new System.Drawing.Point(590, 89);
            this.webPhoto.MinimumSize = new System.Drawing.Size(20, 20);
            this.webPhoto.Name = "webPhoto";
            this.webPhoto.ScriptErrorsSuppressed = true;
            this.webPhoto.ScrollBarsEnabled = false;
            this.webPhoto.Size = new System.Drawing.Size(504, 292);
            this.webPhoto.TabIndex = 8;
            this.webPhoto.WebBrowserShortcutsEnabled = false;
            // 
            // lstPlaces
            // 
            this.lstPlaces.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPlaces.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.lstPlaces.FormattingEnabled = true;
            this.lstPlaces.ItemHeight = 20;
            this.lstPlaces.Location = new System.Drawing.Point(590, 32);
            this.lstPlaces.Name = "lstPlaces";
            this.lstPlaces.Size = new System.Drawing.Size(509, 64);
            this.lstPlaces.TabIndex = 9;
            this.lstPlaces.Click += new System.EventHandler(this.lstPlaces_Click);
            // 
            // timerResizeSv
            // 
            this.timerResizeSv.Interval = 1;
            this.timerResizeSv.Tick += new System.EventHandler(this.timerReloadSv_Tick);
            // 
            // pic
            // 
            this.pic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic.Location = new System.Drawing.Point(653, 387);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(400, 200);
            this.pic.TabIndex = 13;
            this.pic.TabStop = false;
            // 
            // pic_loading
            // 
            this.pic_loading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_loading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_loading.Location = new System.Drawing.Point(14, 154);
            this.pic_loading.Name = "pic_loading";
            this.pic_loading.Size = new System.Drawing.Size(570, 433);
            this.pic_loading.TabIndex = 14;
            this.pic_loading.TabStop = false;
            // 
            // btnCallMap
            // 
            this.btnCallMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCallMap.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btnCallMap.Location = new System.Drawing.Point(561, 0);
            this.btnCallMap.Name = "btnCallMap";
            this.btnCallMap.Size = new System.Drawing.Size(241, 32);
            this.btnCallMap.TabIndex = 15;
            this.btnCallMap.Text = "地図を表示";
            this.btnCallMap.UseVisualStyleBackColor = false;
            this.btnCallMap.Click += new System.EventHandler(this.btnCallMap_Click);
            // 
            // pic_photoLoading
            // 
            this.pic_photoLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_photoLoading.BackColor = System.Drawing.Color.Transparent;
            this.pic_photoLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_photoLoading.Location = new System.Drawing.Point(590, 89);
            this.pic_photoLoading.Name = "pic_photoLoading";
            this.pic_photoLoading.Size = new System.Drawing.Size(509, 292);
            this.pic_photoLoading.TabIndex = 16;
            this.pic_photoLoading.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.lblMessage.Location = new System.Drawing.Point(12, 510);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(46, 16);
            this.lblMessage.TabIndex = 17;
            this.lblMessage.Text = "label1";
            // 
            // ViewMapWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1106, 599);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pic_photoLoading);
            this.Controls.Add(this.btnCallMap);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.lstPlaces);
            this.Controls.Add(this.webPhoto);
            this.Controls.Add(this.labelPlace);
            this.Controls.Add(this.btnRefer);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.webSV);
            this.Controls.Add(this.pic_loading);
            this.Name = "ViewMapWindow";
            this.Text = "アニメタイトル";
            this.Load += new System.EventHandler(this.ViewMapWindow_Load);
            this.Resize += new System.EventHandler(this.ViewMapWindow_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_loading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_photoLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webSV;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnRefer;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.WebBrowser webPhoto;
        private System.Windows.Forms.ListBox lstPlaces;
        private System.Windows.Forms.Timer timerResizeSv;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.PictureBox pic_loading;
        private System.Windows.Forms.Button btnCallMap;
        private System.Windows.Forms.PictureBox pic_photoLoading;
        private System.Windows.Forms.Label lblMessage;
    }
}

