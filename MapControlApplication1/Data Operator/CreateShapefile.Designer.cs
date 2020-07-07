namespace MapControlApplication1
{
    partial class CreateShapefile
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
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbGeometryType = new System.Windows.Forms.ComboBox();
            this.btnAdmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.listBoxFieldName = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxFieldType = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btAddFiled = new System.Windows.Forms.Button();
            this.listBoxAliasName = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.tbShapefileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Path:";
            // 
            // tbFilePath
            // 
            this.tbFilePath.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.tbFilePath.Location = new System.Drawing.Point(203, 33);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(372, 30);
            this.tbFilePath.TabIndex = 2;
            // 
            // btFile
            // 
            this.btFile.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btFile.Location = new System.Drawing.Point(809, 33);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(99, 35);
            this.btFile.TabIndex = 7;
            this.btFile.Text = "File...";
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(35, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Geometry Type:";
            // 
            // cbGeometryType
            // 
            this.cbGeometryType.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.cbGeometryType.FormattingEnabled = true;
            this.cbGeometryType.Location = new System.Drawing.Point(203, 141);
            this.cbGeometryType.Name = "cbGeometryType";
            this.cbGeometryType.Size = new System.Drawing.Size(192, 31);
            this.cbGeometryType.TabIndex = 8;
            // 
            // btnAdmit
            // 
            this.btnAdmit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdmit.Location = new System.Drawing.Point(692, 393);
            this.btnAdmit.Name = "btnAdmit";
            this.btnAdmit.Size = new System.Drawing.Size(91, 35);
            this.btnAdmit.TabIndex = 9;
            this.btnAdmit.Text = "OK";
            this.btnAdmit.UseVisualStyleBackColor = true;
            this.btnAdmit.Click += new System.EventHandler(this.btnAdmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(817, 393);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 35);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // listBoxFieldName
            // 
            this.listBoxFieldName.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.listBoxFieldName.FormattingEnabled = true;
            this.listBoxFieldName.ItemHeight = 21;
            this.listBoxFieldName.Location = new System.Drawing.Point(202, 236);
            this.listBoxFieldName.Name = "listBoxFieldName";
            this.listBoxFieldName.Size = new System.Drawing.Size(168, 130);
            this.listBoxFieldName.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(35, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Add Field:";
            // 
            // listBoxFieldType
            // 
            this.listBoxFieldType.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.listBoxFieldType.FormattingEnabled = true;
            this.listBoxFieldType.ItemHeight = 21;
            this.listBoxFieldType.Location = new System.Drawing.Point(615, 236);
            this.listBoxFieldType.Name = "listBoxFieldType";
            this.listBoxFieldType.Size = new System.Drawing.Size(168, 130);
            this.listBoxFieldType.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.label5.Location = new System.Drawing.Point(198, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Field Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.label6.Location = new System.Drawing.Point(611, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Field Type:";
            // 
            // btAddFiled
            // 
            this.btAddFiled.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAddFiled.Location = new System.Drawing.Point(809, 201);
            this.btAddFiled.Name = "btAddFiled";
            this.btAddFiled.Size = new System.Drawing.Size(99, 35);
            this.btAddFiled.TabIndex = 15;
            this.btAddFiled.Text = "Add...";
            this.btAddFiled.UseVisualStyleBackColor = true;
            this.btAddFiled.Click += new System.EventHandler(this.btAddFiled_Click);
            // 
            // listBoxAliasName
            // 
            this.listBoxAliasName.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.listBoxAliasName.FormattingEnabled = true;
            this.listBoxAliasName.ItemHeight = 21;
            this.listBoxAliasName.Location = new System.Drawing.Point(407, 236);
            this.listBoxAliasName.Name = "listBoxAliasName";
            this.listBoxAliasName.Size = new System.Drawing.Size(168, 130);
            this.listBoxAliasName.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.label7.Location = new System.Drawing.Point(403, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Alias Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(35, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Shapefile name:";
            // 
            // tbShapefileName
            // 
            this.tbShapefileName.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.tbShapefileName.Location = new System.Drawing.Point(203, 84);
            this.tbShapefileName.Name = "tbShapefileName";
            this.tbShapefileName.Size = new System.Drawing.Size(372, 30);
            this.tbShapefileName.TabIndex = 11;
            this.tbShapefileName.Text = "New Shapefile";
            // 
            // CreateShapefile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 440);
            this.Controls.Add(this.btAddFiled);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxFieldType);
            this.Controls.Add(this.listBoxAliasName);
            this.Controls.Add(this.listBoxFieldName);
            this.Controls.Add(this.tbShapefileName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdmit);
            this.Controls.Add(this.cbGeometryType);
            this.Controls.Add(this.btFile);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateShapefile";
            this.Text = "CreateShapefile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button btFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbGeometryType;
        private System.Windows.Forms.Button btnAdmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox listBoxFieldName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxFieldType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btAddFiled;
        private System.Windows.Forms.ListBox listBoxAliasName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbShapefileName;
    }
}