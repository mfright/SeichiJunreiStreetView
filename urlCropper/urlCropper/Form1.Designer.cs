namespace urlCropper
{
    partial class Form1
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
            this.txtSv = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtXml = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.txtPhoto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSv
            // 
            this.txtSv.Location = new System.Drawing.Point(3, 80);
            this.txtSv.Multiline = true;
            this.txtSv.Name = "txtSv";
            this.txtSv.Size = new System.Drawing.Size(224, 38);
            this.txtSv.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(3, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "XMLコード生成";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtXml
            // 
            this.txtXml.Location = new System.Drawing.Point(3, 423);
            this.txtXml.Multiline = true;
            this.txtXml.Name = "txtXml";
            this.txtXml.Size = new System.Drawing.Size(224, 99);
            this.txtXml.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "ストリートビューのiframeのhtmlを入れてください";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "貼り付けるXMLコード";
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(1, 18);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(226, 19);
            this.txtPlace.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "場所名（表示名）を入れてください";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "地図のiframeのhtmlを入れてください";
            // 
            // txtMap
            // 
            this.txtMap.Location = new System.Drawing.Point(5, 148);
            this.txtMap.Multiline = true;
            this.txtMap.Name = "txtMap";
            this.txtMap.Size = new System.Drawing.Size(222, 33);
            this.txtMap.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "参考ウェブサイトのURLを入れてください";
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(3, 219);
            this.txtRef.Multiline = true;
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(224, 32);
            this.txtRef.TabIndex = 10;
            // 
            // txtPhoto
            // 
            this.txtPhoto.Location = new System.Drawing.Point(3, 286);
            this.txtPhoto.Name = "txtPhoto";
            this.txtPhoto.Size = new System.Drawing.Size(224, 19);
            this.txtPhoto.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "現場写真のURLを入れてください。";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 530);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPhoto);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtXml);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "URL CROPPER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtXml;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.TextBox txtPhoto;
        private System.Windows.Forms.Label label6;
    }
}

