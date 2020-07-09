namespace QLDSV
{
    partial class Formphieudiem
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
            System.Windows.Forms.Label mASVLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbmasv = new System.Windows.Forms.ComboBox();
            this.bdssv = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLDSV.DS();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxem = new System.Windows.Forms.Button();
            this.cmbkhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sINHVIENTableAdapter = new QLDSV.DSTableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.crpview = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            mASVLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdssv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(474, 49);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(85, 19);
            mASVLabel.TabIndex = 3;
            mASVLabel.Text = "Mã sinh viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbmasv);
            this.panel1.Controls.Add(this.btnthoat);
            this.panel1.Controls.Add(this.btnxem);
            this.panel1.Controls.Add(mASVLabel);
            this.panel1.Controls.Add(this.cmbkhoa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 156);
            this.panel1.TabIndex = 0;
            // 
            // cmbmasv
            // 
            this.cmbmasv.DataSource = this.bdssv;
            this.cmbmasv.DisplayMember = "MASV";
            this.cmbmasv.FormattingEnabled = true;
            this.cmbmasv.Location = new System.Drawing.Point(606, 49);
            this.cmbmasv.Name = "cmbmasv";
            this.cmbmasv.Size = new System.Drawing.Size(251, 27);
            this.cmbmasv.TabIndex = 7;
            this.cmbmasv.ValueMember = "MASV";
            this.cmbmasv.SelectedIndexChanged += new System.EventHandler(this.cmbmasv_SelectedIndexChanged);
            // 
            // bdssv
            // 
            this.bdssv.DataMember = "SINHVIEN";
            this.bdssv.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.EnforceConstraints = false;
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(635, 100);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(112, 30);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxem
            // 
            this.btnxem.Location = new System.Drawing.Point(289, 101);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(112, 30);
            this.btnxem.TabIndex = 5;
            this.btnxem.Text = "Màn hình";
            this.btnxem.UseVisualStyleBackColor = true;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // cmbkhoa
            // 
            this.cmbkhoa.FormattingEnabled = true;
            this.cmbkhoa.Location = new System.Drawing.Point(189, 44);
            this.cmbkhoa.Name = "cmbkhoa";
            this.cmbkhoa.Size = new System.Drawing.Size(251, 27);
            this.cmbkhoa.TabIndex = 2;
            this.cmbkhoa.SelectedIndexChanged += new System.EventHandler(this.cmbkhoa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khoa,phòng ban";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU ĐIỂM SINH VIÊN";
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // crpview
            // 
            this.crpview.ActiveViewIndex = -1;
            this.crpview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpview.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpview.Location = new System.Drawing.Point(0, 156);
            this.crpview.Name = "crpview";
            this.crpview.Size = new System.Drawing.Size(1370, 519);
            this.crpview.TabIndex = 1;
            // 
            // Formphieudiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 675);
            this.Controls.Add(this.crpview);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Formphieudiem";
            this.Text = "Formphieudiem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Formphieudiem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdssv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbkhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxem;
        private DS DS;
        private System.Windows.Forms.BindingSource bdssv;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbmasv;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpview;
    }
}