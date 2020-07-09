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
    public partial class FormMonhoc : Form
    {
        public FormMonhoc()
        {
            InitializeComponent();
        }
        int nutlenh = 0;
        int vitri = 0;
        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_monhoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS_monhoc);

        }
        private void FormMonhoc_Load(object sender, EventArgs e)
        {
           
            try
            {
                groupBox.Enabled = false;
                btnGhi.Enabled = false;
                btnPhuchoi.Enabled = false;
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.DS_monhoc.MONHOC);
                this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dIEMTableAdapter.Fill(this.DS_monhoc.DIEM);
               // macn = ((DataRowView)bdsLop[bdsLop.Position])["MAKH"].ToString();
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

      

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "Khoa" || Program.mGroup == "PKeToan")
            {
                MessageBox.Show("Bạn không đủ quyền trên thao tác này", "", MessageBoxButtons.OK);
                return;
            }
            vitri = bds_monhoc.Position;
            groupBox.Enabled = true;
            //txtMakhoa.Enabled = false;
            bds_monhoc.AddNew();
           // txtMakhoa.Text = macn;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = cmbKhoa.Enabled = false;
            btnGhi.Enabled = btnPhuchoi.Enabled = true;
            gcmonhoc.Enabled = false;
            nutlenh = 1;
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
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.DS_monhoc.MONHOC);
                this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dIEMTableAdapter.Fill(this.DS_monhoc.DIEM);
               // macn = ((DataRowView)bdsLop[bdsLop.Position])["MAKH"].ToString();

            }   
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "Khoa" || Program.mGroup == "PKeToan")
            {
                MessageBox.Show("Bạn không đủ quyền trên thao tác này", "", MessageBoxButtons.OK);
                return;
            }
            String maMH = "";
            if (bdsdiem.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học vì có có điểm môn học này", "",
                       MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maMH = ((DataRowView)bds_monhoc[bds_monhoc.Position])["MAMH"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    bds_monhoc.RemoveCurrent();
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.DS_monhoc.MONHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.mONHOCTableAdapter.Fill(this.DS_monhoc.MONHOC);
                    bds_monhoc.Position = bds_monhoc.Find("MALOP", maMH);
                    return;
                }
            }
            if (bdsdiem.Count > 0) btnXoa.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMAMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtMAMH.Focus();
                return;
            }
            if (txtTENMH.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtTENMH.Focus();
                return;
            }
            if ((nutlenh == 1) || (txtMAMH.Text != ((DataRowView)bds_monhoc[bds_monhoc.Position])["MAMH"].ToString()))
            {
                SqlDataReader myReader;
                String strLenh = "exec SP_KIEMTRAMONHOC '" + txtMAMH.Text + "'";
                myReader = Program.ExecSqlDataReader(strLenh);
                if (myReader == null) return;
                myReader.Read();
                String kq = myReader.GetString(0);

                if (kq == "CO")
                {
                    MessageBox.Show("Mã môn học bị trùng", "", MessageBoxButtons.OK);
                    bds_monhoc.CancelEdit();
                    gcmonhoc.Enabled = true;
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = cmbKhoa.Enabled = true;
                    btnGhi.Enabled = btnPhuchoi.Enabled = false;
                    groupBox.Enabled = false;
                    nutlenh = 0;
                    return;
                }
                myReader.Close();
            }
           
            try
            {

                bds_monhoc.EndEdit();
                bds_monhoc.ResetCurrentItem();
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Update(this.DS_monhoc.MONHOC);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi danh sách lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcmonhoc.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = cmbKhoa.Enabled = true;
            btnGhi.Enabled = btnPhuchoi.Enabled = false;
            groupBox.Enabled = false; 
        }

        private void btnPhuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bds_monhoc.CancelEdit();
            if (btnThem.Enabled == false) bds_monhoc.Position = vitri;
            gcmonhoc.Enabled = true;
            groupBox.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = cmbKhoa.Enabled = true;
            btnGhi.Enabled = btnPhuchoi.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "Khoa" || Program.mGroup == "PKeToan")
            {
                MessageBox.Show("Bạn không đủ quyền trên thao tác này", "", MessageBoxButtons.OK);
                return;
            }
            
            vitri = bds_monhoc.Position;
            groupBox.Enabled = true;
            //txtMakhoa.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = cmbKhoa.Enabled = false;
            btnGhi.Enabled = btnPhuchoi.Enabled = true;
            gcmonhoc.Enabled = false;
        }

    
    }
}
