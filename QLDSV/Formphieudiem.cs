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
    public partial class Formphieudiem : Form
    {
        public Formphieudiem()
        {
            InitializeComponent();
        }
        String masv = "";
        String hoten = "";
        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdssv.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }
        private void Formphieudiem_Load(object sender, EventArgs e)
        {
            
     
            try
            {
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                // macn = ((DataRowView)bdsLop[bdsLop.Position])["MAKH"].ToString();
                cmbkhoa.DataSource = Program.bds_dspm;
                cmbkhoa.DisplayMember = "TENSITE";
                cmbkhoa.ValueMember = "TENSERVER";
                cmbkhoa.SelectedIndex = Program.mChinhanh;
                if (Program.mGroup == "PGV")
                {
                    cmbkhoa.Enabled = true;

                }
                else cmbkhoa.Enabled = false;
                masv = ((DataRowView)bdssv[bdssv.Position])["MASV"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            phieudiem obj;
            obj = new phieudiem();
            String lenh;
            lenh = "EXEC sp_phieudiem'" + masv+ "'";
            DataTable MyTable;
            MyTable = Program.ExecSqlDataTable(lenh, Program.connstr);
            obj.SetDataSource(MyTable);
            obj.SetParameterValue("MASV",cmbmasv.Text);
            obj.SetParameterValue("HOTEN", hoten);
            crpview.ReportSource = obj;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbkhoa.SelectedValue == null)
            {
                return;
            }
            if (cmbkhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbkhoa.SelectedValue.ToString();

            if ((cmbkhoa.SelectedIndex != Program.mChinhanh) && (cmbkhoa.SelectedIndex != 2))
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
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                masv = ((DataRowView)bdssv[bdssv.Position])["MASV"].ToString();

            }   
        }

        private void cmbmasv_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < bdssv.Count; i++)
                {
                    if (cmbmasv.Text == ((DataRowView)bdssv[i])["MASV"].ToString())
                    {
                        masv = ((DataRowView)bdssv[i])["MASV"].ToString();
                        hoten = (((DataRowView)bdssv[i])["HO"].ToString() + " " + ((DataRowView)bdssv[i])["TEN"].ToString());
                    }
                }

            }
            catch (Exception ex)
            {
            }
        }

    }
}
