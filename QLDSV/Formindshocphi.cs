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
    public partial class Formindshocphi : Form
    {
        public Formindshocphi()
        {
            InitializeComponent();
        }
        String malop = "";
        String nienkhoa = "";
        Int32 hocky = 0;
        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdssv.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }
        private void Formindshocphi_Load(object sender, EventArgs e)
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
               /* if (Program.mGroup == "PGV")
                {
                    cmbkhoa.Enabled = true;

                }
                else cmbkhoa.Enabled = false;*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
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

            if ((cmbkhoa.SelectedIndex != Program.mChinhanh))
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
            }   
        }

   

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnmanhinh_Click(object sender, EventArgs e)
        {
            hocky = Int32.Parse(txthk.Text);
            nienkhoa = txtnk.Text;
            malop = txtmalop.Text;
            Danhsachhocphi obj;
            obj = new Danhsachhocphi();
            String lenh;
            lenh = "EXEC sp_danhsachhocphi'" + malop + "','" + nienkhoa + "'," + hocky + "";
            DataTable MyTable;
            MyTable = Program.ExecSqlDataTable(lenh, Program.connstr);
            obj.SetDataSource(MyTable);
            obj.SetParameterValue("MALOP", txtmalop.Text);
            obj.SetParameterValue("NIENKHOA", txtnk.Text);
            obj.SetParameterValue("HOCKY", txthk.Text);
            crpview.ReportSource = obj;
        }

        private void txtmalop_TextChanged(object sender, EventArgs e)
        {
            /*try
            {
                for (int i = 0; i < bdssv.Count; i++)
                {
                    if (txtmalop.Text == ((DataRowView)bdssv[i])["MALOP"].ToString())
                    {
                        malop = ((DataRowView)bdssv[i])["MALOP"].ToString();
                    }
                }

            }
            catch (Exception ex)
            {
            }*/
        }

      
    }
}
