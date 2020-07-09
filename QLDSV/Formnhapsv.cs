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
    public partial class Formnhapsv : Form
    {
        public Formnhapsv()
        {
            InitializeComponent();
        }
        public static int vitri = 0;
        DateTime ngaysinh;
        int nutlenh = 0;
        int phai = 0;
        int nghihoc = 0;
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

                    //macn = ((DataRowView)bdslop[bdslop.Position])["MAKH"].ToString();
                }
                catch (Exception ex)
                {
                }

            }   
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdslop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void Formnhapsv_Load(object sender, EventArgs e)
        {
          
            try
            {
                
                txtmlchuyen.Enabled = false;
                panelControl3.Enabled = false;
                btnGhi.Enabled = btnPhuchoi.Enabled = false;
                btnxnchuyen.Enabled = false;
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.DS.LOP);
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
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

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
            panelControl3.Enabled = true;
            if (Program.mGroup == "Khoa" || Program.mGroup == "PKeToan")
            {
                MessageBox.Show("Bạn không đủ quyền trên thao tác này", "", MessageBoxButtons.OK);
                return;
            }
            vitri = bdslop.Position;
            txtmalop.Enabled = false;
            bdssv.AddNew();
            txtmalop.Text = ((DataRowView)bdslop[bdslop.Position])["MALOP"].ToString();
           
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnchuyen.Enabled = false;
            btnGhi.Enabled = btnPhuchoi.Enabled = true;
            nutlenh = 1;
           // panelControl3.Enabled = false;
        }

        private void ghiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (txtmalop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtmalop.Focus();
                return;
            }
            if (txtho.Text.Trim() == "")
            {
                MessageBox.Show("Họ không được thiếu!", "", MessageBoxButtons.OK);
                txtho.Focus();
                return;
            }
            if (txtmasv.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được thiếu!", "", MessageBoxButtons.OK);
                txtmasv.Focus();
                return;
            }
            if (txtten.Text.Trim() == "")
            {
                MessageBox.Show("Tên sinh viên không được thiếu!", "", MessageBoxButtons.OK);
                txtten.Focus();
                return;
            }
            if (txtns.Text.Trim() == "")
            {
                MessageBox.Show("Ngày sinh không được thiếu!", "", MessageBoxButtons.OK);
                txtns.Focus();
                return;
            }
            if (txtnoisinh.Text.Trim() == "")
            {
                MessageBox.Show("Nơi sinh không được thiếu!", "", MessageBoxButtons.OK);
                txtnoisinh.Focus();
                return;
            }
            if (txtdiachi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được thiếu!", "", MessageBoxButtons.OK);
                txtdiachi.Focus();
                return;
            }
            if ((nutlenh == 1) || (txtmasv.Text != ((DataRowView)bdssv[bdssv.Position])["MASV"].ToString()))
            {
                try
                {
                    SqlDataReader myReader;
                    String strLenh = "exec SP_KIEMTRAMASV '" + txtmasv.Text + "'";
                    myReader = Program.ExecSqlDataReader(strLenh);
                    if (myReader == null) return;
                    myReader.Read();
                    String kq = myReader.GetString(0);

                    if (kq == "CO")
                    {
                        MessageBox.Show("Mã sinh viên bị trùng", "", MessageBoxButtons.OK);
                        bdssv.CancelEdit();
                        btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnchuyen.Enabled = true;
                        btnGhi.Enabled = btnPhuchoi.Enabled = false;
                        panelControl3.Enabled = false;
                        nutlenh = 0;
                        return;
                    }
                    myReader.Close();
                }
                catch (Exception ex)
                {
                }
                
            }
            try
            {

                bdssv.EndEdit();
                bdssv.ResetCurrentItem();
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Update(this.DS.SINHVIEN);
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.DS.LOP);
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi danh sách sinh viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnchuyen.Enabled = true;
            btnGhi.Enabled = btnPhuchoi.Enabled = false;
            panelControl3.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            panelControl3.Enabled = true;
            if (Program.mGroup == "Khoa" || Program.mGroup == "PKeToan")
            {
                MessageBox.Show("Bạn không đủ quyền trên thao tác này", "", MessageBoxButtons.OK);
                return;
            }
         
            vitri = bdslop.Position;
            txtmalop.Enabled = txtmlchuyen.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnchuyen.Enabled = false;
            btnGhi.Enabled = btnPhuchoi.Enabled = true;
            nutlenh = 2;
            //panelControl3.Enabled = false;
        }

        private void btnPhuchoi_Click(object sender, EventArgs e)
        {
            bdssv.CancelEdit();
            if (btnThem.Enabled == false) bdssv.Position = vitri;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnchuyen.Enabled = true;
            btnGhi.Enabled = btnPhuchoi.Enabled = false;
            panelControl3.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            panelControl3.Enabled = true;
            if (Program.mGroup == "Khoa" || Program.mGroup == "PKeToan")
            {
                MessageBox.Show("Bạn không đủ quyền trên thao tác này", "", MessageBoxButtons.OK);
                return;
            }
            
            String masv = "";
            if (bdshp.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên này vì đã đóng học phí", "",
                       MessageBoxButtons.OK);
                return;
            }
            if (bdsdiem.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên này vì đã có điểm", "",
                       MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    masv = ((DataRowView)bdssv[bdssv.Position])["MASV"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    bdssv.RemoveCurrent();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.DS.SINHVIEN);
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Fill(this.DS.LOP);
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                    bdssv.Position = bdssv.Find("MALOP", masv);
                    return;
                }
            }
            if (bdsdiem.Count > 0 || bdshp.Count > 0) btnXoa.Enabled = false;
            panelControl3.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnchuyen_Click(object sender, EventArgs e)
        {
            panelControl3.Enabled = true;
            txtmlchuyen.Enabled = true;
            btnGhi.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnThoat.Enabled = btnchuyen.Enabled = false;
            btnPhuchoi.Enabled = btnxnchuyen.Enabled = true;
        }

        private void xácNhậnChuyểnToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            SqlDataReader myReader;
            String strLenh = "exec SP_KIEMTRALOP '" + txtmlchuyen.Text + "'";
            myReader = Program.ExecSqlDataReader(strLenh);
            if (myReader == null) return;
            myReader.Read();
            String kq = myReader.GetString(0);

            if (kq == "KHONG")
            {
                MessageBox.Show("Không có lớp cần chuyển", "", MessageBoxButtons.OK);
                return;
            }
            myReader.Close();

            if (ckphai.Checked)
            {
                phai = 1;
            }
          

            if (cknh.Checked)
            {
                nghihoc = 1;
            }
    
            ngaysinh = txtns.DateTime;
            //String masvm = txtmasv.Text;
            String ho = txtho.Text;
            String ten = txtten.Text;
            String noisinh = txtnoisinh.Text;
            String dc = txtdiachi.Text;
            String ghichu = txtgc.Text;
            String masv = ((DataRowView)bdssv[bdssv.Position])["MASV"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
            bdssv.RemoveCurrent();
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Update(this.DS.SINHVIEN);
            String Lenh = "sp_chuyenlop";
             Program.chuyenlop(Lenh,txtmlchuyen.Text,masv,ho,ten,phai,ngaysinh,noisinh,dc,ghichu,nghihoc);
             this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
             this.lOPTableAdapter.Fill(this.DS.LOP);
             this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
             this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
             panelControl3.Enabled = false;
             btnThem.Enabled = btnThoat.Enabled = btnSua.Enabled = btnThoat.Enabled = btnchuyen.Enabled = true;
             btnxnchuyen.Enabled = btnGhi.Enabled = btnPhuchoi.Enabled = false;
        }
    }
}
