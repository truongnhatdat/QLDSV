namespace QLDSV
{
    partial class forminsv
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tENLOPLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbtenlop = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLDSV.DS();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnmanhinh = new System.Windows.Forms.Button();
            this.txtmalop = new DevExpress.XtraEditors.TextEdit();
            this.bdslop = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.crptView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            tENLOPLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmalop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdslop)).BeginInit();
            this.SuspendLayout();
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(515, 51);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(69, 21);
            tENLOPLabel.TabIndex = 1;
            tENLOPLabel.Text = "Tên lớp";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbtenlop);
            this.panel1.Controls.Add(this.cmbKhoa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnthoat);
            this.panel1.Controls.Add(this.btnmanhinh);
            this.panel1.Controls.Add(this.txtmalop);
            this.panel1.Controls.Add(tENLOPLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 152);
            this.panel1.TabIndex = 0;
            // 
            // cmbtenlop
            // 
            this.cmbtenlop.DataSource = this.lOPBindingSource;
            this.cmbtenlop.DisplayMember = "TENLOP";
            this.cmbtenlop.FormattingEnabled = true;
            this.cmbtenlop.Location = new System.Drawing.Point(605, 51);
            this.cmbtenlop.Name = "cmbtenlop";
            this.cmbtenlop.Size = new System.Drawing.Size(250, 29);
            this.cmbtenlop.TabIndex = 10;
            this.cmbtenlop.ValueMember = "TENLOP";
            this.cmbtenlop.SelectedIndexChanged += new System.EventHandler(this.cmbtenlop_SelectedIndexChanged);
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.EnforceConstraints = false;
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(242, 48);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(241, 29);
            this.cmbKhoa.TabIndex = 9;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã khoa,phòng ban";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(648, 102);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(117, 31);
            this.btnthoat.TabIndex = 7;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnmanhinh
            // 
            this.btnmanhinh.Location = new System.Drawing.Point(289, 103);
            this.btnmanhinh.Name = "btnmanhinh";
            this.btnmanhinh.Size = new System.Drawing.Size(117, 31);
            this.btnmanhinh.TabIndex = 5;
            this.btnmanhinh.Text = "Màn hình";
            this.btnmanhinh.UseVisualStyleBackColor = true;
            this.btnmanhinh.Click += new System.EventHandler(this.btnmanhinh_Click);
            // 
            // txtmalop
            // 
            this.txtmalop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdslop, "MALOP", true));
            this.txtmalop.Enabled = false;
            this.txtmalop.Location = new System.Drawing.Point(889, 58);
            this.txtmalop.Name = "txtmalop";
            this.txtmalop.Size = new System.Drawing.Size(111, 20);
            this.txtmalop.TabIndex = 4;
            // 
            // bdslop
            // 
            this.bdslop.DataMember = "LOP";
            this.bdslop.DataSource = this.DS;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "IN DANH SÁCH SINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // crptView
            // 
            this.crptView.ActiveViewIndex = -1;
            this.crptView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptView.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crptView.Location = new System.Drawing.Point(0, 152);
            this.crptView.Name = "crptView";
            this.crptView.Size = new System.Drawing.Size(965, 597);
            this.crptView.TabIndex = 1;
            // 
            // forminsv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 749);
            this.Controls.Add(this.crptView);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "forminsv";
            this.Text = "phieuinsinhvien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.phieuinsinhvien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmalop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdslop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DS DS;
        private System.Windows.Forms.BindingSource bdslop;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnmanhinh;
        private DevExpress.XtraEditors.TextEdit txtmalop;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptView;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbtenlop;
        private System.Windows.Forms.BindingSource lOPBindingSource;
    }
}