using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class Formxemhp : Form
    {
        public Formxemhp()
        {
            InitializeComponent();
        }

        private void hOCPHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOCPHIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void Formxemhp_Load(object sender, EventArgs e)
        {
            try
            {
                this.hOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.hOCPHITableAdapter.Fill(this.dS.HOCPHI);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            // TODO: This line of code loads data into the 'dS.HOCPHI' table. You can move, or remove it, as needed.
  
        }
    }
}
