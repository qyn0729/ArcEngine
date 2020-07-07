namespace MapControlApplication1
{
    partial class MainForm
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
            //Ensures that any ESRI libraries that have been used are unloaded in the correct order. 
            //Failure to do this may result in random crashes on exit due to the operating system unloading 
            //the libraries in the incorrect order. 
            ESRI.ArcGIS.ADF.COMSupport.AOUninitialize.Shutdown();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.miExportMap = new System.Windows.Forms.ToolStripMenuItem();
            this.miPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuExitApp = new System.Windows.Forms.ToolStripMenuItem();
            this.miCreateBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.cbBookmarkList = new System.Windows.Forms.ToolStripComboBox();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miDataView = new System.Windows.Forms.ToolStripMenuItem();
            this.miLayoutView = new System.Windows.Forms.ToolStripMenuItem();
            this.miData = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewLayerData = new System.Windows.Forms.ToolStripMenuItem();
            this.miCreateShapefile = new System.Windows.Forms.ToolStripMenuItem();
            this.miEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miStartEditing = new System.Windows.Forms.ToolStripMenuItem();
            this.miStopEditing = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miSpatialFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.miClearSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBarXY = new System.Windows.Forms.ToolStripStatusLabel();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.axPageLayoutControl1 = new AxESRI.ArcGIS.Controls.AxPageLayoutControl();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axPageLayoutControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.miCreateBookmark,
            this.cbBookmarkList,
            this.viewToolStripMenuItem,
            this.miData,
            this.miEdit,
            this.selectionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1288, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewDoc,
            this.menuOpenDoc,
            this.menuSaveDoc,
            this.menuSaveAs,
            this.miExportMap,
            this.miPrint,
            this.menuSeparator,
            this.menuExitApp});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(52, 32);
            this.menuFile.Text = "File";
            // 
            // menuNewDoc
            // 
            this.menuNewDoc.Image = ((System.Drawing.Image)(resources.GetObject("menuNewDoc.Image")));
            this.menuNewDoc.ImageTransparentColor = System.Drawing.Color.White;
            this.menuNewDoc.Name = "menuNewDoc";
            this.menuNewDoc.Size = new System.Drawing.Size(247, 30);
            this.menuNewDoc.Text = "New Document";
            this.menuNewDoc.Click += new System.EventHandler(this.menuNewDoc_Click);
            // 
            // menuOpenDoc
            // 
            this.menuOpenDoc.Image = ((System.Drawing.Image)(resources.GetObject("menuOpenDoc.Image")));
            this.menuOpenDoc.ImageTransparentColor = System.Drawing.Color.White;
            this.menuOpenDoc.Name = "menuOpenDoc";
            this.menuOpenDoc.Size = new System.Drawing.Size(247, 30);
            this.menuOpenDoc.Text = "Open Document...";
            this.menuOpenDoc.Click += new System.EventHandler(this.menuOpenDoc_Click);
            // 
            // menuSaveDoc
            // 
            this.menuSaveDoc.Image = ((System.Drawing.Image)(resources.GetObject("menuSaveDoc.Image")));
            this.menuSaveDoc.ImageTransparentColor = System.Drawing.Color.White;
            this.menuSaveDoc.Name = "menuSaveDoc";
            this.menuSaveDoc.Size = new System.Drawing.Size(247, 30);
            this.menuSaveDoc.Text = "SaveDocument";
            this.menuSaveDoc.Click += new System.EventHandler(this.menuSaveDoc_Click);
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.Name = "menuSaveAs";
            this.menuSaveAs.Size = new System.Drawing.Size(247, 30);
            this.menuSaveAs.Text = "Save As...";
            this.menuSaveAs.Click += new System.EventHandler(this.menuSaveAs_Click);
            // 
            // miExportMap
            // 
            this.miExportMap.Name = "miExportMap";
            this.miExportMap.Size = new System.Drawing.Size(247, 30);
            this.miExportMap.Text = "Export Map...";
            this.miExportMap.Click += new System.EventHandler(this.miExportMap_Click);
            // 
            // miPrint
            // 
            this.miPrint.Name = "miPrint";
            this.miPrint.Size = new System.Drawing.Size(247, 30);
            this.miPrint.Text = "Print...";
            this.miPrint.Click += new System.EventHandler(this.miPrint_Click);
            // 
            // menuSeparator
            // 
            this.menuSeparator.Name = "menuSeparator";
            this.menuSeparator.Size = new System.Drawing.Size(244, 6);
            // 
            // menuExitApp
            // 
            this.menuExitApp.Name = "menuExitApp";
            this.menuExitApp.Size = new System.Drawing.Size(247, 30);
            this.menuExitApp.Text = "Exit";
            this.menuExitApp.Click += new System.EventHandler(this.menuExitApp_Click);
            // 
            // miCreateBookmark
            // 
            this.miCreateBookmark.Name = "miCreateBookmark";
            this.miCreateBookmark.Size = new System.Drawing.Size(170, 32);
            this.miCreateBookmark.Text = "Create Bookmark";
            this.miCreateBookmark.Click += new System.EventHandler(this.miCreateBookmark_Click);
            // 
            // cbBookmarkList
            // 
            this.cbBookmarkList.Name = "cbBookmarkList";
            this.cbBookmarkList.Size = new System.Drawing.Size(185, 32);
            this.cbBookmarkList.SelectedIndexChanged += new System.EventHandler(this.cbBookmarkList_SelectedIndexChanged);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDataView,
            this.miLayoutView});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(63, 32);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // miDataView
            // 
            this.miDataView.Checked = true;
            this.miDataView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miDataView.Name = "miDataView";
            this.miDataView.Size = new System.Drawing.Size(252, 30);
            this.miDataView.Text = "Data View";
            this.miDataView.Click += new System.EventHandler(this.miDataView_Click);
            // 
            // miLayoutView
            // 
            this.miLayoutView.Name = "miLayoutView";
            this.miLayoutView.Size = new System.Drawing.Size(252, 30);
            this.miLayoutView.Text = "Layout View";
            this.miLayoutView.Click += new System.EventHandler(this.miLayoutView_Click);
            // 
            // miData
            // 
            this.miData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miViewLayerData,
            this.miCreateShapefile});
            this.miData.Name = "miData";
            this.miData.Size = new System.Drawing.Size(63, 32);
            this.miData.Text = "Data";
            // 
            // miViewLayerData
            // 
            this.miViewLayerData.Name = "miViewLayerData";
            this.miViewLayerData.Size = new System.Drawing.Size(232, 30);
            this.miViewLayerData.Text = "View Layer Data";
            this.miViewLayerData.Click += new System.EventHandler(this.miViewLayerData_Click);
            // 
            // miCreateShapefile
            // 
            this.miCreateShapefile.Name = "miCreateShapefile";
            this.miCreateShapefile.Size = new System.Drawing.Size(232, 30);
            this.miCreateShapefile.Text = "Create Shapefile";
            this.miCreateShapefile.Click += new System.EventHandler(this.miCreateShapefile_Click);
            // 
            // miEdit
            // 
            this.miEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miStartEditing,
            this.miStopEditing});
            this.miEdit.Name = "miEdit";
            this.miEdit.Size = new System.Drawing.Size(56, 32);
            this.miEdit.Text = "Edit";
            // 
            // miStartEditing
            // 
            this.miStartEditing.Name = "miStartEditing";
            this.miStartEditing.Size = new System.Drawing.Size(200, 30);
            this.miStartEditing.Text = "Start Editing";
            this.miStartEditing.Click += new System.EventHandler(this.startEditingToolStripMenuItem_Click);
            // 
            // miStopEditing
            // 
            this.miStopEditing.Enabled = false;
            this.miStopEditing.Name = "miStopEditing";
            this.miStopEditing.Size = new System.Drawing.Size(200, 30);
            this.miStopEditing.Text = "Stop Editing";
            this.miStopEditing.Click += new System.EventHandler(this.stopEditingToolStripMenuItem_Click);
            // 
            // selectionToolStripMenuItem
            // 
            this.selectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSpatialFilter,
            this.miClearSelection});
            this.selectionToolStripMenuItem.Name = "selectionToolStripMenuItem";
            this.selectionToolStripMenuItem.Size = new System.Drawing.Size(100, 32);
            this.selectionToolStripMenuItem.Text = "Selection";
            // 
            // miSpatialFilter
            // 
            this.miSpatialFilter.Name = "miSpatialFilter";
            this.miSpatialFilter.Size = new System.Drawing.Size(252, 30);
            this.miSpatialFilter.Text = "Select...";
            this.miSpatialFilter.Click += new System.EventHandler(this.miSpatialFilter_Click);
            // 
            // miClearSelection
            // 
            this.miClearSelection.Name = "miClearSelection";
            this.miClearSelection.Size = new System.Drawing.Size(252, 30);
            this.miClearSelection.Text = "Clear Selection";
            this.miClearSelection.Click += new System.EventHandler(this.miClearSelection_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 38);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 773);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarXY});
            this.statusStrip1.Location = new System.Drawing.Point(4, 782);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1284, 29);
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusBar1";
            // 
            // statusBarXY
            // 
            this.statusBarXY.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.statusBarXY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusBarXY.Name = "statusBarXY";
            this.statusBarXY.Size = new System.Drawing.Size(83, 24);
            this.statusBarXY.Text = "Test 123";
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(552, 287);
            this.axLicenseControl1.Margin = new System.Windows.Forms.Padding(4);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 5;
            // 
            // axToolbarControl1
            // 
            this.axToolbarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.axToolbarControl1.Location = new System.Drawing.Point(286, 38);
            this.axToolbarControl1.Margin = new System.Windows.Forms.Padding(4);
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            this.axToolbarControl1.Size = new System.Drawing.Size(1002, 28);
            this.axToolbarControl1.TabIndex = 3;
            // 
            // axTOCControl1
            // 
            this.axTOCControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.axTOCControl1.Location = new System.Drawing.Point(4, 38);
            this.axTOCControl1.Margin = new System.Windows.Forms.Padding(4);
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            this.axTOCControl1.Size = new System.Drawing.Size(282, 744);
            this.axTOCControl1.TabIndex = 4;
            this.axTOCControl1.OnMouseDown += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseDownEventHandler(this.axTOCControl1_OnMouseDown);
            // 
            // axMapControl1
            // 
            this.axMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControl1.Location = new System.Drawing.Point(4, 38);
            this.axMapControl1.Margin = new System.Windows.Forms.Padding(4);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(1284, 744);
            this.axMapControl1.TabIndex = 2;
            this.axMapControl1.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl1_OnMouseDown);
            this.axMapControl1.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl1_OnMouseMove);
            this.axMapControl1.OnMapReplaced += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMapReplacedEventHandler(this.axMapControl1_OnMapReplaced);
            // 
            // axPageLayoutControl1
            // 
            this.axPageLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axPageLayoutControl1.Location = new System.Drawing.Point(286, 66);
            this.axPageLayoutControl1.Name = "axPageLayoutControl1";
            this.axPageLayoutControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPageLayoutControl1.OcxState")));
            this.axPageLayoutControl1.Size = new System.Drawing.Size(1002, 716);
            this.axPageLayoutControl1.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 811);
            this.Controls.Add(this.axPageLayoutControl1);
            this.Controls.Add(this.axToolbarControl1);
            this.Controls.Add(this.axTOCControl1);
            this.Controls.Add(this.axMapControl1);
            this.Controls.Add(this.axLicenseControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "ArcEngine Controls Application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axPageLayoutControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuNewDoc;
        private System.Windows.Forms.ToolStripMenuItem menuOpenDoc;
        private System.Windows.Forms.ToolStripMenuItem menuSaveDoc;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuExitApp;
        private System.Windows.Forms.ToolStripSeparator menuSeparator;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBarXY;
        private System.Windows.Forms.ToolStripMenuItem miCreateBookmark;
        private System.Windows.Forms.ToolStripComboBox cbBookmarkList;
        private System.Windows.Forms.ToolStripMenuItem miPrint;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miDataView;
        private System.Windows.Forms.ToolStripMenuItem miLayoutView;
        private System.Windows.Forms.ToolStripMenuItem miExportMap;
        private System.Windows.Forms.ToolStripMenuItem miData;
        private System.Windows.Forms.ToolStripMenuItem miCreateShapefile;
        private System.Windows.Forms.ToolStripMenuItem miEdit;
        private System.Windows.Forms.ToolStripMenuItem miStartEditing;
        private System.Windows.Forms.ToolStripMenuItem miViewLayerData;
        private System.Windows.Forms.ToolStripMenuItem miStopEditing;
        private System.Windows.Forms.ToolStripMenuItem selectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miSpatialFilter;
        private System.Windows.Forms.ToolStripMenuItem miClearSelection;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private AxESRI.ArcGIS.Controls.AxPageLayoutControl axPageLayoutControl1;
    }
}

