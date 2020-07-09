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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVDataSet.V_DS_PHANMANH);
            tENSITEComboBox.SelectedIndex = 1;
            tENSITEComboBox.SelectedIndex = 2;

        }

        private void tENSITEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tENSITEComboBox.SelectedValue != null)
                Program.servername = tENSITEComboBox.SelectedValue.ToString();



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản đăng nhập không được rỗng", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txtLogin.Focus();
                return;
            }
            Program.mlogin = txtLogin.Text;
            Program.password = txtPass.Text;

            if (Program.KetNoi() == 0)
            {
                return;
            }
            else
            {
                //MessageBox.Show("Đăng nhập thành công"," ",MessageBoxButtons.OK);

                SqlDataReader myReader;
                Program.mChinhanh = tENSITEComboBox.SelectedIndex;
                Program.bds_dspm = bds_DSPM;

                Program.mloginDN = Program.mlogin;
                Program.passwordDN = Program.password;

                String strLenh = "exec SP_DANGNHAP '" + Program.mlogin + "'";
                myReader = Program.ExecSqlDataReader(strLenh);
                if (myReader == null) return;
                myReader.Read();
                Program.username = myReader.GetString(0);     // Lay user name
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username của cơ sở dữ liệu", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mHoten = myReader.GetString(1);
                Program.mGroup = myReader.GetString(2);

                myReader.Close();
                Program.conn.Close();

                Program.FormChinh.MaNV.Text = "User : " + Program.username;
                Program.FormChinh.HOTEN.Text = "Login : " + Program.mHoten;
                Program.FormChinh.NHOM.Text = "Nhóm : " + Program.mGroup;

                //FormLop.ActiveForm.Close();
            }


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FormLop.ActiveForm.Close();
            Close();

        }
    }
}
