using System;
using System.Windows.Forms;

namespace MapControlApplication1
{
    public partial class BookmarkNameExists : Form
    {
        public MainForm m_fraMain;
        private string m_BookmarkName;


        public BookmarkNameExists(MainForm fra, string bn)
        {
            InitializeComponent();
            m_fraMain = fra;
            m_BookmarkName = bn;
        }

        public void LabelChange(string sBookmarkName)
        {
            lbBookmarkExistedWarning.Text = "This data frame already contains a spatial bookmark named '" + sBookmarkName + "'.\n Would you like to replace it with this one?";
        }

        private void btYes_Click(object sender, EventArgs e)
        {
            m_fraMain.DeleteBookmark(m_BookmarkName);
            m_fraMain.CreateBookmark(m_BookmarkName);
            AdmitBookmarkName frmABN;
            frmABN = (AdmitBookmarkName)this.Owner;
            this.Close();
            frmABN.Close();
        }


        private void btCancel_Click(object sender, EventArgs e)
        {
            AdmitBookmarkName frmABN;
            frmABN = (AdmitBookmarkName)this.Owner;
            this.Close();
            frmABN.Close();
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
