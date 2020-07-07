namespace MapControlApplication1.Data_Operator
{
    partial class SelectLayer
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
            this.cbLayerName = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(33, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please select a layer:";
            // 
            // cbLayerName
            // 
            this.cbLayerName.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.cbLayerName.FormattingEnabled = true;
            this.cbLayerName.Location = new System.Drawing.Point(238, 47);
            this.cbLayerName.Name = "cbLayerName";
            this.cbLayerName.Size = new System.Drawing.Size(256, 31);
            this.cbLayerName.TabIndex = 3;
            this.cbLayerName.SelectedIndexChanged += new System.EventHandler(this.cbLayerName_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(477, 112);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 35);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdmit
            // 
            this.btnAdmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdmit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdmit.Location = new System.Drawing.Point(352, 112);
            this.btnAdmit.Name = "btnAdmit";
            this.btnAdmit.Size = new System.Drawing.Size(91, 35);
            this.btnAdmit.TabIndex = 11;
            this.btnAdmit.Text = "OK";
            this.btnAdmit.UseVisualStyleBackColor = true;
            this.btnAdmit.Click += new System.EventHandler(this.btnAdmit_Click);
            // 
            // SelectLayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 172);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdmit);
            this.Controls.Add(this.cbLayerName);
            this.Controls.Add(this.label1);
            this.Name = "SelectLayer";
            this.Text = "Select Layer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLayerName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdmit;
    }
}