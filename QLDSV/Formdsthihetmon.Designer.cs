namespace QLDSV
{
    partial class Formdsthihetmon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.txtngaythi = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnManhinh = new System.Windows.Forms.Button();
            this.cmbmh = new System.Windows.Forms.ComboBox();
            this.bdsmh = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLDSV.DS();
            this.cmblop = new System.Windows.Forms.ComboBox();
            this.bdslop = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbkhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.crpview = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.lOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.mONHOCTableAdapter = new QLDSV.DSTableAdapters.MONHOCTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsmh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdslop)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.spinEdit1);
            this.panel1.Controls.Add(this.txtngaythi);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnManhinh);
            this.panel1.Controls.Add(this.cmbmh);
            this.panel1.Controls.Add(this.cmblop);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbkhoa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 248);
            this.panel1.TabIndex = 0;
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(645, 156);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Size = new System.Drawing.Size(188, 20);
            this.spinEdit1.TabIndex = 16;
            // 
            // txtngaythi
            // 
            this.txtngaythi.Location = new System.Drawing.Point(645, 104);
            this.txtngaythi.Name = "txtngaythi";
            this.txtngaythi.Size = new System.Drawing.Size(188, 26);
            this.txtngaythi.TabIndex = 15;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(636, 199);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 36);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnManhinh
            // 
            this.btnManhinh.Location = new System.Drawing.Point(364, 199);
            this.btnManhinh.Name = "btnManhinh";
            this.btnManhinh.Size = new System.Drawing.Size(103, 36);
            this.btnManhinh.TabIndex = 13;
            this.btnManhinh.Text = "Màn hình";
            this.btnManhinh.UseVisualStyleBackColor = true;
            this.btnManhinh.Click += new System.EventHandler(this.btnManhinh_Click);
            // 
            // cmbmh
            // 
            this.cmbmh.DataSource = this.bdsmh;
            this.cmbmh.DisplayMember = "TENMH";
            this.cmbmh.FormattingEnabled = true;
            this.cmbmh.Location = new System.Drawing.Point(249, 151);
            this.cmbmh.Name = "cmbmh";
            this.cmbmh.Size = new System.Drawing.Size(252, 27);
            this.cmbmh.TabIndex = 12;
            this.cmbmh.ValueMember = "TENMH";
            this.cmbmh.SelectedIndexChanged += new System.EventHandler(this.cmbmh_SelectedIndexChanged);
            // 
            // bdsmh
            // 
            this.bdsmh.DataMember = "MONHOC";
            this.bdsmh.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.EnforceConstraints = false;
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmblop
            // 
            this.cmblop.DataSource = this.bdslop;
            this.cmblop.DisplayMember = "TENLOP";
            this.cmblop.FormattingEnabled = true;
            this.cmblop.Location = new System.Drawing.Point(249, 98);
            this.cmblop.Name = "cmblop";
            this.cmblop.Size = new System.Drawing.Size(252, 27);
            this.cmblop.TabIndex = 11;
            this.cmblop.ValueMember = "TENLOP";
            this.cmblop.SelectedIndexChanged += new System.EventHandler(this.cmblop_SelectedIndexChanged);
            // 
            // bdslop
            // 
            this.bdslop.DataMember = "LOP";
            this.bdslop.DataSource = this.DS;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(576, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lần thi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên môn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(566, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày thi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên lớp";
            // 
            // cmbkhoa
            // 
            this.cmbkhoa.FormattingEnabled = true;
            this.cmbkhoa.Location = new System.Drawing.Point(364, 47);
            this.cmbkhoa.Name = "cmbkhoa";
            this.cmbkhoa.Size = new System.Drawing.Size(284, 27);
            this.cmbkhoa.TabIndex = 2;
            this.cmbkhoa.SelectedIndexChanged += new System.EventHandler(this.cmbkhoa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khoa,phòng ban";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH THI HẾT MÔN";
            // 
            // crpview
            // 
            this.crpview.ActiveViewIndex = -1;
            this.crpview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpview.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpview.Location = new System.Drawing.Point(0, 248);
            this.crpview.Name = "crpview";
            this.crpview.Size = new System.Drawing.Size(1370, 501);
            this.crpview.TabIndex = 1;
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
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // Formdsthihetmon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.crpview);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Formdsthihetmon";
            this.Text = "Formdsthihetmon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Formdsthihetmon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsmh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdslop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbkhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpview;
        private DS DS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.ComboBox cmbmh;
        private System.Windows.Forms.BindingSource bdsmh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnManhinh;
        private System.Windows.Forms.ComboBox cmblop;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource bdslop;
        private System.Windows.Forms.TextBox txtngaythi;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
    }
}