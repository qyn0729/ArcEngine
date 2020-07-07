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

namespace MapControlApplication1.Data_Operator
{
    public partial class SelectFieldsInDataBoard : Form
    {
        public SelectFieldsInDataBoard()
        {
            InitializeComponent();
        }

        public SelectFieldsInDataBoard(IFeatureLayer featureLayer)
        {
            InitializeComponent();

            //add in all fields
            IField field = null;
            for (int i = 0; i < featureLayer.FeatureClass.Fields.FieldCount; i++)
            {
                field = featureLayer.FeatureClass.Fields.get_Field(i);
                lbxAllFields.Items.Add(field.Name);
            }
        }

        private void btnSelectAllFields_Click(object sender, EventArgs e)
        {
            //select all fields
            for(int i = 0; i < lbxAllFields.Items.Count; i++)
            {
                lbxSelectedFields.Items.Add(lbxAllFields.Items[i]);
            }
        }

        private void btnSelectOneField_Click(object sender, EventArgs e)
        {
            if(lbxAllFields.SelectedItems.Count > 0)
            {
                for (int i = 0; i < lbxAllFields.SelectedItems.Count; i++)
                {
                    if(!lbxSelectedFields.Items.Contains(lbxAllFields.SelectedItems[i]))
                    {
                        lbxSelectedFields.Items.Add(lbxAllFields.SelectedItems[i]);
                    }
                }
            }
        }

        private void btnCancelSelectOneField_Click(object sender, EventArgs e)
        {
            if(lbxSelectedFields.SelectedItems.Count > 0)
            {
                for(int i = 0; i < lbxSelectedFields.SelectedItems.Count; i++)
                {
                    lbxSelectedFields.Items.Remove(lbxSelectedFields.SelectedItems[i]);
                }
            }
        }

        private void btnCancelSelectAllFields_Click(object sender, EventArgs e)
        {
            lbxSelectedFields.Items.Clear();
        }

        public string[] GetSelectedFields()
        {
            string[] SelectedFields = new string[lbxSelectedFields.Items.Count];
            for(int i = 0; i < lbxSelectedFields.Items.Count; i++)
            {
                SelectedFields[i] = lbxSelectedFields.Items[i].ToString();
            }
            return SelectedFields;
        }
    }
}
