namespace MapControlApplication1
{
    partial class DataBoard
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDataNameList = new System.Windows.Forms.ComboBox();
            this.btnSelectFields = new System.Windows.Forms.Button();
            this.btStatistics = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(12, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(748, 336);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please select a layer:";
            // 
            // cbDataNameList
            // 
            this.cbDataNameList.FormattingEnabled = true;
            this.cbDataNameList.Location = new System.Drawing.Point(225, 29);
            this.cbDataNameList.Name = "cbDataNameList";
            this.cbDataNameList.Size = new System.Drawing.Size(190, 26);
            this.cbDataNameList.TabIndex = 3;
            this.cbDataNameList.SelectedIndexChanged += new System.EventHandler(this.cbDataNameList_SelectedIndexChanged);
            // 
            // btnSelectFields
            // 
            this.btnSelectFields.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectFields.Location = new System.Drawing.Point(448, 22);
            this.btnSelectFields.Name = "btnSelectFields";
            this.btnSelectFields.Size = new System.Drawing.Size(159, 37);
            this.btnSelectFields.TabIndex = 4;
            this.btnSelectFields.Text = "Select Fields";
            this.btnSelectFields.UseVisualStyleBackColor = true;
            this.btnSelectFields.Click += new System.EventHandler(this.btnSelectFields_Click);
            // 
            // btStatistics
            // 
            this.btStatistics.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btStatistics.Location = new System.Drawing.Point(631, 22);
            this.btStatistics.Name = "btStatistics";
            this.btStatistics.Size = new System.Drawing.Size(129, 37);
            this.btStatistics.TabIndex = 16;
            this.btStatistics.Text = "Statistics";
            this.btStatistics.UseVisualStyleBackColor = true;
            this.btStatistics.Click += new System.EventHandler(this.btStatistics_Click);
            // 
            // DataBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 429);
            this.Controls.Add(this.btStatistics);
            this.Controls.Add(this.btnSelectFields);
            this.Controls.Add(this.cbDataNameList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Board";
            this.SizeChanged += new System.EventHandler(this.DataBoard_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDataNameList;
        private System.Windows.Forms.Button btnSelectFields;
        private System.Windows.Forms.Button btStatistics;
    }
}