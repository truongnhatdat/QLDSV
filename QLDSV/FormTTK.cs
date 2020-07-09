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
    public partial class FormTTK : Form
    {
        public FormTTK()
        {
            InitializeComponent();
            cmbTenNhom.SelectedIndex = 0;
        }
        
        private void btnTTK_Click(object sender, EventArgs e)
        {
            
            if (Program.mGroup == "PGV")
            {
                String strlenh = "sp_taotaikhoan";
                Program.taotaikhoan(strlenh, txtTenDN.Text, txtMK.Text, txtUser.Text,cmbTenNhom.Text);
                return;
            }
            if (Program.mGroup == "Khoa")
            {
                if (cmbTenNhom.Text == "Khoa")
                {
                    String strlenh = "sp_taotaikhoan";
                    Program.taotaikhoan(strlenh, txtTenDN.Text, txtMK.Text, txtUser.Text, cmbTenNhom.Text);
                    return;
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền tạo tài khoản nhóm này", "", MessageBoxButtons.OK);
                }
            }
            if(Program.mGroup == "PKeToan")
            {
                if (cmbTenNhom.Text == "PKeToan")
                {
                    String strlenh = "sp_taotaikhoan";
                    Program.taotaikhoan(strlenh, txtTenDN.Text, txtMK.Text, txtUser.Text, cmbTenNhom.Text);
                    return;
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền tạo tài khoản nhóm này", "", MessageBoxButtons.OK);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
