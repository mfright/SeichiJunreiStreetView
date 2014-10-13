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
            this.webSV = new System.Windows.Forms.WebBrowser();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnRefer = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelPlace = new System.Windows.Forms.Label();
            this.webMap = new System.Windows.Forms.WebBrowser();
            this.lstPlaces = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // webSV
            // 
            this.webSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webSV.Location = new System.Drawing.Point(14, 40);
            this.webSV.MinimumSize = new System.Drawing.Size(20, 20);
            this.webSV.Name = "webSV";
            this.webSV.ScriptErrorsSuppressed = true;
            this.webSV.ScrollBarsEnabled = false;
            this.webSV.Size = new System.Drawing.Size(569, 547);
            this.webSV.TabIndex = 0;
            this.webSV.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPrev.Location = new System.Drawing.Point(265, 1);
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
            this.btnNext.Location = new System.Drawing.Point(390, 1);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(187, 33);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "次へ";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnRefer
            // 
            this.btnRefer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRefer.Location = new System.Drawing.Point(609, 1);
            this.btnRefer.Name = "btnRefer";
            this.btnRefer.Size = new System.Drawing.Size(191, 33);
            this.btnRefer.TabIndex = 3;
            this.btnRefer.Text = "この場面のアニメ比較ページ";
            this.btnRefer.UseVisualStyleBackColor = false;
            this.btnRefer.Click += new System.EventHandler(this.btnRefer_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(3, 3);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(211, 12);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "あの日見た花の名前を僕たちはまだ知らない";
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.labelPlace.Location = new System.Drawing.Point(11, 20);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(56, 16);
            this.labelPlace.TabIndex = 6;
            this.labelPlace.Text = "秩父橋";
            // 
            // webMap
            // 
            this.webMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.webMap.Location = new System.Drawing.Point(589, 249);
            this.webMap.MinimumSize = new System.Drawing.Size(20, 20);
            this.webMap.Name = "webMap";
            this.webMap.ScriptErrorsSuppressed = true;
            this.webMap.ScrollBarsEnabled = false;
            this.webMap.Size = new System.Drawing.Size(350, 338);
            this.webMap.TabIndex = 8;
            // 
            // lstPlaces
            // 
            this.lstPlaces.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPlaces.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.lstPlaces.FormattingEnabled = true;
            this.lstPlaces.ItemHeight = 20;
            this.lstPlaces.Location = new System.Drawing.Point(589, 39);
            this.lstPlaces.Name = "lstPlaces";
            this.lstPlaces.Size = new System.Drawing.Size(350, 204);
            this.lstPlaces.TabIndex = 9;
            this.lstPlaces.Click += new System.EventHandler(this.lstPlaces_Click);
            // 
            // ViewMapWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 599);
            this.Controls.Add(this.lstPlaces);
            this.Controls.Add(this.webMap);
            this.Controls.Add(this.labelPlace);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.btnRefer);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.webSV);
            this.Name = "ViewMapWindow";
            this.Text = "アニメタイトル";
            this.Load += new System.EventHandler(this.ViewMapWindow_Load);
            this.Resize += new System.EventHandler(this.ViewMapWindow_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webSV;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnRefer;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.WebBrowser webMap;
        private System.Windows.Forms.ListBox lstPlaces;
    }
}

