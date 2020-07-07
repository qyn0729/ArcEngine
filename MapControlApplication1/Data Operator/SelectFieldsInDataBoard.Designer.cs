namespace MapControlApplication1.Data_Operator
{
    partial class SelectFieldsInDataBoard
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
            this.lbxAllFields = new System.Windows.Forms.ListBox();
            this.lbxSelectedFields = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelectAllFields = new System.Windows.Forms.Button();
            this.btnSelectOneField = new System.Windows.Forms.Button();
            this.btnCancelSelectOneField = new System.Windows.Forms.Button();
            this.btnCancelSelectAllFields = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxAllFields
            // 
            this.lbxAllFields.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.lbxAllFields.FormattingEnabled = true;
            this.lbxAllFields.ItemHeight = 23;
            this.lbxAllFields.Location = new System.Drawing.Point(12, 74);
            this.lbxAllFields.Name = "lbxAllFields";
            this.lbxAllFields.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxAllFields.Size = new System.Drawing.Size(249, 280);
            this.lbxAllFields.TabIndex = 0;
            // 
            // lbxSelectedFields
            // 
            this.lbxSelectedFields.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.lbxSelectedFields.FormattingEnabled = true;
            this.lbxSelectedFields.ItemHeight = 23;
            this.lbxSelectedFields.Location = new System.Drawing.Point(355, 74);
            this.lbxSelectedFields.Name = "lbxSelectedFields";
            this.lbxSelectedFields.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxSelectedFields.Size = new System.Drawing.Size(249, 280);
            this.lbxSelectedFields.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Fields:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(351, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selected Fields:";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(400, 401);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(93, 37);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(511, 401);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 37);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSelectAllFields
            // 
            this.btnSelectAllFields.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectAllFields.Location = new System.Drawing.Point(277, 127);
            this.btnSelectAllFields.Name = "btnSelectAllFields";
            this.btnSelectAllFields.Size = new System.Drawing.Size(65, 37);
            this.btnSelectAllFields.TabIndex = 6;
            this.btnSelectAllFields.Text = ">>";
            this.btnSelectAllFields.UseVisualStyleBackColor = true;
            this.btnSelectAllFields.Click += new System.EventHandler(this.btnSelectAllFields_Click);
            // 
            // btnSelectOneField
            // 
            this.btnSelectOneField.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectOneField.Location = new System.Drawing.Point(277, 170);
            this.btnSelectOneField.Name = "btnSelectOneField";
            this.btnSelectOneField.Size = new System.Drawing.Size(65, 37);
            this.btnSelectOneField.TabIndex = 6;
            this.btnSelectOneField.Text = ">";
            this.btnSelectOneField.UseVisualStyleBackColor = true;
            this.btnSelectOneField.Click += new System.EventHandler(this.btnSelectOneField_Click);
            // 
            // btnCancelSelectOneField
            // 
            this.btnCancelSelectOneField.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancelSelectOneField.Location = new System.Drawing.Point(277, 213);
            this.btnCancelSelectOneField.Name = "btnCancelSelectOneField";
            this.btnCancelSelectOneField.Size = new System.Drawing.Size(65, 37);
            this.btnCancelSelectOneField.TabIndex = 6;
            this.btnCancelSelectOneField.Text = "<";
            this.btnCancelSelectOneField.UseVisualStyleBackColor = true;
            this.btnCancelSelectOneField.Click += new System.EventHandler(this.btnCancelSelectOneField_Click);
            // 
            // btnCancelSelectAllFields
            // 
            this.btnCancelSelectAllFields.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancelSelectAllFields.Location = new System.Drawing.Point(277, 256);
            this.btnCancelSelectAllFields.Name = "btnCancelSelectAllFields";
            this.btnCancelSelectAllFields.Size = new System.Drawing.Size(65, 37);
            this.btnCancelSelectAllFields.TabIndex = 6;
            this.btnCancelSelectAllFields.Text = "<<";
            this.btnCancelSelectAllFields.UseVisualStyleBackColor = true;
            this.btnCancelSelectAllFields.Click += new System.EventHandler(this.btnCancelSelectAllFields_Click);
            // 
            // SelectFieldsInDataBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.btnCancelSelectAllFields);
            this.Controls.Add(this.btnCancelSelectOneField);
            this.Controls.Add(this.btnSelectOneField);
            this.Controls.Add(this.btnSelectAllFields);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxSelectedFields);
            this.Controls.Add(this.lbxAllFields);
            this.Name = "SelectFieldsInDataBoard";
            this.Text = "SelectFieldsInDataBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxAllFields;
        private System.Windows.Forms.ListBox lbxSelectedFields;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelectAllFields;
        private System.Windows.Forms.Button btnSelectOneField;
        private System.Windows.Forms.Button btnCancelSelectOneField;
        private System.Windows.Forms.Button btnCancelSelectAllFields;
    }
}