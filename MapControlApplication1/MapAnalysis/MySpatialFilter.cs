using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
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

namespace MapControlApplication1.MapAnalysis
{
    public partial class MySpatialFilter : Form
    {
        IMap m_map;
        ILayer m_layer;
        public MySpatialFilter()
        {
            InitializeComponent();
        }

        public MySpatialFilter(IMap map, string sUnit)
        {
            InitializeComponent();
            m_map = map;

            //Add in all layers to choose
            for (int i = 0; i < map.LayerCount; i++)
            {
                cbLayerName.Items.Add(map.get_Layer(i).Name);
            }
            cbLayerName.SelectedIndex = 0;

            //Add in all fields of the first layer
            DataOperator dataOperator = new DataOperator(m_map);
            m_layer = dataOperator.GetLayerByName(cbLayerName.SelectedItem.ToString());
            IFeatureLayer featureLayer = m_layer as IFeatureLayer;
            IField field = null;
            for (int i = 0; i < featureLayer.FeatureClass.Fields.FieldCount; i++)
            {
                field = featureLayer.FeatureClass.Fields.get_Field(i);
                if(field.Type == esriFieldType.esriFieldTypeDouble || 
                    field.Type == esriFieldType.esriFieldTypeInteger || 
                    field.Type == esriFieldType.esriFieldTypeSmallInteger || 
                    field.Type == esriFieldType.esriFieldTypeString)
                {
                    lbxFields.Items.Add(field.Name);
                }               
            }

            //add in methods
            cbMethod.Items.Add("Contains");
            cbMethod.Items.Add("Intersects");
            cbMethod.Items.Add("Envelope Intersects");
            cbMethod.Items.Add("Index Intersects");
            cbMethod.Items.Add("Are within a distance of");
            cbMethod.SelectedIndex = 0;

            //Change unit label
            lbUnit.Text = sUnit;

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
                if (field.Type == esriFieldType.esriFieldTypeDouble ||
                    field.Type == esriFieldType.esriFieldTypeInteger ||
                    field.Type == esriFieldType.esriFieldTypeSmallInteger ||
                    field.Type == esriFieldType.esriFieldTypeString)
                {
                    lbxFields.Items.Add(field.Name);
                }
            }

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

        public IGeometry GetSpatialFilter()
        {
            IGeometry geom = null;
            IFeature feature;
            IFeatureCursor featCursor = null;
            IQueryFilter queryFilter = new QueryFilter();
            queryFilter.WhereClause = tbQuery.Text; //set query clause

            //query
            DataOperator dataOperator = new DataOperator(m_map);
            IFeatureLayer featureLayer = (IFeatureLayer)dataOperator.GetLayerByName(cbLayerName.Text);
            try
            {
                //get feature cursor
                featCursor = (IFeatureCursor)featureLayer.FeatureClass.Search(queryFilter, false);               
            }
            catch
            {
                MessageBox.Show("Invalid query!");
                return null;
            }
            feature = featCursor.NextFeature();
            IFeatureClass featureClass = feature.Class as IFeatureClass;

            //combine the geometries
            int count = 0;
            IGeometryCollection geometries = new GeometryBagClass();
            object missing = Type.Missing;
            while (feature != null)
            {
                geom = feature.ShapeCopy;
                geometries.AddGeometry(geom, ref missing, ref missing);
                feature = featCursor.NextFeature();
                count++;
            }

            //combine the geometries
            if (count > 1)
            {
                ITopologicalOperator unionedGeometry = null;
                switch (featureClass.ShapeType)
                {
                    case esriGeometryType.esriGeometryMultipoint:
                        unionedGeometry = new MultipointClass(); break;
                    case esriGeometryType.esriGeometryPolyline:
                        unionedGeometry = new PolylineClass(); break;
                    case esriGeometryType.esriGeometryPolygon:
                        unionedGeometry = new PolygonClass(); break;
                    case esriGeometryType.esriGeometryPoint:
                        unionedGeometry = new MultipointClass(); break;
                    default: break;
                }
                unionedGeometry.ConstructUnion(geometries as IEnumGeometry);

                geom = unionedGeometry as IGeometry;
            }
           
            //get buffer
            if(cbMethod.Text == "Are within a distance of")
            {
                ITopologicalOperator ipTO = (ITopologicalOperator)geom;
                IGeometry iGeomBuffer = ipTO.Buffer(int.Parse(tbSearchDistance.Text));
                geom = iGeomBuffer;
            }

            return geom;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
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

        private void btnGetUniqueValues_Click_1(object sender, EventArgs e)
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
                    if(featureLayer.FeatureClass.Fields.get_Field(featureLayer.FeatureClass.FindField(lbxFields.SelectedItem.ToString())).Type == esriFieldType.esriFieldTypeString)
                    {
                        lbxUniqueValues.Items.Add("'"+enumerator.Current.ToString()+"'");
                    }
                    else lbxUniqueValues.Items.Add(enumerator.Current.ToString());
                }
            }
        }

        private void lbxUniqueValues_MouseDoubleClick_1(object sender, MouseEventArgs e)
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

        public esriSpatialRelEnum GetSpatialRelation()
        {
            esriSpatialRelEnum pesriSpatialRelationEnum = esriSpatialRelEnum.esriSpatialRelContains;
            if(cbMethod.Text == "Contains")
            {
                pesriSpatialRelationEnum = esriSpatialRelEnum.esriSpatialRelContains;
            }
            else if(cbMethod.Text == "Intersects")
            {
                pesriSpatialRelationEnum = esriSpatialRelEnum.esriSpatialRelIntersects;
            }
            else if(cbMethod.Text == "Envelope Intersects")
            {
                pesriSpatialRelationEnum = esriSpatialRelEnum.esriSpatialRelEnvelopeIntersects;
            }
            else if(cbMethod.Text == "Index Intersects")
            {
                pesriSpatialRelationEnum = esriSpatialRelEnum.esriSpatialRelIndexIntersects;
            }
            else if(cbMethod.Text == "Are within a distance of")
            {
                pesriSpatialRelationEnum = esriSpatialRelEnum.esriSpatialRelIndexIntersects;
            }

            return pesriSpatialRelationEnum;
        }

        private void cbMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMethod.Text == "Contains")
            {
                cbxApplySearchDistance.Checked = false;
            }
            else if (cbMethod.Text == "Intersects")
            {
                cbxApplySearchDistance.Checked = false;
            }
            else if (cbMethod.Text == "Envelope Intersects")
            {
                cbxApplySearchDistance.Checked = false;
            }
            else if (cbMethod.Text == "Index Intersects")
            {
                cbxApplySearchDistance.Checked = false;
            }
            else if (cbMethod.Text == "Are within a distance of")
            {
                cbxApplySearchDistance.Checked = true;
            }
        }
    }
}
