using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.Carto;
using MapControlApplication1.Data_Operator;
using MapControlApplication1.MapAnalysis;

namespace MapControlApplication1
{
    public partial class DataBoard : Form
    {
        public IMap m_map;
        DataOperator m_dataOperator = null;
        bool m_DataTableChanged;
        bool IndexChangeFlag = true;
        IFeatureCursor m_FeatureCursor;
        ISelectionSet m_SelectionSet;

        public DataBoard()
        {
            InitializeComponent();
        }

        public DataBoard(IMap map, DataTable dataTable)
        {
            //Initialize components
            InitializeComponent();
            m_map = map;

            //Input data source
            dataGridView1.DataSource = dataTable;
            AddLayerNameIntoComboBox();
            m_dataOperator = new DataOperator(m_map);
        }

        public DataBoard(IMap map, DataTable dataTable, IFeatureCursor cursor, ISelectionSet set)
        {
            //Initialize components
            InitializeComponent();
            m_map = map;
            m_SelectionSet = set;

            //Input data source
            m_dataOperator = new DataOperator(m_map);
            dataGridView1.DataSource = dataTable;
            AddLayerNameIntoComboBox(); 
            
            //Don't change the data table
            IndexChangeFlag = false;
            m_FeatureCursor = cursor;
        }

        //Traverse all the layers and add their names into the ComboBox
        private void AddLayerNameIntoComboBox()
        {
            for(int i = 0; i < m_map.LayerCount; i++)
            {
                this.cbDataNameList.Items.Add(m_map.get_Layer(i).Name);
            }
        }

        //Find the selected layer and view its data
        private void cbDataNameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(IndexChangeFlag == false)
            {
                return;
            }
            //Input data into data grid view           
            dataGridView1.DataSource = m_dataOperator.GetDataTable
                (m_dataOperator.GetLayerByName(cbDataNameList.SelectedItem.ToString()));

            //Change the size of table if the data is newly loaded
            m_DataTableChanged = true;

            //Change the anchor style of data grid view
            //Change its size when the size of data board changes
            dataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);

            //Use m_width to store the width of all columns
            int m_width = 0;
            m_width = (dataGridView1.ColumnCount + 1) * dataGridView1.Columns[0].Width;

            //Compare m_width with the width of data board
            if (m_width < this.Width)
            {
                //Let data grid view have the same width as m_width when it's too large
                dataGridView1.Width = m_width;
                dataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            }
            else
            {
                //Let data grid view be as large as it can be
                //when it's smaller than m_width
                if(dataGridView1.Width < (this.Width - 35))
                {
                    dataGridView1.Width = this.Width - 35;
                }
                dataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
            }
        }

        private void DataBoard_SizeChanged(object sender, EventArgs e)
        {
            //Do not change widths when no data has been loaded
            if(m_dataOperator != null)
            {
                //Use m_width to store the width of all columns
                int m_width = 0;
                m_width = (dataGridView1.ColumnCount + 1) * dataGridView1.Columns[0].Width;

                //Compare m_width with the width of data board
                if (m_width < this.Width)
                {
                    //Let data grid view have the same width as m_width when it's too large
                    if (dataGridView1.Width > m_width)
                    {
                        dataGridView1.Width = m_width;
                    }
                    dataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom);
                }
                else
                {
                    //Let data grid view be as large as it can be
                    //when it's smaller than m_width
                    dataGridView1.Width = this.Width - 35;
                    dataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
                }

                //Declare that this data is not newly loaded
                m_DataTableChanged = false;
            }
            
        }

        public void cbEnabledFalse()
        {
            cbDataNameList.Enabled = false;
        }

        //Select Fields
        private void btnSelectFields_Click(object sender, EventArgs e)
        {
            IFeature feature;
            ILayer layer = m_dataOperator.GetLayerByName(cbDataNameList.Text);
            IFeatureLayer featureLayer = layer as IFeatureLayer;
            SelectFieldsInDataBoard frmSelectFields = new SelectFieldsInDataBoard(featureLayer);
            string[] SelectedFields = new string[featureLayer.FeatureClass.Fields.FieldCount];
            if (frmSelectFields.ShowDialog() == DialogResult.OK)
            {
                SelectedFields = frmSelectFields.GetSelectedFields();
            }

            //Get the geometry type of shapes
            string geometryType = m_dataOperator.GeometryType(featureLayer);
            if (IndexChangeFlag)
            {
                //Using "Search" to traverse all the features stored in this layer               
                m_FeatureCursor = featureLayer.Search(null, false);
            }
          
            //return null if the first feature cannot be found
            feature = m_FeatureCursor.NextFeature();
            if (feature == null)
            {
                return;
            }

            //Create data table
            DataTable dataTable = new DataTable();

            //Create data columns and add them into data table
            DataColumn dataColumn = new DataColumn();
            IField field = null;
            for (int i = 0; i < SelectedFields.Length; i++)
            {
                dataColumn = new DataColumn();
                field = featureLayer.FeatureClass.Fields.get_Field
                    (featureLayer.FeatureClass.Fields.FindField(SelectedFields[i]));
                dataColumn.ColumnName = SelectedFields[i];
                dataColumn.DataType = Type.GetType("System.String");
                dataTable.Columns.Add(dataColumn);
            }

            //Input values into data rows
            DataRow dataRow;
            while (feature != null)
            {
                dataRow = dataTable.NewRow();

                //Traverse all columns and get their values
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    if (featureLayer.FeatureClass.Fields.get_Field
                        (featureLayer.FeatureClass.Fields.FindField(dataTable.Columns[i].ColumnName)).Type 
                        == esriFieldType.esriFieldTypeGeometry)
                    {
                        dataRow[i] = geometryType;
                    }
                    else
                    {
                        dataRow[i] = feature.get_Value(feature.Fields.FindField(dataTable.Columns[i].ColumnName));
                    }

                }
                dataTable.Rows.Add(dataRow);
                feature = m_FeatureCursor.NextFeature();
            }

            //Refresh data table
            dataGridView1.DataSource = dataTable;
        }

        public void SetSelectedLayer(string sLayerName)
        {
            cbDataNameList.Text = sLayerName;
        }

        private void btStatistics_Click(object sender, EventArgs e)
        {
            ILayer layer = m_dataOperator.GetLayerByName(cbDataNameList.SelectedItem.ToString());
            IFeatureLayer featureLayer = (IFeatureLayer)layer;
            if (IndexChangeFlag)
            {
                FieldStatistics fieldStatistics = new FieldStatistics(featureLayer, null, false);
                fieldStatistics.Show();
            }
            else
            {
                FieldStatistics fieldStatistics = new FieldStatistics(featureLayer, m_SelectionSet, true);
                fieldStatistics.Show();
            }
                
            
        }
    }
}
