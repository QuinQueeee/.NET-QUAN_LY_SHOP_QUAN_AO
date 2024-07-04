namespace frm_DoAn
{
    partial class frm_HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HoaDon));
            this.dgvhoadon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_masp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txttensanpham = new System.Windows.Forms.TextBox();
            this.gbhoadon = new System.Windows.Forms.GroupBox();
            this.cbomakh = new System.Windows.Forms.ComboBox();
            this.cbomanv = new System.Windows.Forms.ComboBox();
            this.dtpick = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmahd1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btn_InHD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbhoadon.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvhoadon
            // 
            this.dgvhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvhoadon.Location = new System.Drawing.Point(56, 712);
            this.dgvhoadon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgvhoadon.Name = "dgvhoadon";
            this.dgvhoadon.RowHeadersWidth = 51;
            this.dgvhoadon.RowTemplate.Height = 24;
            this.dgvhoadon.Size = new System.Drawing.Size(1396, 385);
            this.dgvhoadon.TabIndex = 11;
            this.dgvhoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhoadon_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "mahd";
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "masp";
            this.Column2.HeaderText = "Mã sản phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tensp";
            this.Column3.HeaderText = "Tên sản phẩm";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Sluong";
            this.Column4.HeaderText = "Số lượng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DonGia";
            this.Column5.HeaderText = "Đơn giá";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ThanhTien";
            this.Column6.HeaderText = "Thành tiền";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ngaymua";
            this.Column7.HeaderText = "Ngày mua";
            this.Column7.MinimumWidth = 10;
            this.Column7.Name = "Column7";
            this.Column7.Width = 200;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "makh";
            this.Column8.HeaderText = "Khách hàng";
            this.Column8.MinimumWidth = 10;
            this.Column8.Name = "Column8";
            this.Column8.Width = 200;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "manv";
            this.Column9.HeaderText = "Nhân viên phụ trách";
            this.Column9.MinimumWidth = 10;
            this.Column9.Name = "Column9";
            this.Column9.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_masp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtsoluong);
            this.groupBox1.Controls.Add(this.txtthanhtien);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtdongia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txttensanpham);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(56, 331);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox1.Size = new System.Drawing.Size(1396, 346);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN MẶT HÀNG";
            // 
            // cbo_masp
            // 
            this.cbo_masp.FormattingEnabled = true;
            this.cbo_masp.Location = new System.Drawing.Point(206, 58);
            this.cbo_masp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cbo_masp.Name = "cbo_masp";
            this.cbo_masp.Size = new System.Drawing.Size(454, 44);
            this.cbo_masp.TabIndex = 6;
            this.cbo_masp.SelectedIndexChanged += new System.EventHandler(this.cbo_masp_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thành tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số lượng";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoluong.Location = new System.Drawing.Point(206, 163);
            this.txtsoluong.Margin = new System.Windows.Forms.Padding(6);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(454, 44);
            this.txtsoluong.TabIndex = 0;
            this.txtsoluong.TextChanged += new System.EventHandler(this.txtsoluong_TextChanged);
            this.txtsoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoluong_KeyPress);
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Enabled = false;
            this.txtthanhtien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtthanhtien.Location = new System.Drawing.Point(206, 269);
            this.txtthanhtien.Margin = new System.Windows.Forms.Padding(6);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.Size = new System.Drawing.Size(454, 44);
            this.txtthanhtien.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(692, 163);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 36);
            this.label9.TabIndex = 0;
            this.label9.Text = "Đơn giá";
            // 
            // txtdongia
            // 
            this.txtdongia.Enabled = false;
            this.txtdongia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdongia.Location = new System.Drawing.Point(902, 163);
            this.txtdongia.Margin = new System.Windows.Forms.Padding(6);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(454, 44);
            this.txtdongia.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(692, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 36);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên sản phẩm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 62);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 36);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã sản phẩm";
            // 
            // txttensanpham
            // 
            this.txttensanpham.Enabled = false;
            this.txttensanpham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttensanpham.Location = new System.Drawing.Point(902, 60);
            this.txttensanpham.Margin = new System.Windows.Forms.Padding(6);
            this.txttensanpham.Name = "txttensanpham";
            this.txttensanpham.Size = new System.Drawing.Size(454, 44);
            this.txttensanpham.TabIndex = 3;
            // 
            // gbhoadon
            // 
            this.gbhoadon.BackColor = System.Drawing.Color.SeaShell;
            this.gbhoadon.Controls.Add(this.cbomakh);
            this.gbhoadon.Controls.Add(this.cbomanv);
            this.gbhoadon.Controls.Add(this.dtpick);
            this.gbhoadon.Controls.Add(this.label5);
            this.gbhoadon.Controls.Add(this.label4);
            this.gbhoadon.Controls.Add(this.label1);
            this.gbhoadon.Controls.Add(this.txtmahd1);
            this.gbhoadon.Controls.Add(this.label2);
            this.gbhoadon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbhoadon.Location = new System.Drawing.Point(56, 23);
            this.gbhoadon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gbhoadon.Name = "gbhoadon";
            this.gbhoadon.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gbhoadon.Size = new System.Drawing.Size(1396, 287);
            this.gbhoadon.TabIndex = 9;
            this.gbhoadon.TabStop = false;
            this.gbhoadon.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // cbomakh
            // 
            this.cbomakh.FormattingEnabled = true;
            this.cbomakh.Location = new System.Drawing.Point(902, 179);
            this.cbomakh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cbomakh.Name = "cbomakh";
            this.cbomakh.Size = new System.Drawing.Size(454, 44);
            this.cbomakh.TabIndex = 5;
            // 
            // cbomanv
            // 
            this.cbomanv.FormattingEnabled = true;
            this.cbomanv.Location = new System.Drawing.Point(902, 73);
            this.cbomanv.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cbomanv.Name = "cbomanv";
            this.cbomanv.Size = new System.Drawing.Size(454, 44);
            this.cbomanv.TabIndex = 5;
            // 
            // dtpick
            // 
            this.dtpick.CustomFormat = "";
            this.dtpick.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpick.Location = new System.Drawing.Point(192, 177);
            this.dtpick.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dtpick.Name = "dtpick";
            this.dtpick.Size = new System.Drawing.Size(454, 44);
            this.dtpick.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(692, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày mua";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // txtmahd1
            // 
            this.txtmahd1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmahd1.Location = new System.Drawing.Point(192, 83);
            this.txtmahd1.Margin = new System.Windows.Forms.Padding(6);
            this.txtmahd1.Name = "txtmahd1";
            this.txtmahd1.Size = new System.Drawing.Size(454, 44);
            this.txtmahd1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(692, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên";
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.Location = new System.Drawing.Point(605, 1123);
            this.btnsua.Margin = new System.Windows.Forms.Padding(6);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(297, 113);
            this.btnsua.TabIndex = 14;
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
            this.btnxoa.Location = new System.Drawing.Point(56, 1123);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(6);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(297, 113);
            this.btnxoa.TabIndex = 13;
            this.btnxoa.Text = "XÓA";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btn_InHD
            // 
            this.btn_InHD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_InHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InHD.Image = ((System.Drawing.Image)(resources.GetObject("btn_InHD.Image")));
            this.btn_InHD.Location = new System.Drawing.Point(1154, 1123);
            this.btn_InHD.Name = "btn_InHD";
            this.btn_InHD.Size = new System.Drawing.Size(297, 113);
            this.btn_InHD.TabIndex = 15;
            this.btn_InHD.Text = "IN HÓA ĐƠN";
            this.btn_InHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_InHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_InHD.UseVisualStyleBackColor = false;
            this.btn_InHD.Click += new System.EventHandler(this.btn_InHD_Click);
            // 
            // frm_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1496, 1248);
            this.Controls.Add(this.btn_InHD);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.dgvhoadon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbhoadon);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_HoaDon";
            this.Text = "HÓA ĐƠN BÁN HÀNG";
            this.Load += new System.EventHandler(this.frm_HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbhoadon.ResumeLayout(false);
            this.gbhoadon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.DataGridView dgvhoadon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo_masp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttensanpham;
        private System.Windows.Forms.GroupBox gbhoadon;
        private System.Windows.Forms.ComboBox cbomakh;
        private System.Windows.Forms.ComboBox cbomanv;
        private System.Windows.Forms.DateTimePicker dtpick;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmahd1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button btn_InHD;
    }
}