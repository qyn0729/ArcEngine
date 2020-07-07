using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ESRI.ArcGIS.Geometry;

namespace MapControlApplication1.Data_Operator
{
    public partial class AddFeature : Form
    {
        IFeature m_feature;
        IMap m_map;
        MainForm m_frmMain;

        public AddFeature()
        {
            InitializeComponent();
        }

        public AddFeature(IFeature feature, IMap map, MainForm frm)
        {
            InitializeComponent();
            m_feature = feature;
            m_map = map;
            m_frmMain = frm;

            ShowDataBoard();
        }       

        private void ShowDataBoard()
        {
            //Create data table
            DataTable dataTable = new DataTable();

            //Create data columns and add them into data table
            DataColumn dataColumn = new DataColumn();
            IField field = null;
            for (int i = 0; i < m_feature.Fields.FieldCount; i++)
            {
                dataColumn = new DataColumn();
                field = m_feature.Fields.get_Field(i);
                dataColumn.ColumnName = field.AliasName;
                dataColumn.DataType = Type.GetType("System.String");
                dataTable.Columns.Add(dataColumn);
            }
            
            //Get geometry type
            string geometryType;
            if (m_feature.Shape.GeometryType == esriGeometryType.esriGeometryPoint)
            {
                geometryType = "Point";
            }
            else if (m_feature.Shape.GeometryType == esriGeometryType.esriGeometryPolygon)
            {
                geometryType = "Polygon";
            }
            else if (m_feature.Shape.GeometryType == esriGeometryType.esriGeometryPolyline)
            {
                geometryType = "Polyline";
            }
            else
            {
                geometryType = "";
            }

            DataRow dataRow = dataTable.NewRow();

            //Traverse all columns and get their values
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                if (m_feature.Fields.get_Field(i).Type == esriFieldType.esriFieldTypeGeometry)
                {
                    dataRow[i] = geometryType;
                }
                else
                {
                    dataRow[i] = m_feature.get_Value(i);
                }
            }
            dataTable.Rows.Add(dataRow);

            dataGridView1.DataSource = dataTable;
            for(int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if(m_feature.Fields.get_Field(i).Type == esriFieldType.esriFieldTypeOID || 
                    m_feature.Fields.get_Field(i).Type == esriFieldType.esriFieldTypeGeometry) //Can't change OID and geometry type
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
            }
        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if(dataGridView1.Columns[i].ReadOnly == false)
                {
                    m_feature.set_Value(i, dataGridView1.Rows[0].Cells[i].Value);
                }               
            }
            m_feature.Store();
            m_frmMain.RefreshMap();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
