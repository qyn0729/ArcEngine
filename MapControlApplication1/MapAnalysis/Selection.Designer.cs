namespace MapControlApplication1
{
    partial class SelectionByAttributes
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
            this.lbxFields = new System.Windows.Forms.ListBox();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnGreater = new System.Windows.Forms.Button();
            this.btnLess = new System.Windows.Forms.Button();
            this.btnGreaterLess = new System.Windows.Forms.Button();
            this.btnGreaterEqual = new System.Windows.Forms.Button();
            this.btnLessEqual = new System.Windows.Forms.Button();
            this.btnGetUniqueValues = new System.Windows.Forms.Button();
            this.lbxUniqueValues = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLayerName = new System.Windows.Forms.Label();
            this.tbQuery = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnSelectSpatialFilter = new System.Windows.Forms.Button();
            this.cbMethod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(24, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please select a layer:";
            // 
            // cbLayerName
            // 
            this.cbLayerName.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.cbLayerName.FormattingEnabled = true;
            this.cbLayerName.Location = new System.Drawing.Point(226, 77);
            this.cbLayerName.Name = "cbLayerName";
            this.cbLayerName.Size = new System.Drawing.Size(256, 31);
            this.cbLayerName.TabIndex = 4;
            this.cbLayerName.SelectedIndexChanged += new System.EventHandler(this.cbLayerName_SelectedIndexChanged);
            // 
            // lbxFields
            // 
            this.lbxFields.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.lbxFields.FormattingEnabled = true;
            this.lbxFields.ItemHeight = 23;
            this.lbxFields.Location = new System.Drawing.Point(28, 127);
            this.lbxFields.Name = "lbxFields";
            this.lbxFields.Size = new System.Drawing.Size(454, 119);
            this.lbxFields.TabIndex = 5;
            this.lbxFields.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxFields_MouseDoubleClick);
            // 
            // btnEqual
            // 
            this.btnEqual.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEqual.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEqual.Location = new System.Drawing.Point(26, 275);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(38, 35);
            this.btnEqual.TabIndex = 12;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnGreater
            // 
            this.btnGreater.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGreater.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGreater.Location = new System.Drawing.Point(26, 340);
            this.btnGreater.Name = "btnGreater";
            this.btnGreater.Size = new System.Drawing.Size(38, 35);
            this.btnGreater.TabIndex = 12;
            this.btnGreater.Text = ">";
            this.btnGreater.UseVisualStyleBackColor = true;
            this.btnGreater.Click += new System.EventHandler(this.btnGreater_Click);
            // 
            // btnLess
            // 
            this.btnLess.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLess.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLess.Location = new System.Drawing.Point(26, 403);
            this.btnLess.Name = "btnLess";
            this.btnLess.Size = new System.Drawing.Size(38, 35);
            this.btnLess.TabIndex = 12;
            this.btnLess.Text = "<";
            this.btnLess.UseVisualStyleBackColor = true;
            this.btnLess.Click += new System.EventHandler(this.btnLess_Click);
            // 
            // btnGreaterLess
            // 
            this.btnGreaterLess.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGreaterLess.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGreaterLess.Location = new System.Drawing.Point(70, 275);
            this.btnGreaterLess.Name = "btnGreaterLess";
            this.btnGreaterLess.Size = new System.Drawing.Size(56, 35);
            this.btnGreaterLess.TabIndex = 12;
            this.btnGreaterLess.Text = "<>";
            this.btnGreaterLess.UseVisualStyleBackColor = true;
            this.btnGreaterLess.Click += new System.EventHandler(this.btnGreaterLess_Click);
            // 
            // btnGreaterEqual
            // 
            this.btnGreaterEqual.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGreaterEqual.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGreaterEqual.Location = new System.Drawing.Point(70, 340);
            this.btnGreaterEqual.Name = "btnGreaterEqual";
            this.btnGreaterEqual.Size = new System.Drawing.Size(56, 35);
            this.btnGreaterEqual.TabIndex = 12;
            this.btnGreaterEqual.Text = ">=";
            this.btnGreaterEqual.UseVisualStyleBackColor = true;
            this.btnGreaterEqual.Click += new System.EventHandler(this.btnGreaterEqual_Click);
            // 
            // btnLessEqual
            // 
            this.btnLessEqual.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLessEqual.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLessEqual.Location = new System.Drawing.Point(70, 403);
            this.btnLessEqual.Name = "btnLessEqual";
            this.btnLessEqual.Size = new System.Drawing.Size(56, 35);
            this.btnLessEqual.TabIndex = 12;
            this.btnLessEqual.Text = "<=";
            this.btnLessEqual.UseVisualStyleBackColor = true;
            this.btnLessEqual.Click += new System.EventHandler(this.btnLessEqual_Click);
            // 
            // btnGetUniqueValues
            // 
            this.btnGetUniqueValues.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGetUniqueValues.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGetUniqueValues.Location = new System.Drawing.Point(274, 463);
            this.btnGetUniqueValues.Name = "btnGetUniqueValues";
            this.btnGetUniqueValues.Size = new System.Drawing.Size(210, 35);
            this.btnGetUniqueValues.TabIndex = 12;
            this.btnGetUniqueValues.Text = "Get Unique Values";
            this.btnGetUniqueValues.UseVisualStyleBackColor = true;
            this.btnGetUniqueValues.Click += new System.EventHandler(this.btnGetUniqueValues_Click);
            // 
            // lbxUniqueValues
            // 
            this.lbxUniqueValues.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.lbxUniqueValues.FormattingEnabled = true;
            this.lbxUniqueValues.ItemHeight = 23;
            this.lbxUniqueValues.Location = new System.Drawing.Point(170, 276);
            this.lbxUniqueValues.Name = "lbxUniqueValues";
            this.lbxUniqueValues.Size = new System.Drawing.Size(312, 165);
            this.lbxUniqueValues.TabIndex = 13;
            this.lbxUniqueValues.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxUniqueValues_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(24, 519);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "SELECT * FROM ";
            // 
            // lbLayerName
            // 
            this.lbLayerName.AutoSize = true;
            this.lbLayerName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbLayerName.Location = new System.Drawing.Point(179, 519);
            this.lbLayerName.Name = "lbLayerName";
            this.lbLayerName.Size = new System.Drawing.Size(15, 24);
            this.lbLayerName.TabIndex = 3;
            this.lbLayerName.Text = " ";
            // 
            // tbQuery
            // 
            this.tbQuery.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.tbQuery.Location = new System.Drawing.Point(26, 558);
            this.tbQuery.Name = "tbQuery";
            this.tbQuery.Size = new System.Drawing.Size(456, 30);
            this.tbQuery.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(391, 630);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 35);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(266, 630);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(91, 35);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnSelectSpatialFilter
            // 
            this.btnSelectSpatialFilter.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectSpatialFilter.Location = new System.Drawing.Point(26, 463);
            this.btnSelectSpatialFilter.Name = "btnSelectSpatialFilter";
            this.btnSelectSpatialFilter.Size = new System.Drawing.Size(222, 35);
            this.btnSelectSpatialFilter.TabIndex = 17;
            this.btnSelectSpatialFilter.Text = "Select Spatial Filter";
            this.btnSelectSpatialFilter.UseVisualStyleBackColor = true;
            this.btnSelectSpatialFilter.Click += new System.EventHandler(this.btnSelectSpatialFilter_Click);
            // 
            // cbMethod
            // 
            this.cbMethod.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.cbMethod.FormattingEnabled = true;
            this.cbMethod.Location = new System.Drawing.Point(164, 22);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(318, 31);
            this.cbMethod.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(24, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Method:";
            // 
            // SelectionByAttributes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 683);
            this.Controls.Add(this.cbMethod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSelectSpatialFilter);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbQuery);
            this.Controls.Add(this.lbxUniqueValues);
            this.Controls.Add(this.btnLess);
            this.Controls.Add(this.btnGreater);
            this.Controls.Add(this.btnGetUniqueValues);
            this.Controls.Add(this.btnLessEqual);
            this.Controls.Add(this.btnGreaterEqual);
            this.Controls.Add(this.btnGreaterLess);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.lbxFields);
            this.Controls.Add(this.cbLayerName);
            this.Controls.Add(this.lbLayerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SelectionByAttributes";
            this.Text = "SelectionByAttributes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLayerName;
        private System.Windows.Forms.ListBox lbxFields;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnGreater;
        private System.Windows.Forms.Button btnLess;
        private System.Windows.Forms.Button btnGreaterLess;
        private System.Windows.Forms.Button btnGreaterEqual;
        private System.Windows.Forms.Button btnLessEqual;
        private System.Windows.Forms.Button btnGetUniqueValues;
        private System.Windows.Forms.ListBox lbxUniqueValues;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbLayerName;
        private System.Windows.Forms.TextBox tbQuery;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnSelectSpatialFilter;
        private System.Windows.Forms.ComboBox cbMethod;
        private System.Windows.Forms.Label label3;
    }
}