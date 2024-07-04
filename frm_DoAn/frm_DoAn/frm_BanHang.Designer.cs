namespace frm_DoAn
{
    partial class frm_BanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BanHang));
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.dtpNgayMua = new System.Windows.Forms.DateTimePicker();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtmahd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_KH = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbo_MaSP = new System.Windows.Forms.ComboBox();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.txt_SP = new System.Windows.Forms.TextBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.cbo_NV = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgv_HD = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btn_TaoHD = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HD)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Marker", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(580, 1235);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 61);
            this.label1.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.SeaShell;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Constantia", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(616, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(349, 73);
            this.label9.TabIndex = 38;
            this.label9.Text = "BÁN HÀNG";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.Location = new System.Drawing.Point(1103, 1224);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(337, 112);
            this.btnThanhToan.TabIndex = 52;
            this.btnThanhToan.Text = "THANH TOÁN";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // dtpNgayMua
            // 
            this.dtpNgayMua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayMua.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMua.Location = new System.Drawing.Point(398, 462);
            this.dtpNgayMua.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayMua.Name = "dtpNgayMua";
            this.dtpNgayMua.Size = new System.Drawing.Size(367, 44);
            this.dtpNgayMua.TabIndex = 50;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(1070, 463);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(367, 44);
            this.txtThanhTien.TabIndex = 48;
            // 
            // txtmahd
            // 
            this.txtmahd.Enabled = false;
            this.txtmahd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmahd.Location = new System.Drawing.Point(398, 147);
            this.txtmahd.Margin = new System.Windows.Forms.Padding(4);
            this.txtmahd.Name = "txtmahd";
            this.txtmahd.Size = new System.Drawing.Size(367, 44);
            this.txtmahd.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(844, 468);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 36);
            this.label8.TabIndex = 44;
            this.label8.Text = "Thành tiền:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(844, 307);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 36);
            this.label7.TabIndex = 43;
            this.label7.Text = "Số lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(840, 228);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 36);
            this.label6.TabIndex = 42;
            this.label6.Text = "Sản phẩm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 471);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 36);
            this.label5.TabIndex = 41;
            this.label5.Text = "Ngày mua hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 359);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 36);
            this.label4.TabIndex = 40;
            this.label4.Text = "Nhân viên thanh toán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 36);
            this.label3.TabIndex = 45;
            this.label3.Text = "Khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 36);
            this.label2.TabIndex = 39;
            this.label2.Text = "Mã hóa đơn:";
            // 
            // cbo_KH
            // 
            this.cbo_KH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_KH.FormattingEnabled = true;
            this.cbo_KH.Location = new System.Drawing.Point(398, 252);
            this.cbo_KH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_KH.Name = "cbo_KH";
            this.cbo_KH.Size = new System.Drawing.Size(367, 44);
            this.cbo_KH.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(840, 150);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(214, 36);
            this.label10.TabIndex = 42;
            this.label10.Text = "Mã sản phẩm:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(844, 386);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 36);
            this.label11.TabIndex = 44;
            this.label11.Text = "Đơn giá:";
            // 
            // cbo_MaSP
            // 
            this.cbo_MaSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_MaSP.FormattingEnabled = true;
            this.cbo_MaSP.Location = new System.Drawing.Point(1070, 147);
            this.cbo_MaSP.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_MaSP.Name = "cbo_MaSP";
            this.cbo_MaSP.Size = new System.Drawing.Size(367, 44);
            this.cbo_MaSP.TabIndex = 54;
            this.cbo_MaSP.SelectedIndexChanged += new System.EventHandler(this.cbo_MaSP_SelectedIndexChanged);
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Enabled = false;
            this.txt_DonGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DonGia.Location = new System.Drawing.Point(1070, 384);
            this.txt_DonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(367, 44);
            this.txt_DonGia.TabIndex = 48;
            // 
            // txt_SP
            // 
            this.txt_SP.Enabled = false;
            this.txt_SP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SP.Location = new System.Drawing.Point(1070, 226);
            this.txt_SP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SP.Name = "txt_SP";
            this.txt_SP.Size = new System.Drawing.Size(367, 44);
            this.txt_SP.TabIndex = 48;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuong.Location = new System.Drawing.Point(1070, 305);
            this.txt_SoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(367, 44);
            this.txt_SoLuong.TabIndex = 48;
            this.txt_SoLuong.TextChanged += new System.EventHandler(this.txt_SoLuong_TextChanged);
            this.txt_SoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoLuong_KeyPress);
            // 
            // cbo_NV
            // 
            this.cbo_NV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_NV.FormattingEnabled = true;
            this.cbo_NV.Location = new System.Drawing.Point(398, 357);
            this.cbo_NV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_NV.Name = "cbo_NV";
            this.cbo_NV.Size = new System.Drawing.Size(367, 44);
            this.cbo_NV.TabIndex = 57;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Wheat;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(589, 1224);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(337, 112);
            this.btnThem.TabIndex = 56;
            this.btnThem.Text = "THÊM";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgv_HD
            // 
            this.dgv_HD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgv_HD.Location = new System.Drawing.Point(75, 531);
            this.dgv_HD.Name = "dgv_HD";
            this.dgv_HD.RowHeadersWidth = 82;
            this.dgv_HD.RowTemplate.Height = 33;
            this.dgv_HD.Size = new System.Drawing.Size(1362, 559);
            this.dgv_HD.TabIndex = 58;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.lblTongTien);
            this.panel2.Location = new System.Drawing.Point(75, 1107);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1365, 89);
            this.panel2.TabIndex = 59;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(23, 32);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(258, 32);
            this.lblTongTien.TabIndex = 8;
            this.lblTongTien.Text = "TỔNG HÓA ĐƠN: ";
            // 
            // btn_TaoHD
            // 
            this.btn_TaoHD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_TaoHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaoHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoHD.Image = ((System.Drawing.Image)(resources.GetObject("btn_TaoHD.Image")));
            this.btn_TaoHD.Location = new System.Drawing.Point(75, 1217);
            this.btn_TaoHD.Name = "btn_TaoHD";
            this.btn_TaoHD.Size = new System.Drawing.Size(337, 112);
            this.btn_TaoHD.TabIndex = 60;
            this.btn_TaoHD.Text = "TẠO HÓA ĐƠN";
            this.btn_TaoHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TaoHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TaoHD.UseVisualStyleBackColor = false;
            this.btn_TaoHD.Click += new System.EventHandler(this.btn_TaoHD_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "mahd";
            this.Column1.HeaderText = "Mã HĐ";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "makh";
            this.Column2.HeaderText = "Mã KH";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "manv";
            this.Column3.HeaderText = "Mã NV";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ngaymua";
            this.Column4.HeaderText = "Ngày Mua";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "masp";
            this.Column5.HeaderText = "Mã SP";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "tensp";
            this.Column6.HeaderText = "Sản phẩm";
            this.Column6.MinimumWidth = 10;
            this.Column6.Name = "Column6";
            this.Column6.Width = 200;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "sluong";
            this.Column7.HeaderText = "Số lượng";
            this.Column7.MinimumWidth = 10;
            this.Column7.Name = "Column7";
            this.Column7.Width = 200;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "dongia";
            this.Column8.HeaderText = "Đơn giá";
            this.Column8.MinimumWidth = 10;
            this.Column8.Name = "Column8";
            this.Column8.Width = 200;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "thanhtien";
            this.Column9.HeaderText = "Thành tiền";
            this.Column9.MinimumWidth = 10;
            this.Column9.Name = "Column9";
            this.Column9.Width = 200;
            // 
            // frm_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1516, 1365);
            this.Controls.Add(this.btn_TaoHD);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_HD);
            this.Controls.Add(this.cbo_NV);
            this.Controls.Add(this.cbo_KH);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbo_MaSP);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.dtpNgayMua);
            this.Controls.Add(this.txt_SP);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.txt_DonGia);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.txtmahd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_BanHang";
            this.Text = "BÁN HÀNG";
            this.Load += new System.EventHandler(this.frm_BanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HD)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DateTimePicker dtpNgayMua;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtmahd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_KH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbo_MaSP;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.TextBox txt_SP;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.ComboBox cbo_NV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgv_HD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btn_TaoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}