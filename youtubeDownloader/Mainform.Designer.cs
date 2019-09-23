namespace youtubeDownloader
{
    partial class Mainform
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
            this.txt_url = new System.Windows.Forms.TextBox();
            this.btn_download = new System.Windows.Forms.Button();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.txt_Duration = new System.Windows.Forms.TextBox();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_playlist = new System.Windows.Forms.TextBox();
            this.btn_playlist = new System.Windows.Forms.Button();
            this.pnl_status = new System.Windows.Forms.Panel();
            this.pnl_form = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(12, 140);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(514, 20);
            this.txt_url.TabIndex = 0;
            // 
            // btn_download
            // 
            this.btn_download.Location = new System.Drawing.Point(12, 166);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(150, 23);
            this.btn_download.TabIndex = 1;
            this.btn_download.Text = "start download";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(70, 25);
            this.txt_title.Name = "txt_title";
            this.txt_title.ReadOnly = true;
            this.txt_title.Size = new System.Drawing.Size(171, 20);
            this.txt_title.TabIndex = 2;
            // 
            // txt_Duration
            // 
            this.txt_Duration.Location = new System.Drawing.Point(70, 88);
            this.txt_Duration.Name = "txt_Duration";
            this.txt_Duration.ReadOnly = true;
            this.txt_Duration.Size = new System.Drawing.Size(171, 20);
            this.txt_Duration.TabIndex = 3;
            // 
            // txt_author
            // 
            this.txt_author.Location = new System.Drawing.Point(70, 56);
            this.txt_author.Name = "txt_author";
            this.txt_author.ReadOnly = true;
            this.txt_author.Size = new System.Drawing.Size(171, 20);
            this.txt_author.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Duration";
            // 
            // txt_playlist
            // 
            this.txt_playlist.Location = new System.Drawing.Point(12, 309);
            this.txt_playlist.Name = "txt_playlist";
            this.txt_playlist.Size = new System.Drawing.Size(514, 20);
            this.txt_playlist.TabIndex = 8;
            // 
            // btn_playlist
            // 
            this.btn_playlist.Location = new System.Drawing.Point(12, 335);
            this.btn_playlist.Name = "btn_playlist";
            this.btn_playlist.Size = new System.Drawing.Size(127, 23);
            this.btn_playlist.TabIndex = 9;
            this.btn_playlist.Text = "download playlist";
            this.btn_playlist.UseVisualStyleBackColor = true;
            this.btn_playlist.Click += new System.EventHandler(this.btn_playlist_Click);
            // 
            // pnl_status
            // 
            this.pnl_status.Location = new System.Drawing.Point(532, 479);
            this.pnl_status.Name = "pnl_status";
            this.pnl_status.Size = new System.Drawing.Size(706, 100);
            this.pnl_status.TabIndex = 11;
            // 
            // pnl_form
            // 
            this.pnl_form.Location = new System.Drawing.Point(532, 28);
            this.pnl_form.Name = "pnl_form";
            this.pnl_form.Size = new System.Drawing.Size(706, 445);
            this.pnl_form.TabIndex = 12;
            this.pnl_form.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pnl_form_ControlRemoved);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1250, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadToolStripMenuItem,
            this.configurationToolStripMenuItem});
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleVideoToolStripMenuItem,
            this.playlistToolStripMenuItem});
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.downloadToolStripMenuItem.Text = "Download";
            // 
            // singleVideoToolStripMenuItem
            // 
            this.singleVideoToolStripMenuItem.Name = "singleVideoToolStripMenuItem";
            this.singleVideoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.singleVideoToolStripMenuItem.Text = "Single Video";
            this.singleVideoToolStripMenuItem.Click += new System.EventHandler(this.singleVideoToolStripMenuItem_Click);
            // 
            // playlistToolStripMenuItem
            // 
            this.playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            this.playlistToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.playlistToolStripMenuItem.Text = "Playlist";
            this.playlistToolStripMenuItem.Click += new System.EventHandler(this.playlistToolStripMenuItem_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 591);
            this.Controls.Add(this.pnl_form);
            this.Controls.Add(this.pnl_status);
            this.Controls.Add(this.btn_playlist);
            this.Controls.Add(this.txt_playlist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.txt_Duration);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mainform";
            this.Text = "Youtube downloader";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.TextBox txt_Duration;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_playlist;
        private System.Windows.Forms.Button btn_playlist;
        private System.Windows.Forms.Panel pnl_status;
        private System.Windows.Forms.Panel pnl_form;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
    }
}

