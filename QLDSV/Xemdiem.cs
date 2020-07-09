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
    public partial class Formxemdiem : Form
    {
        public Formxemdiem()
        {
            InitializeComponent();
        }
        int vitri = 0;
        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.BDSLOP.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }
        private void Xemdiem_Load(object sender, EventArgs e)
        {
        
            try
            {
                
                groupBox1.Enabled = txtmasv.Enabled = txtmamh.Enabled = false;
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                // TODO: This line of code loads data into the 'DS.LOP' table. You can move, or remove it, as needed.
                this.lOPTableAdapter.Fill(this.DS.LOP);
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dIEMTableAdapter.Fill(this.DS.DIEM);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }



        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    // malop = ((DataRowView)bdslop[bdslop.Position])["MALOP"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    vitri = bdsdiem.Position;
                    bdsdiem.RemoveCurrent();
                    this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dIEMTableAdapter.Update(this.DS.DIEM);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa điểm. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.dIEMTableAdapter.Fill(this.DS.DIEM);
                    //bdslop.Position = bdslop.Find("MALOP", malop);
                    return;
                }
            }
           
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsdiem.Position;
            groupBox1.Enabled = btnghi.Enabled = btnquaylai.Enabled = true;
            btnsua.Enabled = btnXoa.Enabled = btnthoat.Enabled = btnload.Enabled = false;
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                bdsdiem.EndEdit();
                bdsdiem.ResetCurrentItem();
                this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dIEMTableAdapter.Update(this.DS.DIEM);
                this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dIEMTableAdapter.Fill(this.DS.DIEM);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi danh sách lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            btnXoa.Enabled = btnsua.Enabled = btnthoat.Enabled = btnload.Enabled = true;
            btnghi.Enabled = btnquaylai.Enabled = groupBox1.Enabled = false;
        }

        private void barButtonItem1_ItemClick_2(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsdiem.CancelEdit();
            vitri = bdsdiem.Position;
            btnXoa.Enabled = btnsua.Enabled = btnthoat.Enabled = btnload.Enabled = true;
            btnghi.Enabled = btnquaylai.Enabled = groupBox1.Enabled = false;
        }

        private void barButtonItem1_ItemClick_3(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                groupBox1.Enabled = txtmasv.Enabled = txtmamh.Enabled = false;
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                // TODO: This line of code loads data into the 'DS.LOP' table. You can move, or remove it, as needed.
                this.lOPTableAdapter.Fill(this.DS.LOP);
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dIEMTableAdapter.Fill(this.DS.DIEM);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
