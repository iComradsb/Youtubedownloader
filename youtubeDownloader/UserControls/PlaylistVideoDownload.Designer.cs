namespace youtubeDownloader.UserControls
{
    partial class PlaylistVideoDownload
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
            this.btn_playlist = new System.Windows.Forms.Button();
            this.txt_playlist = new System.Windows.Forms.TextBox();
            this.pnl_status = new System.Windows.Forms.Panel();
            this.lbl_invoke = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_playlist
            // 
            this.btn_playlist.Location = new System.Drawing.Point(13, 224);
            this.btn_playlist.Name = "btn_playlist";
            this.btn_playlist.Size = new System.Drawing.Size(127, 23);
            this.btn_playlist.TabIndex = 11;
            this.btn_playlist.Text = "download playlist";
            this.btn_playlist.UseVisualStyleBackColor = true;
            this.btn_playlist.Click += new System.EventHandler(this.btn_playlist_Click);
            // 
            // txt_playlist
            // 
            this.txt_playlist.Location = new System.Drawing.Point(13, 198);
            this.txt_playlist.Name = "txt_playlist";
            this.txt_playlist.Size = new System.Drawing.Size(514, 20);
            this.txt_playlist.TabIndex = 10;
            // 
            // pnl_status
            // 
            this.pnl_status.Location = new System.Drawing.Point(0, 345);
            this.pnl_status.Name = "pnl_status";
            this.pnl_status.Size = new System.Drawing.Size(540, 100);
            this.pnl_status.TabIndex = 12;
            // 
            // lbl_invoke
            // 
            this.lbl_invoke.AutoSize = true;
            this.lbl_invoke.Location = new System.Drawing.Point(10, 318);
            this.lbl_invoke.Name = "lbl_invoke";
            this.lbl_invoke.Size = new System.Drawing.Size(0, 13);
            this.lbl_invoke.TabIndex = 15;
            // 
            // PlaylistVideoDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_invoke);
            this.Controls.Add(this.pnl_status);
            this.Controls.Add(this.btn_playlist);
            this.Controls.Add(this.txt_playlist);
            this.Name = "PlaylistVideoDownload";
            this.Size = new System.Drawing.Size(540, 445);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_playlist;
        private System.Windows.Forms.TextBox txt_playlist;
        private System.Windows.Forms.Panel pnl_status;
        private System.Windows.Forms.Label lbl_invoke;
    }
}
