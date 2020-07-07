using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using MapControlApplication1.MapAnalysis;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MapControlApplication1
{
    public partial class SelectionByAttributes : Form
    {
        IMap m_map;
        ILayer m_layer; //selected layer
        MainForm m_frmMain;
        ISpatialFilter m_spatialFilter = new SpatialFilter();
        IFeatureCursor m_FeatureCursor;
        string m_mapUnits;

        public SelectionByAttributes()
        {
            InitializeComponent();
        }

        public SelectionByAttributes(IMap map, MainForm frm, string sUnit)
        {
            InitializeComponent();
            m_map = map;
            m_frmMain = frm;
            m_mapUnits = sUnit;

            //Add in all layers to choose
            for (int i = 0; i < map.LayerCount; i++)
            {
                cbLayerName.Items.Add(map.get_Layer(i).Name);
            }
            cbLayerName.SelectedIndex = 0;

            //Add in all fields of the first layer
            ILayer m_layer = map.get_Layer(0);
            IFeatureLayer featureLayer = m_layer as IFeatureLayer;
            IField field = null;
            for (int i = 0; i < featureLayer.FeatureClass.Fields.FieldCount; i++)
            {
                field = featureLayer.FeatureClass.Fields.get_Field(i);
                if (field.Type == esriFieldType.esriFieldTypeDouble ||
                    field.Type == esriFieldType.esriFieldTypeInteger ||
                    field.Type == esriFieldType.esriFieldTypeSmallInteger ||
                    field.Type == esriFieldType.esriFieldTypeString)
                {
                    lbxFields.Items.Add(field.Name);
                }
            }

            //Change layer name label
            lbLayerName.Text = cbLayerName.Text;

            //Add method
            cbMethod.Items.Add("Create a new selection");
            cbMethod.Items.Add("Add to current selection");
            cbMethod.Items.Add("Remove from current selection");
            cbMethod.Items.Add("Select from current selection");
            cbMethod.SelectedIndex = 0;
        }

        private void cbLayerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the chosen layer
            DataOperator dataOperator = new DataOperator(m_map);
            m_layer = dataOperator.GetLayerByName(cbLayerName.SelectedItem.ToString());

            //Add the fields of the layer
            IFeatureLayer featureLayer = m_layer as IFeatureLayer;
            IField field = null;
            lbxFields.Items.Clear();
            for (int i = 0; i < featureLayer.FeatureClass.Fields.FieldCount; i++)
            {
                field = featureLayer.FeatureClass.Fields.get_Field(i);
                lbxFields.Items.Add(field.Name);
            }

            //Change layer name label
            lbLayerName.Text = cbLayerName.Text;
        }

        //Add the field name into text box when double clicked
        private void lbxFields_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbxFields.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                tbQuery.Text += lbxFields.SelectedItem.ToString();
            }
            else
            {
                lbxFields.SelectedIndex = -1; //Cancel the seleciton
            }
        }

        private void btnGetUniqueValues_Click(object sender, EventArgs e)
        {
            if (lbxFields.SelectedItems.Count == 1)
            {
                IFeatureLayer featureLayer = m_layer as IFeatureLayer;

                //Using "Search" to traverse all the features stored in this layer
                IFeatureCursor featureCursor = featureLayer.Search(null, false);

                IDataStatistics dataStatistics = new DataStatisticsClass();
                dataStatistics.Field = lbxFields.SelectedItem.ToString();
                dataStatistics.Cursor = featureCursor as ICursor;

                //Add in features' values
                IEnumerator enumerator = dataStatistics.UniqueValues;
                enumerator.Reset();
                while (enumerator.MoveNext())
                {
                    //add '' if the type of the field is string
                    if (featureLayer.FeatureClass.Fields.get_Field(featureLayer.FeatureClass.FindField(lbxFields.SelectedItem.ToString())).Type == esriFieldType.esriFieldTypeString)
                    {
                        lbxUniqueValues.Items.Add("'" + enumerator.Current.ToString() + "'");
                    }
                    else lbxUniqueValues.Items.Add(enumerator.Current.ToString());
                }
            }
        }

        //Add values into text box when double clicked
        private void lbxUniqueValues_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbxUniqueValues.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                tbQuery.Text += lbxUniqueValues.SelectedItem.ToString();
            }
            else
            {
                lbxUniqueValues.SelectedIndex = -1; //Cancel the seleciton
            }
        }       

        private void btnSelectSpatialFilter_Click(object sender, EventArgs e)
        {
            MapControlApplication1.MapAnalysis.MySpatialFilter frmSpatialFilter = 
                new MapControlApplication1.MapAnalysis.MySpatialFilter(m_map, m_mapUnits);
            if(frmSpatialFilter.ShowDialog() == DialogResult.OK)
            {
                m_spatialFilter.Geometry = frmSpatialFilter.GetSpatialFilter();
                m_spatialFilter.SpatialRel = frmSpatialFilter.GetSpatialRelation();
            }
        }

        //Query Filter
        private void btnOK_Click(object sender, EventArgs e)
        {

            m_spatialFilter.WhereClause = tbQuery.Text;

            IFeatureSelection featureSelection = (IFeatureSelection)m_layer;
            
            try
            {
                if (cbMethod.Text == "Create a new selection")
                {
                    featureSelection.SelectFeatures(m_spatialFilter, esriSelectionResultEnum.esriSelectionResultNew, false);
                }
                else if(cbMethod.Text == "Add to current selection")
                {
                    featureSelection.SelectFeatures(m_spatialFilter, esriSelectionResultEnum.esriSelectionResultAdd, false);
                }
                else if(cbMethod.Text == "Remove from current selection")
                {
                    featureSelection.SelectFeatures(m_spatialFilter, esriSelectionResultEnum.esriSelectionResultSubtract, false);
                }
                else if(cbMethod.Text == "Select from current selection")
                {
                    featureSelection.SelectFeatures(m_spatialFilter, esriSelectionResultEnum.esriSelectionResultAnd, false);
                }
            }
            catch
            {
                MessageBox.Show("Invalid query!");
                this.Close();
            }

            //Show the attributes of the selected features
            ISelectionSet selectionSet = featureSelection.SelectionSet;
            ICursor cursor;
            selectionSet.Search(null, true, out cursor); //Get the cursor
            m_FeatureCursor = cursor as IFeatureCursor;

            IFeatureLayer featureLayer = m_layer as IFeatureLayer;
            DataOperator dataOperator = new DataOperator(m_map);
            if (selectionSet.Count > 0)
            {
                DataTable dataTable = dataOperator.GetDataTable(m_FeatureCursor, featureLayer);
                selectionSet.Search(null, true, out cursor); //Get the cursor
                m_FeatureCursor = cursor as IFeatureCursor;
                DataBoard dataBoard = new DataBoard(m_map, dataTable, m_FeatureCursor, selectionSet);
                dataBoard.SetSelectedLayer(m_layer.Name);
                dataBoard.cbEnabledFalse();
                dataBoard.Show();
            }

            m_frmMain.ActiveViewPartialRefresh();
            MessageBox.Show(selectionSet.Count + " features are selected.");
            this.Close();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            tbQuery.Text += "=";
        }

        private void btnGreaterLess_Click(object sender, EventArgs e)
        {
            tbQuery.Text += "<>";
        }

        private void btnGreater_Click(object sender, EventArgs e)
        {
            tbQuery.Text += ">";
        }

        private void btnGreaterEqual_Click(object sender, EventArgs e)
        {
            tbQuery.Text += ">=";
        }

        private void btnLess_Click(object sender, EventArgs e)
        {
            tbQuery.Text += "<";
        }

        private void btnLessEqual_Click(object sender, EventArgs e)
        {
            tbQuery.Text += "<=";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
