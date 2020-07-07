namespace MapControlApplication1
{
    partial class AddField
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
            this.tbFieldName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFieldType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAliasName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFieldName
            // 
            this.tbFieldName.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.tbFieldName.Location = new System.Drawing.Point(151, 28);
            this.tbFieldName.Name = "tbFieldName";
            this.tbFieldName.Size = new System.Drawing.Size(240, 30);
            this.tbFieldName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label6.Location = new System.Drawing.Point(23, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Field Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label5.Location = new System.Drawing.Point(23, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Field Name:";
            // 
            // cbFieldType
            // 
            this.cbFieldType.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.cbFieldType.FormattingEnabled = true;
            this.cbFieldType.Location = new System.Drawing.Point(151, 175);
            this.cbFieldType.Name = "cbFieldType";
            this.cbFieldType.Size = new System.Drawing.Size(240, 31);
            this.cbFieldType.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label1.Location = new System.Drawing.Point(23, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alias Name:";
            // 
            // tbAliasName
            // 
            this.tbAliasName.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.tbAliasName.Location = new System.Drawing.Point(151, 98);
            this.tbAliasName.Name = "tbAliasName";
            this.tbAliasName.Size = new System.Drawing.Size(240, 30);
            this.tbAliasName.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(338, 238);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 35);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdmit
            // 
            this.btnAdmit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdmit.Location = new System.Drawing.Point(213, 238);
            this.btnAdmit.Name = "btnAdmit";
            this.btnAdmit.Size = new System.Drawing.Size(91, 35);
            this.btnAdmit.TabIndex = 11;
            this.btnAdmit.Text = "OK";
            this.btnAdmit.UseVisualStyleBackColor = true;
            this.btnAdmit.Click += new System.EventHandler(this.btnAdmit_Click);
            // 
            // AddField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 298);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdmit);
            this.Controls.Add(this.cbFieldType);
            this.Controls.Add(this.tbAliasName);
            this.Controls.Add(this.tbFieldName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "AddField";
            this.Text = "AddField";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFieldName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbFieldType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAliasName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdmit;
    }
}