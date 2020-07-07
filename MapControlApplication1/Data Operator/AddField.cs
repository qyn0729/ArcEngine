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
    public partial class AddField : Form
    {
        CreateShapefile m_frmCS;

        public AddField()
        {
            InitializeComponent();
        }

        public AddField(CreateShapefile frmcs)
        {
            InitializeComponent();
            cbFieldType.Items.Add("String");
            cbFieldType.Items.Add("Int");
            cbFieldType.SelectedIndex = 0;
            m_frmCS = frmcs;
        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            if(tbFieldName.Text == "")
            {
                MessageBox.Show("Please input field name!");
            }
            else
            {
                if(m_frmCS.AddTolbFieldName(tbFieldName.Text))
                {
                    if (tbAliasName.Text == "")
                    {
                        m_frmCS.AddTolbAliasName(tbFieldName.Text);
                    }
                    else
                    {
                        m_frmCS.AddTolbAliasName(tbAliasName.Text);
                    }
                    m_frmCS.AddTolbFieldType(cbFieldType.SelectedItem.ToString());
                }               
            }
            
            tbFieldName.Text = "";
            tbAliasName.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
