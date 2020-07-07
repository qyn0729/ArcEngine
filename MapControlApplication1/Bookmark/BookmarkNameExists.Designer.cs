namespace MapControlApplication1
{
    partial class BookmarkNameExists
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
            this.label2 = new System.Windows.Forms.Label();
            this.btYes = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btNo = new System.Windows.Forms.Button();
            this.lbBookmarkExistedWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(29, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btYes
            // 
            this.btYes.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btYes.Location = new System.Drawing.Point(272, 137);
            this.btYes.Name = "btYes";
            this.btYes.Size = new System.Drawing.Size(91, 34);
            this.btYes.TabIndex = 2;
            this.btYes.Text = "Yes";
            this.btYes.UseVisualStyleBackColor = true;
            this.btYes.Click += new System.EventHandler(this.btYes_Click);
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCancel.Location = new System.Drawing.Point(507, 137);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(91, 34);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btNo
            // 
            this.btNo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btNo.Location = new System.Drawing.Point(390, 137);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(91, 34);
            this.btNo.TabIndex = 2;
            this.btNo.Text = "No";
            this.btNo.UseVisualStyleBackColor = true;
            this.btNo.Click += new System.EventHandler(this.btNo_Click);
            // 
            // lbBookmarkExistedWarning
            // 
            this.lbBookmarkExistedWarning.AutoSize = true;
            this.lbBookmarkExistedWarning.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbBookmarkExistedWarning.Location = new System.Drawing.Point(36, 41);
            this.lbBookmarkExistedWarning.Name = "lbBookmarkExistedWarning";
            this.lbBookmarkExistedWarning.Size = new System.Drawing.Size(63, 24);
            this.lbBookmarkExistedWarning.TabIndex = 3;
            this.lbBookmarkExistedWarning.Text = "label3";
            this.lbBookmarkExistedWarning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BookmarkNameExists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 195);
            this.Controls.Add(this.lbBookmarkExistedWarning);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btYes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookmarkNameExists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btYes;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btNo;
        private System.Windows.Forms.Label lbBookmarkExistedWarning;
    }
}