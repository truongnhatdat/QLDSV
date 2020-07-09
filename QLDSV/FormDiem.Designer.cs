namespace QLDSV
{
    partial class FormDiem
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label mAMHLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnbd = new DevExpress.XtraBars.BarButtonItem();
            this.btnghi = new DevExpress.XtraBars.BarButtonItem();
            this.btnxem = new DevExpress.XtraBars.BarButtonItem();
            this.btnphuchoi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.spLT = new DevExpress.XtraEditors.SpinEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMM = new System.Windows.Forms.ComboBox();
            this.DS = new QLDSV.DS();
            this.cmbmalop = new System.Windows.Forms.ComboBox();
            this.cmbkhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bdsmonhoc = new System.Windows.Forms.BindingSource(this.components);
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.mONHOCTableAdapter = new QLDSV.DSTableAdapters.MONHOCTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gcdiem = new System.Windows.Forms.DataGridView();
            this.colmasv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colhoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsnhapdiem = new System.Windows.Forms.BindingSource(this.components);
            this.bdssv = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new QLDSV.DSTableAdapters.SINHVIENTableAdapter();
            this.bdsdiem = new System.Windows.Forms.BindingSource(this.components);
            this.dIEMTableAdapter = new QLDSV.DSTableAdapters.DIEMTableAdapter();
            mALOPLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spLT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsmonhoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcdiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsnhapdiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdssv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsdiem)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(74, 122);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(53, 19);
            mALOPLabel.TabIndex = 2;
            mALOPLabel.Text = "Mã lớp";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(304, 123);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(86, 19);
            mAMHLabel.TabIndex = 4;
            mAMHLabel.Text = "Mã môn học";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThoat,
            this.btnbd,
            this.btnghi,
            this.btnxem,
            this.btnphuchoi,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnbd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnghi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnxem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnphuchoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Glyph = global::QLDSV.Properties.Resources.Exit_24_icon;
            this.btnThoat.Id = 0;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // btnbd
            // 
            this.btnbd.Caption = "Bắt đầu";
            this.btnbd.Glyph = global::QLDSV.Properties.Resources.Custom_Icon_Design_Flatastic_9_Start;
            this.btnbd.Id = 1;
            this.btnbd.Name = "btnbd";
            this.btnbd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnghi
            // 
            this.btnghi.Caption = "Ghi điểm";
            this.btnghi.Glyph = global::QLDSV.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_mail_mark_task;
            this.btnghi.Id = 2;
            this.btnghi.Name = "btnghi";
            this.btnghi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnxem
            // 
            this.btnxem.Caption = "Xem điểm";
            this.btnxem.Glyph = global::QLDSV.Properties.Resources.Inipagi_Job_Seeker_List;
            this.btnxem.Id = 3;
            this.btnxem.Name = "btnxem";
            this.btnxem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnxem_ItemClick);
            // 
            // btnphuchoi
            // 
            this.btnphuchoi.Caption = "Phục hồi";
            this.btnphuchoi.Glyph = global::QLDSV.Properties.Resources.Button_Refresh_icon_24;
            this.btnphuchoi.Id = 4;
            this.btnphuchoi.Name = "btnphuchoi";
            this.btnphuchoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnphuchoi_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Nhập từng sinh viên";
            this.barButtonItem1.Glyph = global::QLDSV.Properties.Resources.Actions_list_add_user_icon_24;
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1370, 69);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 726);
            this.barDockControlBottom.Size = new System.Drawing.Size(1370, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 69);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 657);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1370, 69);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 657);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.spLT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(mAMHLabel);
            this.panel1.Controls.Add(this.cmbMM);
            this.panel1.Controls.Add(mALOPLabel);
            this.panel1.Controls.Add(this.cmbmalop);
            this.panel1.Controls.Add(this.cmbkhoa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 218);
            this.panel1.TabIndex = 9;
            // 
            // spLT
            // 
            this.spLT.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spLT.Location = new System.Drawing.Point(649, 120);
            this.spLT.MenuManager = this.barManager1;
            this.spLT.Name = "spLT";
            this.spLT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spLT.Size = new System.Drawing.Size(100, 20);
            this.spLT.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lần thi";
            // 
            // cmbMM
            // 
            this.cmbMM.DataSource = this.DS;
            this.cmbMM.DisplayMember = "MONHOC.MAMH";
            this.cmbMM.FormattingEnabled = true;
            this.cmbMM.Location = new System.Drawing.Point(407, 120);
            this.cmbMM.Name = "cmbMM";
            this.cmbMM.Size = new System.Drawing.Size(121, 27);
            this.cmbMM.TabIndex = 5;
            this.cmbMM.ValueMember = "MONHOC.TENMH";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.EnforceConstraints = false;
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbmalop
            // 
            this.cmbmalop.DataSource = this.DS;
            this.cmbmalop.DisplayMember = "LOP.MALOP";
            this.cmbmalop.FormattingEnabled = true;
            this.cmbmalop.Location = new System.Drawing.Point(147, 119);
            this.cmbmalop.Name = "cmbmalop";
            this.cmbmalop.Size = new System.Drawing.Size(121, 27);
            this.cmbmalop.TabIndex = 3;
            this.cmbmalop.ValueMember = "LOP.TENLOP";
            this.cmbmalop.SelectedIndexChanged += new System.EventHandler(this.cmbmalop_SelectedIndexChanged);
            // 
            // cmbkhoa
            // 
            this.cmbkhoa.FormattingEnabled = true;
            this.cmbkhoa.Location = new System.Drawing.Point(259, 40);
            this.cmbkhoa.Name = "cmbkhoa";
            this.cmbkhoa.Size = new System.Drawing.Size(288, 27);
            this.cmbkhoa.TabIndex = 1;
            this.cmbkhoa.SelectedIndexChanged += new System.EventHandler(this.cmbkhoa_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoa";
            // 
            // bdsmonhoc
            // 
            this.bdsmonhoc.DataMember = "MONHOC";
            this.bdsmonhoc.DataSource = this.DS;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.DS;
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
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gcdiem);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1370, 439);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // gcdiem
            // 
            this.gcdiem.AutoGenerateColumns = false;
            this.gcdiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gcdiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gcdiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmasv,
            this.colhoten,
            this.coldiem});
            this.gcdiem.DataSource = this.bdsnhapdiem;
            this.gcdiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcdiem.Location = new System.Drawing.Point(3, 22);
            this.gcdiem.Name = "gcdiem";
            this.gcdiem.Size = new System.Drawing.Size(1364, 220);
            this.gcdiem.TabIndex = 0;
            // 
            // colmasv
            // 
            this.colmasv.DataPropertyName = "MASV";
            this.colmasv.HeaderText = "MASV";
            this.colmasv.Name = "colmasv";
            // 
            // colhoten
            // 
            this.colhoten.DataPropertyName = "HOTEN";
            this.colhoten.HeaderText = "HOTEN";
            this.colhoten.Name = "colhoten";
            // 
            // coldiem
            // 
            this.coldiem.DataPropertyName = "diem";
            this.coldiem.HeaderText = "diem";
            this.coldiem.Name = "coldiem";
            // 
            // bdsnhapdiem
            // 
            this.bdsnhapdiem.DataSource = typeof(QLDSV.BANGDIEM);
            // 
            // bdssv
            // 
            this.bdssv.DataMember = "SINHVIEN";
            this.bdssv.DataSource = this.DS;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // bdsdiem
            // 
            this.bdsdiem.DataMember = "DIEM";
            this.bdsdiem.DataSource = this.DS;
            // 
            // dIEMTableAdapter
            // 
            this.dIEMTableAdapter.ClearBeforeFill = true;
            // 
            // FormDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDiem";
            this.Text = "FormDiem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spLT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsmonhoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcdiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsnhapdiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdssv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsdiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnbd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbkhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdsLop;
        private DS DS;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsmonhoc;
        private System.Windows.Forms.ComboBox cmbMM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SpinEdit spLT;
        private System.Windows.Forms.ComboBox cmbmalop;
        private System.Windows.Forms.BindingSource bdsnhapdiem;
        private System.Windows.Forms.DataGridView gcdiem;
        private System.Windows.Forms.BindingSource bdssv;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnghi;
        private DevExpress.XtraBars.BarButtonItem btnxem;
        private DevExpress.XtraBars.BarButtonItem btnphuchoi;
        private System.Windows.Forms.BindingSource bdsdiem;
        private DSTableAdapters.DIEMTableAdapter dIEMTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmasv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colhoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldiem;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}