namespace frm_DoAn
{
    partial class frm_QLNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QLNV));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdogtnu = new System.Windows.Forms.RadioButton();
            this.rdogtnam = new System.Windows.Forms.RadioButton();
            this.txttennhanvien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txtdangnhap = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpick = new System.Windows.Forms.DateTimePicker();
            this.gbNV = new System.Windows.Forms.GroupBox();
            this.rdoNVien = new System.Windows.Forms.RadioButton();
            this.rdoQLi = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column10,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(82, 119);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(1396, 410);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "manv";
            this.Column1.HeaderText = "Mã NV";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "RoleID";
            this.Column10.HeaderText = "Chức vụ";
            this.Column10.MinimumWidth = 10;
            this.Column10.Name = "Column10";
            this.Column10.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tennv";
            this.Column2.HeaderText = "Tên NV";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sdt";
            this.Column3.HeaderText = "SĐT";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "diachi";
            this.Column4.HeaderText = "Địa chỉ";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "gtinh";
            this.Column5.HeaderText = "Giới tính";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ngsinh";
            this.Column6.HeaderText = "Ngày sinh";
            this.Column6.MinimumWidth = 10;
            this.Column6.Name = "Column6";
            this.Column6.Width = 200;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "tendangnhap";
            this.Column7.HeaderText = "Tên đăng nhập";
            this.Column7.MinimumWidth = 10;
            this.Column7.Name = "Column7";
            this.Column7.Width = 200;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "password";
            this.Column8.HeaderText = "Mật khẩu";
            this.Column8.MinimumWidth = 10;
            this.Column8.Name = "Column8";
            this.Column8.Width = 200;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "email";
            this.Column9.HeaderText = "Email";
            this.Column9.MinimumWidth = 10;
            this.Column9.Name = "Column9";
            this.Column9.Width = 200;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdogtnu);
            this.groupBox2.Controls.Add(this.rdogtnam);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(52, 333);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox2.Size = new System.Drawing.Size(608, 144);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giới tính";
            // 
            // rdogtnu
            // 
            this.rdogtnu.AutoSize = true;
            this.rdogtnu.Location = new System.Drawing.Point(360, 63);
            this.rdogtnu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rdogtnu.Name = "rdogtnu";
            this.rdogtnu.Size = new System.Drawing.Size(86, 40);
            this.rdogtnu.TabIndex = 1;
            this.rdogtnu.TabStop = true;
            this.rdogtnu.Text = "Nữ";
            this.rdogtnu.UseVisualStyleBackColor = true;
            // 
            // rdogtnam
            // 
            this.rdogtnam.AutoSize = true;
            this.rdogtnam.Location = new System.Drawing.Point(40, 63);
            this.rdogtnam.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rdogtnam.Name = "rdogtnam";
            this.rdogtnam.Size = new System.Drawing.Size(106, 40);
            this.rdogtnam.TabIndex = 0;
            this.rdogtnam.TabStop = true;
            this.rdogtnam.Text = "Nam";
            this.rdogtnam.UseVisualStyleBackColor = true;
            // 
            // txttennhanvien
            // 
            this.txttennhanvien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttennhanvien.Location = new System.Drawing.Point(902, 77);
            this.txttennhanvien.Margin = new System.Windows.Forms.Padding(6);
            this.txttennhanvien.Name = "txttennhanvien";
            this.txttennhanvien.Size = new System.Drawing.Size(454, 44);
            this.txttennhanvien.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(692, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên NV";
            // 
            // txtsdt
            // 
            this.txtsdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsdt.Location = new System.Drawing.Point(204, 260);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(6);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(454, 44);
            this.txtsdt.TabIndex = 2;
            this.txtsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdt_KeyPress);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhau.Location = new System.Drawing.Point(902, 440);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(6);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(454, 44);
            this.txtmatkhau.TabIndex = 7;
            // 
            // txtdangnhap
            // 
            this.txtdangnhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdangnhap.Location = new System.Drawing.Point(902, 342);
            this.txtdangnhap.Margin = new System.Windows.Forms.Padding(6);
            this.txtdangnhap.Name = "txtdangnhap";
            this.txtdangnhap.Size = new System.Drawing.Size(454, 44);
            this.txtdangnhap.TabIndex = 6;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Location = new System.Drawing.Point(902, 167);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(6);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(454, 44);
            this.txtdiachi.TabIndex = 4;
            // 
            // txtmanv
            // 
            this.txtmanv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanv.Location = new System.Drawing.Point(204, 77);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(6);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(454, 44);
            this.txtmanv.TabIndex = 0;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(902, 260);
            this.txtemail.Margin = new System.Windows.Forms.Padding(6);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(454, 44);
            this.txtemail.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "SDT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(692, 350);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 36);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên đăng nhập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(692, 440);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 36);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mật khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(692, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(692, 260);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email";
            // 
            // dtpick
            // 
            this.dtpick.CustomFormat = "";
            this.dtpick.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpick.Location = new System.Drawing.Point(204, 167);
            this.dtpick.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dtpick.Name = "dtpick";
            this.dtpick.Size = new System.Drawing.Size(454, 44);
            this.dtpick.TabIndex = 1;
            // 
            // gbNV
            // 
            this.gbNV.Controls.Add(this.rdoNVien);
            this.gbNV.Controls.Add(this.rdoQLi);
            this.gbNV.Controls.Add(this.label9);
            this.gbNV.Controls.Add(this.dtpick);
            this.gbNV.Controls.Add(this.label6);
            this.gbNV.Controls.Add(this.label5);
            this.gbNV.Controls.Add(this.label8);
            this.gbNV.Controls.Add(this.label7);
            this.gbNV.Controls.Add(this.label3);
            this.gbNV.Controls.Add(this.label4);
            this.gbNV.Controls.Add(this.label1);
            this.gbNV.Controls.Add(this.txtemail);
            this.gbNV.Controls.Add(this.txtmanv);
            this.gbNV.Controls.Add(this.txtdiachi);
            this.gbNV.Controls.Add(this.txtdangnhap);
            this.gbNV.Controls.Add(this.txtmatkhau);
            this.gbNV.Controls.Add(this.txtsdt);
            this.gbNV.Controls.Add(this.label2);
            this.gbNV.Controls.Add(this.txttennhanvien);
            this.gbNV.Controls.Add(this.groupBox2);
            this.gbNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNV.Location = new System.Drawing.Point(82, 538);
            this.gbNV.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gbNV.Name = "gbNV";
            this.gbNV.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gbNV.Size = new System.Drawing.Size(1396, 587);
            this.gbNV.TabIndex = 0;
            this.gbNV.TabStop = false;
            this.gbNV.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // rdoNVien
            // 
            this.rdoNVien.AutoSize = true;
            this.rdoNVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNVien.Location = new System.Drawing.Point(1124, 519);
            this.rdoNVien.Margin = new System.Windows.Forms.Padding(4);
            this.rdoNVien.Name = "rdoNVien";
            this.rdoNVien.Size = new System.Drawing.Size(174, 40);
            this.rdoNVien.TabIndex = 10;
            this.rdoNVien.TabStop = true;
            this.rdoNVien.Text = "Nhân viên";
            this.rdoNVien.UseVisualStyleBackColor = true;
            // 
            // rdoQLi
            // 
            this.rdoQLi.AutoSize = true;
            this.rdoQLi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoQLi.Location = new System.Drawing.Point(552, 523);
            this.rdoQLi.Margin = new System.Windows.Forms.Padding(4);
            this.rdoQLi.Name = "rdoQLi";
            this.rdoQLi.Size = new System.Drawing.Size(139, 40);
            this.rdoQLi.TabIndex = 3;
            this.rdoQLi.TabStop = true;
            this.rdoQLi.Text = "Quản lí";
            this.rdoQLi.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 523);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 36);
            this.label9.TabIndex = 1;
            this.label9.Text = "Chức vụ";
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.BackColor = System.Drawing.Color.SandyBrown;
            this.btnNhapLai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNhapLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapLai.Image")));
            this.btnNhapLai.Location = new System.Drawing.Point(1234, 1140);
            this.btnNhapLai.Margin = new System.Windows.Forms.Padding(6);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(244, 94);
            this.btnNhapLai.TabIndex = 3;
            this.btnNhapLai.Text = "NHẬP LẠI";
            this.btnNhapLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhapLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhapLai.UseVisualStyleBackColor = false;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.Location = new System.Drawing.Point(850, 1140);
            this.btnsua.Margin = new System.Windows.Forms.Padding(6);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(244, 94);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "SỬA";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.LightCoral;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.Location = new System.Drawing.Point(466, 1140);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(6);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(244, 94);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "XÓA";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.Location = new System.Drawing.Point(82, 1140);
            this.btnthem.Margin = new System.Windows.Forms.Padding(6);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(244, 94);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "THÊM";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.SeaShell;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Constantia", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(308, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1002, 73);
            this.label10.TabIndex = 35;
            this.label10.Text = "QUẢN LÍ DANH SÁCH NHÂN VIÊN";
            // 
            // frm_QLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1548, 1277);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbNV);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_QLNV";
            this.Text = "QUẢN LÍ DANH SÁCH NHÂN VIÊN";
            this.Load += new System.EventHandler(this.frm_QLNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbNV.ResumeLayout(false);
            this.gbNV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdogtnu;
        private System.Windows.Forms.RadioButton rdogtnam;
        private System.Windows.Forms.TextBox txttennhanvien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txtdangnhap;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpick;
        private System.Windows.Forms.GroupBox gbNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.RadioButton rdoNVien;
        private System.Windows.Forms.RadioButton rdoQLi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}