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
    public partial class Formdsthihetmon : Form
    {
        public Formdsthihetmon()
        {
            InitializeComponent();
        }
        String mamh = "";
        String malop = "";
        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdslop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void Formdsthihetmon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.SINHVIEN' table. You can move, or remove it, as needed.

            
            try
            {
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.DS.MONHOC);
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.DS.LOP);
       
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
                malop = ((DataRowView)bdslop[bdslop.Position])["MALOP"].ToString();
                mamh  = ((DataRowView)bdsmh[bdsmh.Position])["MAMH"].ToString();
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

                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.DS.MONHOC);
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.DS.LOP);
                malop = ((DataRowView)bdslop[bdslop.Position])["MALOP"].ToString();
                mamh = ((DataRowView)bdsmh[bdsmh.Position])["MAMH"].ToString();
       
            }   
        }

        private void btnManhinh_Click(object sender, EventArgs e)
        {
         
            dsthihetmon obj;
            obj = new dsthihetmon();
            String lenh;
            lenh = "EXEC sp_dsthihetmon'"+malop+"'";
            DataTable MyTable;
            MyTable = Program.ExecSqlDataTable(lenh, Program.connstr);
            obj.SetDataSource(MyTable);
            obj.SetParameterValue("TENLOP", cmblop.Text);
            obj.SetParameterValue("MONHOC", cmbmh.Text);
            obj.SetParameterValue("NGAYTHI", txtngaythi.Text);
            obj.SetParameterValue("LANTHI", spinEdit1.Text);
            crpview.ReportSource = obj;
        }

        private void cmblop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < bdslop.Count; i++)
                {
                    if (cmblop.Text == ((DataRowView)bdslop[i])["TENLOP"].ToString())
                    {
                        malop = ((DataRowView)bdslop[i])["MALOP"].ToString();
                    }
                }
            
            }
            catch (Exception ex)
            {
            }
        }

        private void cmbmh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < bdsmh.Count; i++)
                {
                    if (cmbmh.Text == ((DataRowView)bdsmh[i])["TENMH"].ToString())
                    {
                        mamh = ((DataRowView)bdsmh[i])["MAMH"].ToString();
                    }
                }
                mamh = ((DataRowView)bdsmh[bdsmh.Position])["MAMH"].ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
