using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLDSV
{
    public partial class FormLop : Form
    {
        int vitri = 0;
        string macn = "";
        int nutlenh = 0;
        public FormLop()
        {
            InitializeComponent();
        }


        private void lOPBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdslop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormLop_Load(object sender, EventArgs e)
        {
      
           
            try
            {
                groupBox1.Enabled = false;
                btnGhi.Enabled = false;
                btnPhuchoi.Enabled = false;
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.DS.LOP);
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
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
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới hoặc không có quyền vào chi nhánh", "", MessageBoxButtons.OK);
                return;
            }
               
            else
            {
                try
                {
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Fill(this.DS.LOP);
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);

                    macn = ((DataRowView)bdslop[bdslop.Position])["MAKH"].ToString();
                }
                catch (Exception ex)
                {
                }
             
            }   
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "Khoa" || Program.mGroup == "PKeToan")
            {
                MessageBox.Show("Bạn không đủ quyền trên thao tác này","",MessageBoxButtons.OK);
                return;
            }
          
            vitri = bdslop.Position;
            groupBox1.Enabled = true;
            txtMakhoa.Enabled = false;
            bdslop.AddNew();
            txtMakhoa.Text = macn;
            nutlenh = 1;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = cmbKhoa.Enabled = false;
            btnGhi.Enabled = btnPhuchoi.Enabled = true;
            gclop.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMalop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtMalop.Focus();
                return;
            }
            if (txtTenlop.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtTenlop.Focus();
                return;
            }
            if (txtMakhoa.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được thiếu!", "", MessageBoxButtons.OK);
                txtMakhoa.Focus();
                return;
            }
            if ((nutlenh == 1) || (txtMalop.Text != ((DataRowView)bdslop[bdslop.Position])["MALOP"].ToString()))
            {
                SqlDataReader myReader;
                String strLenh = "exec SP_KIEMTRALOP '" + txtMalop.Text + "'";
                myReader = Program.ExecSqlDataReader(strLenh);
                if (myReader == null) return;
                myReader.Read();
                String kq = myReader.GetString(0);

                if (kq == "CO")
                {
                    MessageBox.Show("Mã lớp bị trùng", "", MessageBoxButtons.OK);
                    bdslop.CancelEdit();
                    gclop.Enabled = true;
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = cmbKhoa.Enabled = true;
                    btnGhi.Enabled = btnPhuchoi.Enabled = false;
                    groupBox1.Enabled = false;
                    nutlenh = 0;
                    return;
                }
                myReader.Close();
            }
            
            try
            {
                
                bdslop.EndEdit();
                bdslop.ResetCurrentItem();
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Update(this.DS.LOP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi danh sách lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
           
            gclop.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = cmbKhoa.Enabled = true;
            btnGhi.Enabled = btnPhuchoi.Enabled = false;
            groupBox1.Enabled = false; 
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "Khoa" || Program.mGroup == "PKeToan")
            {
                MessageBox.Show("Bạn không đủ quyền trên thao tác này", "", MessageBoxButtons.OK);
                return;
            }
            vitri = bdslop.Position;
            groupBox1.Enabled = true;
            txtMakhoa.Enabled  = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = cmbKhoa.Enabled = false;
            btnGhi.Enabled = btnPhuchoi.Enabled = true;
            gclop.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "Khoa" || Program.mGroup == "PKeToan")
            {
                MessageBox.Show("Bạn không đủ quyền trên thao tác này", "", MessageBoxButtons.OK);
                return;
            }
            String malop = "";
            if (bdssv.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp này vì đã có sinh viên", "",
                       MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    malop = ((DataRowView)bdslop[bdslop.Position])["MALOP"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    bdslop.RemoveCurrent();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.DS.LOP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.lOPTableAdapter.Fill(this.DS.LOP);
                    bdslop.Position = bdslop.Find("MALOP", malop);
                    return;
                }
            }

            if (bdslop.Count == 0) btnXoa.Enabled = false;
        }

        private void btnPhuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdslop.CancelEdit();
            if (btnThem.Enabled == false) bdslop.Position = vitri;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = cmbKhoa.Enabled = true;
            btnGhi.Enabled = btnPhuchoi.Enabled = false;
            gclop.Enabled = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

      

    }
}
