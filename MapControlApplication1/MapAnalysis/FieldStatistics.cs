using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.esriSystem;
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

namespace MapControlApplication1.MapAnalysis
{
    public partial class FieldStatistics : Form
    {
        IFeatureLayer m_FeatureLayer;
        ISelectionSet m_SelectionSet;
        bool m_WithSelectionSet;

        public FieldStatistics()
        {
            InitializeComponent();
        }

        public FieldStatistics(IFeatureLayer fl, ISelectionSet set, bool b)
        {
            InitializeComponent();
            m_FeatureLayer = fl;
            m_SelectionSet = set;
            m_WithSelectionSet = b;

            //Add fields whose type is int or double into combo box
            for(int i = 0; i < m_FeatureLayer.FeatureClass.Fields.FieldCount; i++)
            {
                if(m_FeatureLayer.FeatureClass.Fields.get_Field(i).Type == esriFieldType.esriFieldTypeInteger || 
                    m_FeatureLayer.FeatureClass.Fields.get_Field(i).Type == esriFieldType.esriFieldTypeDouble ||
                    m_FeatureLayer.FeatureClass.Fields.get_Field(i).Type == esriFieldType.esriFieldTypeSmallInteger)
                {
                    cbFieldNameList.Items.Add(m_FeatureLayer.FeatureClass.Fields.get_Field(i).Name.ToString());
                }
            }
        }

        private void cbFieldNameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            IFeatureClass featureClass = m_FeatureLayer.FeatureClass;
            IDataStatistics dataStatistics = new DataStatistics();

            //get cursor
            ICursor cursor;
            if (m_WithSelectionSet)
            {              
                m_SelectionSet.Search(null, true, out cursor);
            }
            else
            {
                IFeatureCursor featureCursor = featureClass.Search(null, false);
                cursor = (ICursor)featureCursor;
            }
            dataStatistics.Cursor = cursor;

            //input field
            int index = featureClass.Fields.FindField(cbFieldNameList.SelectedItem.ToString());
            dataStatistics.Field = featureClass.Fields.get_Field(index).Name;

            //get results
            IStatisticsResults statisticsResults;
            statisticsResults = dataStatistics.Statistics;

            lbMax.Text = statisticsResults.Maximum.ToString();
            lbMin.Text = statisticsResults.Minimum.ToString();
            lbAvg.Text = statisticsResults.Mean.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
