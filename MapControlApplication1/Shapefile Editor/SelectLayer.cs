
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

namespace MapControlApplication1.Data_Operator
{
    public partial class SelectLayer : Form
    {
        MainForm m_fraMain;
        IMap m_map;  
        String m_LayerName;


        public SelectLayer()
        {
            InitializeComponent();
        }

        public SelectLayer(MainForm frm, IMap map)
        {
            InitializeComponent();
            m_fraMain = frm;
            m_map = map;

            for (int i = 0; i < m_map.LayerCount; i++)
            {
                this.cbLayerName.Items.Add(m_map.get_Layer(i).Name);
            }
            cbLayerName.SelectedIndex = 0;
        }

        private void cbLayerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_LayerName = cbLayerName.SelectedItem.ToString();
        }


        public string getLayerName()
        {
            return m_LayerName;
        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
