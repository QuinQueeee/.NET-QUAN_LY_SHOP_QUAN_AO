namespace frm_DoAn
{
    partial class frm_TKDT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TKDT));
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblThanhChu = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelThoiGian = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDenngay = new System.Windows.Forms.DateTimePicker();
            this.dtpTungay = new System.Windows.Forms.DateTimePicker();
            this.lblChon = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.panelThoiGian.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SeaShell;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Constantia", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(334, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(742, 73);
            this.label6.TabIndex = 19;
            this.label6.Text = "THỐNG KÊ DOANH THU";
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.lblThanhChu);
            this.panel2.Controls.Add(this.lblTongTien);
            this.panel2.Location = new System.Drawing.Point(48, 879);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1306, 135);
            this.panel2.TabIndex = 18;
            // 
            // lblThanhChu
            // 
            this.lblThanhChu.AutoSize = true;
            this.lblThanhChu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhChu.Location = new System.Drawing.Point(32, 83);
            this.lblThanhChu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThanhChu.Name = "lblThanhChu";
            this.lblThanhChu.Size = new System.Drawing.Size(210, 32);
            this.lblThanhChu.TabIndex = 9;
            this.lblThanhChu.Text = "THÀNH CHỮ: ";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(32, 17);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(189, 32);
            this.lblTongTien.TabIndex = 8;
            this.lblTongTien.Text = "TỔNG TIỀN: ";
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaNV,
            this.MaKH,
            this.MaSP,
            this.NgayMua,
            this.SLuong,
            this.tongTien});
            this.dgvThongKe.Location = new System.Drawing.Point(48, 300);
            this.dgvThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 82;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(1306, 573);
            this.dgvThongKe.TabIndex = 17;
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.FillWeight = 500F;
            this.MaHD.HeaderText = "Mã Hóa Đơn";
            this.MaHD.MinimumWidth = 20;
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 110;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.MinimumWidth = 20;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 110;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã Khách Hàng";
            this.MaKH.MinimumWidth = 20;
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 120;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã Sản Phẩm";
            this.MaSP.MinimumWidth = 20;
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 110;
            // 
            // NgayMua
            // 
            this.NgayMua.DataPropertyName = "NgayMua";
            this.NgayMua.HeaderText = "Ngày Bán";
            this.NgayMua.MinimumWidth = 20;
            this.NgayMua.Name = "NgayMua";
            this.NgayMua.Width = 200;
            // 
            // SLuong
            // 
            this.SLuong.DataPropertyName = "SLuong";
            this.SLuong.HeaderText = "SL";
            this.SLuong.MinimumWidth = 20;
            this.SLuong.Name = "SLuong";
            this.SLuong.Width = 50;
            // 
            // tongTien
            // 
            this.tongTien.DataPropertyName = "ThanhTien";
            this.tongTien.HeaderText = "Thành Tiền";
            this.tongTien.MinimumWidth = 20;
            this.tongTien.Name = "tongTien";
            this.tongTien.Width = 150;
            // 
            // panelThoiGian
            // 
            this.panelThoiGian.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelThoiGian.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelThoiGian.Controls.Add(this.label3);
            this.panelThoiGian.Controls.Add(this.label2);
            this.panelThoiGian.Controls.Add(this.dtpDenngay);
            this.panelThoiGian.Controls.Add(this.dtpTungay);
            this.panelThoiGian.Location = new System.Drawing.Point(48, 196);
            this.panelThoiGian.Margin = new System.Windows.Forms.Padding(4);
            this.panelThoiGian.Name = "panelThoiGian";
            this.panelThoiGian.Size = new System.Drawing.Size(676, 87);
            this.panelThoiGian.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(372, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Từ ngày";
            // 
            // dtpDenngay
            // 
            this.dtpDenngay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenngay.Location = new System.Drawing.Point(452, 21);
            this.dtpDenngay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDenngay.Name = "dtpDenngay";
            this.dtpDenngay.Size = new System.Drawing.Size(196, 44);
            this.dtpDenngay.TabIndex = 2;
            // 
            // dtpTungay
            // 
            this.dtpTungay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTungay.Location = new System.Drawing.Point(164, 21);
            this.dtpTungay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTungay.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpTungay.Name = "dtpTungay";
            this.dtpTungay.Size = new System.Drawing.Size(192, 44);
            this.dtpTungay.TabIndex = 1;
            // 
            // lblChon
            // 
            this.lblChon.AutoSize = true;
            this.lblChon.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChon.Location = new System.Drawing.Point(52, 138);
            this.lblChon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChon.Name = "lblChon";
            this.lblChon.Size = new System.Drawing.Size(504, 37);
            this.lblChon.TabIndex = 14;
            this.lblChon.Text = "Chọn thời gian muốn xem doanh thu: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1058, 194);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 88);
            this.button1.TabIndex = 20;
            this.button1.Text = "BÁO CÁO";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.Location = new System.Drawing.Point(740, 196);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(296, 88);
            this.btnThongKe.TabIndex = 15;
            this.btnThongKe.Text = "THỐNG KÊ";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // frm_TKDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1392, 1043);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(this.panelThoiGian);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.lblChon);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_TKDT";
            this.Text = "THỐNG KÊ DOANH THU";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.panelThoiGian.ResumeLayout(false);
            this.panelThoiGian.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblThanhChu;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTien;
        private System.Windows.Forms.Panel panelThoiGian;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDenngay;
        private System.Windows.Forms.DateTimePicker dtpTungay;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label lblChon;
    }
}