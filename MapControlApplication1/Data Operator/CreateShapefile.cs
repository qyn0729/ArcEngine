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

namespace MapControlApplication1
{
    public partial class CreateShapefile : Form
    {
        MainForm m_fraMain;
        IMap m_map;

        public CreateShapefile()
        {
            InitializeComponent();
        }

        public CreateShapefile(MainForm frm, IMap map)
        {
            InitializeComponent();
            m_fraMain = frm;
            m_map = map;

            //Initialize combo box
            cbGeometryType.Items.Add("Point");
            cbGeometryType.Items.Add("Line");
            cbGeometryType.Items.Add("Polygon");
            cbGeometryType.SelectedIndex = 0;

            //Initialize list boxes
            listBoxFieldName.Items.Add("OID");
            listBoxFieldName.Items.Add("Name");
            listBoxFieldName.Items.Add("Shape");

            listBoxAliasName.Items.Add("序号");
            listBoxAliasName.Items.Add("姓名");
            listBoxAliasName.Items.Add("形状");

            listBoxFieldType.Items.Add("OID");
            listBoxFieldType.Items.Add("String");
            listBoxFieldType.Items.Add("Geometry");
        }

        //Choose the file folder to store the shapefile
        private void btFile_Click(object sender, EventArgs e)
        {
            fbd.Description = "Please choose a file folder:";
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.ShowNewFolderButton = true;

            if(fbd.ShowDialog() == DialogResult.OK)
            {
                tbFilePath.Text = fbd.SelectedPath.ToString();       
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Add a new field to fieldsEdit
        public void AddNewField(IFields fields, string sName, string sAlias, string sType)
        {
            IFieldsEdit fieldsEdit = fields as IFieldsEdit;

            IFieldEdit fieldEdit = new FieldClass();
            fieldEdit.Name_2 = sName;
            fieldEdit.AliasName_2 = sAlias;
            if(sType == "String")
            {
                fieldEdit.Type_2 = esriFieldType.esriFieldTypeString;//Change field type
            }
            else if(sType == "Int")
            {
                fieldEdit.Type_2 = esriFieldType.esriFieldTypeInteger;
            }

            fieldsEdit.AddField((IField)fieldEdit);
        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            IFields fields = new FieldsClass();
            IFieldsEdit fieldsEdit = fields as IFieldsEdit;

            //add fields
            for(int i = 3; i < listBoxFieldName.Items.Count; i++)
            {
                AddNewField(fields, listBoxFieldName.Items[i].ToString(), listBoxAliasName.Items[i].ToString(), 
                    listBoxFieldType.Items[i].ToString());
            }

            //Show message box when the input is not complete
            if(tbFilePath.Text == "")
            {
                MessageBox.Show("Please input file path!");
            }
            else if(tbShapefileName.Text == "")
            {
                MessageBox.Show("Please input file name!");
            }
            else if(System.IO.File.Exists(tbFilePath.Text+"\\"+tbShapefileName.Text+".shp"))
            {
                MessageBox.Show("The shapefile already exists!");
            }
            else
            {
                //Get parent directory and workspace names
                String sParentDirectory = tbFilePath.Text.Substring(0, fbd.SelectedPath.LastIndexOf("\\"));
                String sWorkspace = tbFilePath.Text.Substring(fbd.SelectedPath.LastIndexOf("\\") + 1);
                DataOperator dataOperator = new DataOperator(m_map);
                IFeatureClass featureClass = dataOperator.CreateShapefile(fields, sParentDirectory, sWorkspace, tbShapefileName.Text, cbGeometryType.SelectedItem.ToString());
                if (featureClass == null)
                {
                    MessageBox.Show("Failed to create shapefile!");
                }
                //add shapefile to the map
                if (MessageBox.Show("Do you want to add the shapefile to the map?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    dataOperator.AddFeatureClassToMap(featureClass, tbShapefileName.Text);
                }
                this.Close();
            }           
        }

        private void btAddFiled_Click(object sender, EventArgs e)
        {
            AddField addField = new AddField(this);
            addField.Show();
        }

        public bool AddTolbFieldName(string s)
        {
            if(listBoxFieldName.Items.Contains(s))
            {
                MessageBox.Show("The field name already exists!");  //Check whether the name exists
                return false;
            }
            else
            {
                listBoxFieldName.Items.Add(s);
                return true;
            }            
        }

        public void AddTolbAliasName(string s)
        {
            listBoxAliasName.Items.Add(s);
        }

        public void AddTolbFieldType(string s)
        {
            listBoxFieldType.Items.Add(s);
        }


    }
}
