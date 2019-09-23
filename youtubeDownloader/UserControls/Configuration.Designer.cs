namespace youtubeDownloader.UserControls
{
    partial class Configuration
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
            this.txt_selechted_path = new System.Windows.Forms.TextBox();
            this.btn_savePath = new System.Windows.Forms.Button();
            this.btn_pickpath = new System.Windows.Forms.Button();
            this.lbl_path = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_selechted_path
            // 
            this.txt_selechted_path.Location = new System.Drawing.Point(25, 72);
            this.txt_selechted_path.Name = "txt_selechted_path";
            this.txt_selechted_path.Size = new System.Drawing.Size(477, 20);
            this.txt_selechted_path.TabIndex = 0;
            // 
            // btn_savePath
            // 
            this.btn_savePath.Location = new System.Drawing.Point(25, 98);
            this.btn_savePath.Name = "btn_savePath";
            this.btn_savePath.Size = new System.Drawing.Size(75, 23);
            this.btn_savePath.TabIndex = 1;
            this.btn_savePath.Text = "Save";
            this.btn_savePath.UseVisualStyleBackColor = true;
            this.btn_savePath.Click += new System.EventHandler(this.btn_savePath_Click);
            // 
            // btn_pickpath
            // 
            this.btn_pickpath.Location = new System.Drawing.Point(508, 70);
            this.btn_pickpath.Name = "btn_pickpath";
            this.btn_pickpath.Size = new System.Drawing.Size(113, 23);
            this.btn_pickpath.TabIndex = 2;
            this.btn_pickpath.Text = "Select";
            this.btn_pickpath.UseVisualStyleBackColor = true;
            this.btn_pickpath.Click += new System.EventHandler(this.btn_pickpath_Click);
            // 
            // lbl_path
            // 
            this.lbl_path.AutoSize = true;
            this.lbl_path.Location = new System.Drawing.Point(25, 53);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(131, 13);
            this.lbl_path.TabIndex = 3;
            this.lbl_path.Text = "path for saving downloads";
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_path);
            this.Controls.Add(this.btn_pickpath);
            this.Controls.Add(this.btn_savePath);
            this.Controls.Add(this.txt_selechted_path);
            this.Name = "Configuration";
            this.Size = new System.Drawing.Size(706, 445);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_selechted_path;
        private System.Windows.Forms.Button btn_savePath;
        private System.Windows.Forms.Button btn_pickpath;
        private System.Windows.Forms.Label lbl_path;
    }
}
