using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;

using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.ADF;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Output;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataSourcesFile;
using MapControlApplication1.Data_Operator;
using MapControlApplication1.Shapefile_Editor;

namespace MapControlApplication1
{
    public sealed partial class MainForm : Form
    {
        #region class private members
        private IMapControl3 m_mapControl = null;
        private IPageLayoutControl3 m_pageLayoutControl = null;
        private string m_mapDocumentName = string.Empty;
        #endregion


        #region class constructor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion


        private void MainForm_Load(object sender, EventArgs e)
        {
            //get the MapControl
            m_mapControl = (IMapControl3)axMapControl1.Object;

            //get the PageLayoutControl
            m_pageLayoutControl = (IPageLayoutControl3)axPageLayoutControl1.Object;

            //disable the Save menu (since there is no document yet)
            menuSaveDoc.Enabled = false;
        }

        #region Main Menu event handlers
        private void menuNewDoc_Click(object sender, EventArgs e)
        {
            //execute New Document command
            ICommand command = new CreateNewDocument();
            command.OnCreate(m_mapControl.Object);
            command.OnClick();


            IObjectCopy objectCopy = new ObjectCopyClass();
            object copyFromMap = axMapControl1.Map;
            int count = axMapControl1.Map.LayerCount;
            object copyMap = objectCopy.Copy(copyFromMap);
            object copyToMap = axPageLayoutControl1.ActiveView.FocusMap;
            objectCopy.Overwrite(copyMap, ref copyToMap);
            axPageLayoutControl1.ActiveView.Refresh();
        }

        private void menuOpenDoc_Click(object sender, EventArgs e)
        {
            //execute Open Document command
            ICommand command = new ControlsOpenDocCommandClass();
            command.OnCreate(m_mapControl.Object);
            command.OnClick();
        }

        private void menuSaveDoc_Click(object sender, EventArgs e)
        {
            //execute Save Document command
            if (m_mapControl.CheckMxFile(m_mapDocumentName))
            {
                //create a new instance of a MapDocument
                IMapDocument mapDoc = new MapDocumentClass();
                mapDoc.Open(m_mapDocumentName, string.Empty);

                //Make sure that the MapDocument is not readonly
                if (mapDoc.get_IsReadOnly(m_mapDocumentName))
                {
                    MessageBox.Show("Map document is read only!");
                    mapDoc.Close();
                    return;
                }

                //Replace its contents with the current map
                mapDoc.ReplaceContents((IMxdContents)m_mapControl.Map);

                //save the MapDocument in order to persist it
                mapDoc.Save(mapDoc.UsesRelativePaths, false);

                //close the MapDocument
                mapDoc.Close();
            }
        }

        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            //execute SaveAs Document command
            ICommand command = new ControlsSaveAsDocCommandClass();
            command.OnCreate(m_mapControl.Object);
            command.OnClick();
        }

        private void menuExitApp_Click(object sender, EventArgs e)
        {
            //exit the application
            Application.Exit();
        }
        #endregion

        //listen to MapReplaced evant in order to update the statusbar and the Save menu
        private void axMapControl1_OnMapReplaced(object sender, IMapControlEvents2_OnMapReplacedEvent e)
        {
            //get the current document name from the MapControl
            m_mapDocumentName = m_mapControl.DocumentFilename;

            //if there is no MapDocument, diable the Save menu and clear the statusbar
            if (m_mapDocumentName == string.Empty)
            {
                menuSaveDoc.Enabled = false;
                statusBarXY.Text = string.Empty;
            }
            else
            {
                //enable the Save manu and write the doc name to the statusbar
                menuSaveDoc.Enabled = true;
                statusBarXY.Text = System.IO.Path.GetFileName(m_mapDocumentName);
            }
        }

        private void axMapControl1_OnMouseMove(object sender, IMapControlEvents2_OnMouseMoveEvent e)
        {
            statusBarXY.Text = string.Format("{0}, {1}  {2}", e.mapX.ToString("#######.##"), e.mapY.ToString("#######.##"), axMapControl1.MapUnits.ToString().Substring(4));
        }



        //Function: Create bookmarks;
        //Input: sBookmarkName is the name of the input bookmark
        //Output: Space
        //2019/3/8
        public void CreateBookmark(string sBookmarkName) //sBookmarkName is the name of the bookmark
        {
            
            //aoiBookmark is used to save the map extent
            IAOIBookmark aoiBookmark = new AOIBookmarkClass();
            if (aoiBookmark != null)
            {
                aoiBookmark.Location = axMapControl1.ActiveView.Extent;
                aoiBookmark.Name = sBookmarkName;
            }

            //Add aoiBookmark to map
            IMapBookmarks bookmarks = axMapControl1.Map as IMapBookmarks;
            if (bookmarks != null)
            {
                bookmarks.AddBookmark(aoiBookmark);
            }

            //Add aoiBookmark to combobox
            cbBookmarkList.Items.Add(sBookmarkName);
        }

        public bool BookmarkExistsOrNot(string sBookmarkName)
        {
            IMapBookmarks bookmarks = axMapControl1.Map as IMapBookmarks;
            if (bookmarks != null)
            {
                IEnumSpatialBookmark enumSpatialBookmark = bookmarks.Bookmarks;

                ISpatialBookmark spatialBookmark = enumSpatialBookmark.Next();

                while (spatialBookmark != null)
                {
                    if (spatialBookmark.Name == sBookmarkName)
                    {
                        return true;
                    }
                    spatialBookmark = enumSpatialBookmark.Next();
                }
            }
            return false;
        }

        public void DeleteBookmark(string sBookmarkName) //delete the bookmark named sBookmarkName
        {
            IMapBookmarks bookmarks = axMapControl1.Map as IMapBookmarks; 
            IEnumSpatialBookmark enumSpatialBookmark = bookmarks.Bookmarks;
            ISpatialBookmark spatialBookmark = enumSpatialBookmark.Next();

            while (spatialBookmark != null)
            {
                if (spatialBookmark.Name == sBookmarkName)
                {
                    bookmarks.RemoveBookmark(spatialBookmark);
                    break;
                }
                spatialBookmark = enumSpatialBookmark.Next();
            }

            cbBookmarkList.Items.Remove(sBookmarkName); //Remove the name of the bookmark from the ComboBox
        }

        //Open AdmitBookmarkName.cs
        private void miCreateBookmark_Click(object sender, EventArgs e)
        {
            AdmitBookmarkName frmABN = new AdmitBookmarkName(this);
            frmABN.Show();
            IMapBookmarks bookmarks = axMapControl1.Map as IMapBookmarks;
        }

        private void cbBookmarkList_SelectedIndexChanged(object sender, EventArgs e)
        {
            IMapBookmarks bookmarks = axMapControl1.Map as IMapBookmarks;

            IEnumSpatialBookmark enumSpatialBookmark = bookmarks.Bookmarks;

            ISpatialBookmark spatialBookmark = enumSpatialBookmark.Next();

            while(spatialBookmark != null)
            {
                if ((spatialBookmark.Name) == cbBookmarkList.SelectedItem.ToString())
                {
                    spatialBookmark.ZoomTo((IMap)axMapControl1.ActiveView);
                    axMapControl1.ActiveView.Refresh();
                    break;
                }
                spatialBookmark = enumSpatialBookmark.Next();
            }   
        }

        //Function: View Data;
        //2019/3/21
        private void miViewLayerData_Click(object sender, EventArgs e)
        {
            //Show data board
            DataBoard frmDB = new DataBoard(axMapControl1.Map, null);
            frmDB.Show();
        }

        //Function: Change the symbol of layers
        //Date:2019/3/29
        public void RefreshMap()
        {
            axMapControl1.ActiveView.Refresh();
            axPageLayoutControl1.ActiveView.Refresh();
        }

        public void RefreshTOCControl()
        {
            axTOCControl1.Update();
        }

        private void axTOCControl1_OnMouseDown(object sender, ITOCControlEvents_OnMouseDownEvent e)
        {
            if (e.button == 1)
            {
                //Get the required layer
                esriTOCControlItem item = esriTOCControlItem.esriTOCControlItemNone;
                IBasicMap map = new MapClass();
                ILayer layer = new FeatureLayerClass();
                object other = new object();
                object index = new object();
                axTOCControl1.HitTest(e.x, e.y, ref item, ref map, ref layer, ref other, ref index);

                //Click on the legend class
                if (item == esriTOCControlItem.esriTOCControlItemLegendClass)
                {
                    IFeatureLayer featureLayer = layer as IFeatureLayer;
                    if (featureLayer != null)
                    {
                        //Show different frames when the type of feature is different
                        if (featureLayer.FeatureClass.ShapeType == esriGeometryType.esriGeometryPoint)
                        {
                            RenderLayerPoint layerPoint = new RenderLayerPoint(featureLayer, this);
                            layerPoint.Show();
                        }
                        else if (featureLayer.FeatureClass.ShapeType == esriGeometryType.esriGeometryLine || featureLayer.FeatureClass.ShapeType == esriGeometryType.esriGeometryPolyline)
                        {
                            RenderLayerLine layerLine = new RenderLayerLine(featureLayer, this);
                            layerLine.Show();
                        }
                        else if (featureLayer.FeatureClass.ShapeType == esriGeometryType.esriGeometryPolygon)
                        {
                            RenderLayerFill layerFill = new RenderLayerFill(featureLayer, this);
                            layerFill.Show();
                        }
                        else
                        {
                            ;
                        }
                    }

                }
            }
        }

        //Function: Data View / Layout View
        //Date:2019/4/3
        private void miLayoutView_Click(object sender, EventArgs e)
        {
            if(miLayoutView.Checked == false)
            {
                //Data View to Layout View
                miLayoutView.Checked = true;
                miDataView.Checked = false;
                miPrint.Enabled = true;

                axTOCControl1.SetBuddyControl(axPageLayoutControl1);
                axToolbarControl1.SetBuddyControl(axPageLayoutControl1);

                axMapControl1.Visible = false;
                axPageLayoutControl1.Visible = true;

                IObjectCopy objectCopy = new ObjectCopyClass();
                object copyFromMap = axMapControl1.Map;
                object copyMap = objectCopy.Copy(copyFromMap);
                object copyToMap = axPageLayoutControl1.ActiveView.FocusMap;
                objectCopy.Overwrite(copyMap, ref copyToMap);

                axPageLayoutControl1.ActiveView.Refresh();
                axTOCControl1.Update();
            }
            else
            {
                //Layout View to DataView
                miDataView.Checked = true;
                miLayoutView.Checked = false;
                miPrint.Enabled = false;

                axTOCControl1.SetBuddyControl(axMapControl1);
                axToolbarControl1.SetBuddyControl(axMapControl1);

                axMapControl1.Visible = true;
                axPageLayoutControl1.Visible = false;

                //Copy objects
                IObjectCopy objectCopy = new ObjectCopyClass();
                object copyFromMap = axPageLayoutControl1.ActiveView.FocusMap;
                object copyMap = objectCopy.Copy(copyFromMap);
                object copyToMap = axMapControl1.Map;
                objectCopy.Overwrite(copyMap, ref copyToMap);

                axMapControl1.ActiveView.Refresh();
                axTOCControl1.Update();
            }
        }

        private void miDataView_Click(object sender, EventArgs e)
        {
            if(miDataView.Checked == false)
            {
                //Layout View to DataView
                miDataView.Checked = true;
                miLayoutView.Checked = false;
                miPrint.Enabled = false;

                axTOCControl1.SetBuddyControl(axMapControl1);
                axToolbarControl1.SetBuddyControl(axMapControl1);

                axMapControl1.Visible = true;
                axPageLayoutControl1.Visible = false;

                //Copy objects
                IObjectCopy objectCopy = new ObjectCopyClass();
                object copyFromMap = axPageLayoutControl1.ActiveView.FocusMap;
                object copyMap = objectCopy.Copy(copyFromMap);
                object copyToMap = axMapControl1.Map;
                objectCopy.Overwrite(copyMap, ref copyToMap);

                axMapControl1.ActiveView.Refresh();
                axTOCControl1.Update();
            }
            else
            {
                //Data View to Layout View
                miLayoutView.Checked = true;
                miDataView.Checked = false;
                miPrint.Enabled = true;

                axTOCControl1.SetBuddyControl(axPageLayoutControl1);
                axToolbarControl1.SetBuddyControl(axPageLayoutControl1);

                axMapControl1.Visible = false;
                axPageLayoutControl1.Visible = true;

                IObjectCopy objectCopy = new ObjectCopyClass();
                object copyFromMap = axMapControl1.Map;
                object copyMap = objectCopy.Copy(copyFromMap);
                object copyToMap = axPageLayoutControl1.ActiveView.FocusMap;
                objectCopy.Overwrite(copyMap, ref copyToMap);

                axPageLayoutControl1.ActiveView.Refresh();
                axTOCControl1.Update();
            }
        }

        //Function: Print map
        //Date: 2019/4/3
        private void miPrint_Click(object sender, EventArgs e)
        {
            IPrinter printer = axPageLayoutControl1.Printer;
            if(printer == null)
            {
                MessageBox.Show("Failed to connect to the default printer!");
            }

            String sMsg = "Do you want to use the default printer:" + printer.Name + "?";
            if(MessageBox.Show(sMsg, "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }

            IPaper paper = printer.Paper;
            paper.Orientation = 1;

            IPage page = axPageLayoutControl1.Page;
            page.PageToPrinterMapping = esriPageToPrinterMapping.esriPageMappingScale;

            axPageLayoutControl1.PrintPageLayout(1, 1, 0);
        }

        //Function: Export map
        //Date: 2019/4/3
        public void ExportMap(int pOutputResolution, string pExportFileName, bool pWriteWorldFile, double pWidth, double pHeight)
        {
            IActiveView docActiveView;
            IExport docExport;
            IPrintAndExport docPrintExport;
            IWorldFileSettings pWorldFile = null;
            ESRI.ArcGIS.esriSystem.tagRECT userRECT = new ESRI.ArcGIS.esriSystem.tagRECT();
            IEnvelope pEnv = new EnvelopeClass();

            string pFileType;
            int pFileNameLength = pExportFileName.Length;
            if(pFileNameLength > 3)
            {
                pFileType = pExportFileName.Substring(pFileNameLength - 3, 3);
            }
            else
            {
                pFileType = pExportFileName;
            }

            switch(pFileType)
            {
                case "jpg":
                    docExport = new ExportJPEGClass();
                    break;
                case "png":
                    docExport = new ExportPNGClass();
                    break;
                case "tif":
                    docExport = new ExportTIFFClass();
                    break;
                default:
                    docExport = new ExportJPEGClass();
                    break;
            }

            if (miLayoutView.Checked)
            {
                docActiveView = axPageLayoutControl1.ActiveView;
            }
            else
            {
                docActiveView = axMapControl1.ActiveView;
            }

            pEnv = docActiveView.Extent;
            pWorldFile = (IWorldFileSettings)docExport;
            pWorldFile.MapExtent = pEnv;
            pWorldFile.OutputWorldFile = pWriteWorldFile;

            userRECT.left = 0;
            userRECT.top = 0;
            userRECT.right = Convert.ToInt32(pWidth);
            userRECT.bottom = Convert.ToInt32(pHeight);

            IEnvelope pDriverBounds = new EnvelopeClass();
            pDriverBounds.PutCoords(userRECT.top, userRECT.bottom, userRECT.right, userRECT.top);
            docExport.PixelBounds = pDriverBounds;

            docPrintExport = new PrintAndExportClass();

            docExport.ExportFileName = pExportFileName;
            docPrintExport.Export(docActiveView, docExport, pOutputResolution, true, null);
        }

        private void miExportMap_Click(object sender, EventArgs e)
        {
            ExportMap exportMap = new ExportMap(this);
            exportMap.Show();
        }


        //Function: Create shapefile
        //Date: 2019/4/10
       
        private void miCreateShapefile_Click(object sender, EventArgs e)
        {
            CreateShapefile createShapefile = new CreateShapefile(this, axMapControl1.Map);
            createShapefile.Show();
        }

        //Function: Add feature
        //Date: 2019/4/17
        String sEditLayerName;
        DrawPolygon drawPolygon = null;
        private void axMapControl1_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)
        {
            if (miStartEditing.Enabled == false) //Start Editing
            {
                DataOperator dataOperator = new DataOperator(axMapControl1.Map);
                ILayer layer = dataOperator.GetLayerByName(sEditLayerName); // Get the layer to edit
                IFeatureLayer featureLayer = layer as IFeatureLayer;
                IFeature feature;

                if(featureLayer.FeatureClass.ShapeType == esriGeometryType.esriGeometryPoint) //Edit point
                {
                    IPoint point = new PointClass();
                    point.PutCoords(e.mapX, e.mapY);
                    feature = dataOperator.AddGeometryToLayer(sEditLayerName, point);
                    AddFeature addFeatureName = new AddFeature(feature, axMapControl1.Map, this);
                    addFeatureName.ShowDialog();
                }
                else if(featureLayer.FeatureClass.ShapeType == esriGeometryType.esriGeometryPolygon)
                {
                    if(drawPolygon == null)//Continue creating polygons when editting is not stopped
                    {
                        drawPolygon = new DrawPolygon(sEditLayerName, axMapControl1.Map, this);
                        drawPolygon.set_drawStart(true);
                        IPoint point = new PointClass();
                        point.PutCoords(e.mapX, e.mapY);
                        drawPolygon.set_startPoint(point);   //set start point                    
                        drawPolygon.OnCreate(axMapControl1.Object);
                        drawPolygon.set_polyFeedback(point);
                    }                                    
                } 
                return;
            }
           
        }

        private void startEditingToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            SelectLayer selectLayer = new SelectLayer(this, axMapControl1.Map);
            if(selectLayer.ShowDialog() == DialogResult.OK)
            {
                sEditLayerName = selectLayer.getLayerName();
                miStartEditing.Enabled = false;
                miStopEditing.Enabled = true;
            }
        }

        private void stopEditingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miStopEditing.Enabled = false;
            miStartEditing.Enabled = true;
            if(drawPolygon != null)
            {
                drawPolygon.set_drawStart(false);//Stop creating polygons
                drawPolygon = null;
            }           
        }

        //Function: Spatial Filter
        //Date: 2019/5/8
        private void miSpatialFilter_Click(object sender, EventArgs e)
        {
            esriUnits mapUnits = axMapControl1.MapUnits;
            string sMapUnits = "";
            switch (mapUnits)
            {
                case esriUnits.esriCentimeters:
                    sMapUnits = "Centimeters";
                    break;

                case esriUnits.esriDecimalDegrees:
                    sMapUnits = "Decimal Degrees";
                    break;

                case esriUnits.esriDecimeters:
                    sMapUnits = "Decimeters";
                    break;

                case esriUnits.esriFeet:
                    sMapUnits = "Feet";
                    break;

                case esriUnits.esriInches:
                    sMapUnits = "Inches";
                    break;

                case esriUnits.esriKilometers:
                    sMapUnits = "Kilometers";
                    break;

                case esriUnits.esriMeters:
                    sMapUnits = "Meters";
                    break;

                case esriUnits.esriMiles:
                    sMapUnits = "Miles";
                    break;

                case esriUnits.esriMillimeters:
                    sMapUnits = "Millimeters";
                    break;

                case esriUnits.esriNauticalMiles:
                    sMapUnits = "NauticalMiles";
                    break;

                case esriUnits.esriPoints:
                    sMapUnits = "Points";
                    break;

                case esriUnits.esriUnknownUnits:
                    sMapUnits = "Unknown";
                    break;

                case esriUnits.esriYards:
                    sMapUnits = "Yards";
                    break;
            }
            SelectionByAttributes selectionByAttributes = new SelectionByAttributes(axMapControl1.Map, this, sMapUnits);
            selectionByAttributes.Show();
            
        }

        public void ActiveViewPartialRefresh()
        {
            IActiveView activeView;
            activeView = axMapControl1.ActiveView;
            activeView.PartialRefresh(esriViewDrawPhase.esriViewGeoSelection, 0, axMapControl1.Extent);
        }

        private void miClearSelection_Click(object sender, EventArgs e)
        {
            axMapControl1.Map.ClearSelection();
        }
    }
}