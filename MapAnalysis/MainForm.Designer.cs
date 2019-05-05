namespace MapAnalysis
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BMPview = new System.Windows.Forms.PictureBox();
            this.ImportBtn = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.BMPpath = new System.Windows.Forms.TextBox();
            this.debugbox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BMPview)).BeginInit();
            this.SuspendLayout();
            // 
            // BMPview
            // 
            this.BMPview.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BMPview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BMPview.Location = new System.Drawing.Point(13, 57);
            this.BMPview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BMPview.Name = "BMPview";
            this.BMPview.Size = new System.Drawing.Size(748, 841);
            this.BMPview.TabIndex = 0;
            this.BMPview.TabStop = false;
            // 
            // ImportBtn
            // 
            this.ImportBtn.Location = new System.Drawing.Point(769, 14);
            this.ImportBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ImportBtn.Name = "ImportBtn";
            this.ImportBtn.Size = new System.Drawing.Size(104, 33);
            this.ImportBtn.TabIndex = 1;
            this.ImportBtn.Text = "导入";
            this.ImportBtn.UseVisualStyleBackColor = true;
            this.ImportBtn.Click += new System.EventHandler(this.ImportBtn_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // BMPpath
            // 
            this.BMPpath.Location = new System.Drawing.Point(13, 14);
            this.BMPpath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BMPpath.Name = "BMPpath";
            this.BMPpath.Size = new System.Drawing.Size(748, 33);
            this.BMPpath.TabIndex = 2;
            // 
            // debugbox
            // 
            this.debugbox.Location = new System.Drawing.Point(769, 57);
            this.debugbox.Name = "debugbox";
            this.debugbox.Size = new System.Drawing.Size(218, 841);
            this.debugbox.TabIndex = 4;
            this.debugbox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(880, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ComputeBtn);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 935);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.debugbox);
            this.Controls.Add(this.BMPpath);
            this.Controls.Add(this.ImportBtn);
            this.Controls.Add(this.BMPview);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MapAnalysis";
            ((System.ComponentModel.ISupportInitialize)(this.BMPview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BMPview;
        private System.Windows.Forms.Button ImportBtn;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.TextBox BMPpath;
        private System.Windows.Forms.RichTextBox debugbox;
        private System.Windows.Forms.Button button1;
    }
}

