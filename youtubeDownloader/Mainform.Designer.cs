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
            // pnl_form
            // 
            this.pnl_form.Location = new System.Drawing.Point(12, 28);
            this.pnl_form.Name = "pnl_form";
            this.pnl_form.Size = new System.Drawing.Size(540, 445);
            this.pnl_form.TabIndex = 12;
            this.pnl_form.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pnl_form_ControlRemoved);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 24);
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
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
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
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 476);
            this.Controls.Add(this.pnl_form);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mainform";
            this.Text = "Youtube downloader";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_form;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
    }
}

