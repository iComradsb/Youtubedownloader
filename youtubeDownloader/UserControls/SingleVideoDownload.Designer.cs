namespace youtubeDownloader.UserControls
{
    partial class SingleVideoDownload
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.txt_Duration = new System.Windows.Forms.TextBox();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.btn_download = new System.Windows.Forms.Button();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Duration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Title";
            // 
            // txt_author
            // 
            this.txt_author.Location = new System.Drawing.Point(75, 50);
            this.txt_author.Name = "txt_author";
            this.txt_author.ReadOnly = true;
            this.txt_author.Size = new System.Drawing.Size(171, 20);
            this.txt_author.TabIndex = 12;
            // 
            // txt_Duration
            // 
            this.txt_Duration.Location = new System.Drawing.Point(75, 82);
            this.txt_Duration.Name = "txt_Duration";
            this.txt_Duration.ReadOnly = true;
            this.txt_Duration.Size = new System.Drawing.Size(171, 20);
            this.txt_Duration.TabIndex = 11;
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(75, 19);
            this.txt_title.Name = "txt_title";
            this.txt_title.ReadOnly = true;
            this.txt_title.Size = new System.Drawing.Size(171, 20);
            this.txt_title.TabIndex = 10;
            // 
            // btn_download
            // 
            this.btn_download.Location = new System.Drawing.Point(17, 160);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(150, 23);
            this.btn_download.TabIndex = 9;
            this.btn_download.Text = "start download";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_ClickAsync);
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(17, 134);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(514, 20);
            this.txt_url.TabIndex = 8;
            // 
            // SingleVideoDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.txt_Duration);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.txt_url);
            this.Name = "SingleVideoDownload";
            this.Size = new System.Drawing.Size(540, 445);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.TextBox txt_Duration;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.TextBox txt_url;
    }
}
