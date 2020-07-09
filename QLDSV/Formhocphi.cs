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
    public partial class Formhocphi : Form
    {
      
        public Formhocphi()
        {
            InitializeComponent();
        }
        TypeAssistant assistant;
        public static String masv = "";
        public static String hoten = "";
        public static String malop = "";
        public static String nienkhoa = "";
        public static int hocky = 0;
        public static int hocphi = 0;
        public static int sotiendadong = 0;
        private void Formhocphi_Load(object sender, EventArgs e)
        {
            
         
            try
            {
                txthoten.Enabled = txtmalop.Enabled = false;
                btnGhi.Enabled = btnPhuchoi.Enabled = gchp.Enabled = false;
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            
         
                cmbkhoa.DataSource = Program.bds_dspm;
                cmbkhoa.DisplayMember = "TENSITE";
                cmbkhoa.ValueMember = "TENSERVER";
                cmbkhoa.SelectedIndex = Program.mChinhanh;
               /* if (Program.mGroup == "PKeToan")
                {
                    cmbkhoa.Enabled = true;

                }*/
                cmbkhoa.Enabled = false;
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
                txthoten.Enabled = txtmalop.Enabled = false;
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
           
               // macn = ((DataRowView)bdsLop[bdsLop.Position])["MAKH"].ToString();

            }   
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        void assistant_Idled(object sender, EventArgs e)
        {
            this.Invoke(
            new MethodInvoker(() =>
            {
             
                txthoten.Text = hoten;
                txtmalop.Text = malop;
                
            }));
        }
    
        public class TypeAssistant
        {
            public event EventHandler Idled = delegate { };
            public int WaitingMilliSeconds { get; set; }
            System.Threading.Timer waitingTimer;

            public TypeAssistant(int waitingMilliSeconds = 300)
            {
                WaitingMilliSeconds = waitingMilliSeconds;
                waitingTimer = new System.Threading.Timer(p =>
                {
                    Idled(this, EventArgs.Empty);
                });
            }
            public void TextChanged()
            {
                waitingTimer.Change(WaitingMilliSeconds, System.Threading.Timeout.Infinite);
            }
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdssv.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void txtmasv_TextChanged(object sender, EventArgs e)
        {
            btnGhi.Enabled = btnPhuchoi.Enabled = gchp.Enabled = true;
            btnThoat.Enabled = cmbkhoa.Enabled = txtmalop.Enabled = txthoten.Enabled = false;
            
            int delay = 3000; //int.Parse();
            assistant = new TypeAssistant(delay);
            for (int i = 0; i < bdssv.Count; i++)
            {
           
                if (txtmasv.Text.ToString() == ((DataRowView)bdssv[i])["MASV"].ToString().Trim())
                {
                    masv = txtmasv.Text;
                    hoten = (((DataRowView)bdssv[i])["HO"].ToString() + " " + ((DataRowView)bdssv[i])["TEN"].ToString());
                    malop = ((DataRowView)bdssv[i])["MALOP"].ToString();
                    assistant.Idled += assistant_Idled;
                    assistant.TextChanged();
                }
            }
           
        }

       

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            int k = 0;
            if (gchp["colnk", 0].Value.ToString() == "" || Int32.Parse(gchp["colnk", 0].Value.ToString())==0)
            {
                MessageBox.Show("Niên khóa trống hoặc sai. Mời xem lại", "", MessageBoxButtons.OK);
                return;
                btnGhi.Enabled = btnPhuchoi.Enabled = gchp.Enabled = false;
                btnThoat.Enabled = cmbkhoa.Enabled = txtmalop.Enabled = txthoten.Enabled = true;
            }
            if (Int32.Parse(gchp["colhk", 0].Value.ToString()) == 0)
            {
                MessageBox.Show("Học kỳ sai. Mời xem lại", "", MessageBoxButtons.OK);
                return;
                btnGhi.Enabled = btnPhuchoi.Enabled = gchp.Enabled = false;
                btnThoat.Enabled = cmbkhoa.Enabled = txtmalop.Enabled = txthoten.Enabled = true;
            }
            if (masv == "")
            {
                MessageBox.Show("Không để trống mã sinh viên. Mời xem lại", "", MessageBoxButtons.OK);
                return;
                btnGhi.Enabled = btnPhuchoi.Enabled = gchp.Enabled = false;
                btnThoat.Enabled = cmbkhoa.Enabled = txtmalop.Enabled = txthoten.Enabled = true;
            }
            if (Int32.Parse(gchp["colhp", 0].Value.ToString())<=0)
            {
                MessageBox.Show("Học phí không đúng. Mời xem lại", "", MessageBoxButtons.OK);
                return;
                btnGhi.Enabled = btnPhuchoi.Enabled = gchp.Enabled = false;
                btnThoat.Enabled = cmbkhoa.Enabled = txtmalop.Enabled = txthoten.Enabled = true;
            }
            if (Int32.Parse(gchp["coltien", 0].Value.ToString()) <0)
            {
                MessageBox.Show("Số tiền không đúng. Mời xem lại", "", MessageBoxButtons.OK);
                return;
                btnGhi.Enabled = btnPhuchoi.Enabled = gchp.Enabled = false;
                btnThoat.Enabled = cmbkhoa.Enabled = txtmalop.Enabled = txthoten.Enabled = true;
            }
            nienkhoa = gchp["colnk", 0].Value.ToString();
            hocky = Int32.Parse(gchp["colhk", 0].Value.ToString());
            hocphi = Int32.Parse(gchp["colhp", 0].Value.ToString());
           sotiendadong = Int32.Parse(gchp["coltien", 0].Value.ToString());
           try
           {
               SqlDataReader myReader;
               String strLenh = "exec SP_KIEMTRAHP '" + masv + "','" + nienkhoa + "'," + hocky + "";
               myReader = Program.ExecSqlDataReader(strLenh);
               if (myReader == null) return;
               myReader.Read();
               String kq = myReader.GetString(0);

               if (kq == "CO")
               {
                   MessageBox.Show("Học phí sinh viên này có rồi", "", MessageBoxButtons.OK);
                   btnPhuchoi.Enabled = gchp.Enabled = false;
                   btnThoat.Enabled = cmbkhoa.Enabled = txtmalop.Enabled = txthoten.Enabled = true;
                   bdshocphi.Clear();
                   return;
               }
               myReader.Close();
           }
           catch (Exception ex)
           {
               MessageBox.Show("Lỗi ghi học phí.\n" + ex.Message, "", MessageBoxButtons.OK);
               btnPhuchoi.Enabled = gchp.Enabled = false;
               btnThoat.Enabled = cmbkhoa.Enabled = txtmalop.Enabled = txthoten.Enabled = true;
               return;
           }
            Program.capnhat("INSERT INTO HOCPHI(MASV,NIENKHOA,HOCKY,HOCPHI,SOTIENDADONG) VALUES('"+ masv +"','"+ nienkhoa +"',"+ hocky +","+ hocphi+","+ sotiendadong +")");
            k = 1;
            if (k == 1)
            {
                MessageBox.Show("Cập nhật thành công", "", MessageBoxButtons.OK);
            }
            btnGhi.Enabled = btnPhuchoi.Enabled = gchp.Enabled = false;
            btnThoat.Enabled = cmbkhoa.Enabled = txtmalop.Enabled = txthoten.Enabled = true;
            bdshocphi.Clear();
        }

        private void gchp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formxemhp f = new Formxemhp();
            f.Show();
        }

        private void btnPhuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtmasv.Enabled = true;
            txtmasv.Text = "";
            txthoten.Text = "";
            txtmalop.Text = "";
            bdshocphi.Clear();
        }

       
    }
}
