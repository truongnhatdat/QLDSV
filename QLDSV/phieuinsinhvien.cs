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
    public partial class forminsv : Form
    {
        public forminsv()
        {
            InitializeComponent();
        }
        string macn = "";
        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdslop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void phieuinsinhvien_Load(object sender, EventArgs e)
        {
            try
            {
               
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.DS.LOP);
         
                macn = ((DataRowView)bdslop[bdslop.Position])["MAKH"].ToString();
                cmbKhoa.DataSource = Program.bds_dspm;
                cmbKhoa.DisplayMember = "TENSITE";
                cmbKhoa.ValueMember = "TENSERVER";
                cmbKhoa.SelectedIndex = Program.mChinhanh;
                if (Program.mGroup == "PGV")
                {
                    cmbKhoa.Enabled = true;

                }
                else cmbKhoa.Enabled = false;
                txtmalop.Text = ((DataRowView)bdslop[bdslop.Position])["MALOP"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue == null)
            {
                return;
            }
            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbKhoa.SelectedValue.ToString();

            if ((cmbKhoa.SelectedIndex != Program.mChinhanh) && (cmbKhoa.SelectedIndex != 2))
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }

            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới hoặc không có quyền vào chi nhánh", "", MessageBoxButtons.OK);
            else
            {
                try
                {
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Fill(this.DS.LOP);

                    txtmalop.Text = ((DataRowView)bdslop[bdslop.Position])["MALOP"].ToString();
                }
                catch (Exception ex)
                {
                }
           

            }   
        }

        private void cmblop_TextChanged(object sender, EventArgs e)
        {
            
                
        }

        private void cmbtenlop_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                for (int i = 0; i < bdslop.Count; i++)
                {
                    if (cmbtenlop.Text == ((DataRowView)bdslop[i])["TENLOP"].ToString())
                    {
                        txtmalop.Text = ((DataRowView)bdslop[i])["MALOP"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btnmanhinh_Click(object sender, EventArgs e)
        {
            phieudanhsachsinhvien obj;
            obj = new phieudanhsachsinhvien();
            String lenh;
            lenh = "EXEC sp_phieusinhvien'"+txtmalop.Text+"'";
            DataTable MyTable;
            MyTable = Program.ExecSqlDataTable(lenh, Program.connstr);
            obj.SetDataSource(MyTable);
            obj.SetParameterValue("TENLOP", cmbtenlop.Text);
            crptView.ReportSource = obj;
        }
    }
}
