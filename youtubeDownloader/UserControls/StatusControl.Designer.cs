namespace youtubeDownloader.UserControls
{
    partial class StatusControl
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
            this.bar_download = new System.Windows.Forms.ProgressBar();
            this.lbl_statusControl_remain = new System.Windows.Forms.Label();
            this.lbl_statusControl_complete = new System.Windows.Forms.Label();
            this.lbl_statusControl_thread = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bar_download
            // 
            this.bar_download.Location = new System.Drawing.Point(3, 64);
            this.bar_download.Name = "bar_download";
            this.bar_download.Size = new System.Drawing.Size(534, 23);
            this.bar_download.TabIndex = 11;
            // 
            // lbl_statusControl_remain
            // 
            this.lbl_statusControl_remain.AutoSize = true;
            this.lbl_statusControl_remain.Location = new System.Drawing.Point(17, 30);
            this.lbl_statusControl_remain.Name = "lbl_statusControl_remain";
            this.lbl_statusControl_remain.Size = new System.Drawing.Size(0, 13);
            this.lbl_statusControl_remain.TabIndex = 12;
            // 
            // lbl_statusControl_complete
            // 
            this.lbl_statusControl_complete.AutoSize = true;
            this.lbl_statusControl_complete.Location = new System.Drawing.Point(17, 46);
            this.lbl_statusControl_complete.Name = "lbl_statusControl_complete";
            this.lbl_statusControl_complete.Size = new System.Drawing.Size(0, 13);
            this.lbl_statusControl_complete.TabIndex = 13;
            // 
            // lbl_statusControl_thread
            // 
            this.lbl_statusControl_thread.AutoSize = true;
            this.lbl_statusControl_thread.Location = new System.Drawing.Point(17, 12);
            this.lbl_statusControl_thread.Name = "lbl_statusControl_thread";
            this.lbl_statusControl_thread.Size = new System.Drawing.Size(0, 13);
            this.lbl_statusControl_thread.TabIndex = 14;
            // 
            // StatusControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_statusControl_thread);
            this.Controls.Add(this.lbl_statusControl_complete);
            this.Controls.Add(this.lbl_statusControl_remain);
            this.Controls.Add(this.bar_download);
            this.Name = "StatusControl";
            this.Size = new System.Drawing.Size(540, 100);
            this.Load += new System.EventHandler(this.StatusControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_statusControl_remain;
        private System.Windows.Forms.Label lbl_statusControl_complete;
        public System.Windows.Forms.ProgressBar bar_download;
        private System.Windows.Forms.Label lbl_statusControl_thread;
    }
}
