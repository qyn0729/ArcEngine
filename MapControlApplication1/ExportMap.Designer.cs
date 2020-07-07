namespace MapControlApplication1
{
    partial class ExportMap
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nmudResolution = new System.Windows.Forms.NumericUpDown();
            this.btFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.btCancel = new System.Windows.Forms.Button();
            this.btExport = new System.Windows.Forms.Button();
            this.cbWorldFile = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmudResolution)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name:";
            // 
            // tbFileName
            // 
            this.tbFileName.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.tbFileName.Location = new System.Drawing.Point(159, 24);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(256, 30);
            this.tbFileName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(32, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resolution:";
            // 
            // nmudResolution
            // 
            this.nmudResolution.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.nmudResolution.Location = new System.Drawing.Point(159, 74);
            this.nmudResolution.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmudResolution.Name = "nmudResolution";
            this.nmudResolution.Size = new System.Drawing.Size(112, 30);
            this.nmudResolution.TabIndex = 5;
            this.nmudResolution.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // btFile
            // 
            this.btFile.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btFile.Location = new System.Drawing.Point(443, 19);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(99, 35);
            this.btFile.TabIndex = 6;
            this.btFile.Text = "File...";
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.label2.Location = new System.Drawing.Point(286, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "dpi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(32, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Width:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(32, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Height:";
            // 
            // tbWidth
            // 
            this.tbWidth.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.tbWidth.Location = new System.Drawing.Point(159, 125);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(112, 30);
            this.tbWidth.TabIndex = 8;
            this.tbWidth.Text = "776";
            // 
            // tbHeight
            // 
            this.tbHeight.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.tbHeight.Location = new System.Drawing.Point(159, 176);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(112, 30);
            this.tbHeight.TabIndex = 8;
            this.tbHeight.Text = "537";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.label6.Location = new System.Drawing.Point(286, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "pixel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.label7.Location = new System.Drawing.Point(286, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "pixel";
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCancel.Location = new System.Drawing.Point(423, 291);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(119, 35);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btExport
            // 
            this.btExport.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExport.Location = new System.Drawing.Point(276, 291);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(119, 35);
            this.btExport.TabIndex = 9;
            this.btExport.Text = "Export";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // cbWorldFile
            // 
            this.cbWorldFile.AutoSize = true;
            this.cbWorldFile.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.cbWorldFile.Location = new System.Drawing.Point(36, 229);
            this.cbWorldFile.Name = "cbWorldFile";
            this.cbWorldFile.Size = new System.Drawing.Size(169, 27);
            this.cbWorldFile.TabIndex = 10;
            this.cbWorldFile.Text = "Write World File";
            this.cbWorldFile.UseVisualStyleBackColor = true;
            // 
            // ExportMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 338);
            this.Controls.Add(this.cbWorldFile);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btFile);
            this.Controls.Add(this.nmudResolution);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.label1);
            this.Name = "ExportMap";
            this.Text = "Export Map";
            ((System.ComponentModel.ISupportInitialize)(this.nmudResolution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmudResolution;
        private System.Windows.Forms.Button btFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.CheckBox cbWorldFile;
    }
}