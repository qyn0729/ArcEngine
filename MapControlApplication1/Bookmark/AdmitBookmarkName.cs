using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.ADF;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Geometry;

namespace MapControlApplication1
{
     
    public partial class AdmitBookmarkName : Form
    {
        public MainForm m_fraMain;

        public AdmitBookmarkName(MainForm fra)
        {
            InitializeComponent();
            m_fraMain = fra;
        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            if(m_fraMain != null && tbBookmarkName.Text != "")
            { 
                if(m_fraMain.BookmarkExistsOrNot(tbBookmarkName.Text) == true) //The name of the bookmark already exists
                {
                    BookmarkNameExists frmABNE = new BookmarkNameExists(m_fraMain, tbBookmarkName.Text);
                    frmABNE.LabelChange(tbBookmarkName.Text);
                    frmABNE.Show(); //Show the frame named "BookmarkNameExists.cs"
                    frmABNE.Owner = this;
                }
                else
                {
                    m_fraMain.CreateBookmark(tbBookmarkName.Text); //Create a new bookmark
                    this.Close();
                }

            }
            else if(tbBookmarkName.Text == "" || tbBookmarkName.Text == null) //The input of the textbox can't be empty
            {
                MessageBox.Show("You must specify a bookmark name!");
            }    
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
