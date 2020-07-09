using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }
        
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDangNhap));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FormDangNhap f = new FormDangNhap();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnGiaoVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormLop));
            if (frm != null) frm.Activate();
            else
            {
                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Bạn chưa đăng nhập", " ", MessageBoxButtons.OK);
                    return;
                }
                if (Program.mGroup == "PKeToan")
                {
                    MessageBox.Show("Bạn không có quyền vào module này", " ", MessageBoxButtons.OK);
                    return;
                }
                FormLop f = new FormLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnMonhoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormMonhoc));
            if (frm != null) frm.Activate();
            else
            {
                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Bạn chưa đăng nhập", " ", MessageBoxButtons.OK);
                    return;
                }
                if (Program.mGroup == "PKeToan")
                {
                    MessageBox.Show("Bạn không có quyền vào module này", " ", MessageBoxButtons.OK);
                    return;
                }
                FormMonhoc f = new FormMonhoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTaoTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormTTK));
            if (frm != null) frm.Activate();
            else
            {
                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Bạn chưa đăng nhập", " ", MessageBoxButtons.OK);
                    return;
                }
               
                FormTTK f = new FormTTK();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDiem));
            if (frm != null) frm.Activate();
            else
            {
                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Bạn chưa đăng nhập", " ", MessageBoxButtons.OK);
                    return;
                }
                if (Program.mGroup == "PKeToan")
                {
                    MessageBox.Show("Bạn không có quyền vào module này", " ", MessageBoxButtons.OK);
                    return;
                }
                FormDiem f = new FormDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Formhocphi));
            if (frm != null) frm.Activate();
            else
            {
                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Bạn chưa đăng nhập", " ", MessageBoxButtons.OK);
                    return;
                }
                if (Program.mGroup != "PKeToan")
                {
                    MessageBox.Show("Bạn không có quyền vào module này", " ", MessageBoxButtons.OK);
                    return;
                }
                Formhocphi f = new Formhocphi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(forminsv));
            if (frm != null) frm.Activate();
            else
            {
                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Bạn chưa đăng nhập", " ", MessageBoxButtons.OK);
                    return;
                }
                if (Program.mGroup == "PKeToan")
                {
                    MessageBox.Show("Bạn không có quyền vào module này", " ", MessageBoxButtons.OK);
                    return;
                }
                forminsv f = new forminsv();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Formdsthihetmon));
            if (frm != null) frm.Activate();
            else
            {
                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Bạn chưa đăng nhập", " ", MessageBoxButtons.OK);
                    return;
                }
                if (Program.mGroup == "PKeToan")
                {
                    MessageBox.Show("Bạn không có quyền vào module này", " ", MessageBoxButtons.OK);
                    return;
                }
                Formdsthihetmon f = new Formdsthihetmon();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Formbdmonhoc));
            if (frm != null) frm.Activate();
            else
            {
                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Bạn chưa đăng nhập", " ", MessageBoxButtons.OK);
                    return;
                }
                if (Program.mGroup == "PKeToan")
                {
                    MessageBox.Show("Bạn không có quyền vào module này", " ", MessageBoxButtons.OK);
                    return;
                }
                Formbdmonhoc f = new Formbdmonhoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Formphieudiem));
            if (frm != null) frm.Activate();
            else
            {
                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Bạn chưa đăng nhập", " ", MessageBoxButtons.OK);
                    return;
                }
                if (Program.mGroup == "PKeToan")
                {
                    MessageBox.Show("Bạn không có quyền vào module này", " ", MessageBoxButtons.OK);
                    return;
                }
                Formphieudiem f = new Formphieudiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Formnhapsv));
            if (frm != null) frm.Activate();
            else
            {
                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Bạn chưa đăng nhập", " ", MessageBoxButtons.OK);
                    return;
                }
                if (Program.mGroup == "PKeToan")
                {
                    MessageBox.Show("Bạn không có quyền vào module này", " ", MessageBoxButtons.OK);
                    return;
                }
                Formnhapsv f = new Formnhapsv();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Formindshocphi));
            if (frm != null) frm.Activate();
            else
            {
                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Bạn chưa đăng nhập", " ", MessageBoxButtons.OK);
                    return;
                }
                if (Program.mGroup != "PKeToan")
                {
                    MessageBox.Show("Bạn không có quyền vào module này", " ", MessageBoxButtons.OK);
                    return;
                }
                Formindshocphi f = new Formindshocphi();
                f.MdiParent = this;
                f.Show();
            }
        }

    }
}
