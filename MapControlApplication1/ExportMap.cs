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
    public partial class ExportMap : Form
    {
        MainForm m_fraMain;

        public ExportMap()
        {
            InitializeComponent();
        }

        public ExportMap(MainForm frm)
        {
            InitializeComponent();
            m_fraMain = frm;
        }

        private void btFile_Click(object sender, EventArgs e)
        {
            sfd.Filter = "JPEG（*.jpg）|*.jpg|PNG（*.png）|*.png|TIFF（*.tif）|*.tif";
            sfd.FilterIndex = 1;

            sfd.RestoreDirectory = true;

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                tbFileName.Text = sfd.FileName.ToString(); 
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            int pOutputResolution = (int)nmudResolution.Value;
            string pExportFileName = tbFileName.Text.ToString();
            bool pWriteWorldFile = cbWorldFile.Checked;
            double pWidth = Convert.ToDouble(tbWidth.Text);
            double pHeight = Convert.ToDouble(tbHeight.Text);
            m_fraMain.ExportMap(pOutputResolution, pExportFileName, pWriteWorldFile, pWidth, pHeight);

            this.Close();
        }


    }
}
