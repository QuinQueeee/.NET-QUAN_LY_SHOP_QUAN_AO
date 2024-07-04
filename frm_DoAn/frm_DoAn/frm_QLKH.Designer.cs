namespace frm_DoAn
{
    partial class frm_QLKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QLKH));
            this.rdo_Nam = new System.Windows.Forms.RadioButton();
            this.rdo_Nu = new System.Windows.Forms.RadioButton();
            this.dgv_ListKH = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.date_NgSinh = new System.Windows.Forms.DateTimePicker();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.lbl_NgSinh = new System.Windows.Forms.Label();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_MaKH = new System.Windows.Forms.Label();
            this.gb_KH = new System.Windows.Forms.GroupBox();
            this.btn_NhapLai = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListKH)).BeginInit();
            this.gb_KH.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdo_Nam
            // 
            this.rdo_Nam.AutoSize = true;
            this.rdo_Nam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Nam.Location = new System.Drawing.Point(1148, 60);
            this.rdo_Nam.Margin = new System.Windows.Forms.Padding(6);
            this.rdo_Nam.Name = "rdo_Nam";
            this.rdo_Nam.Size = new System.Drawing.Size(106, 40);
            this.rdo_Nam.TabIndex = 5;
            this.rdo_Nam.TabStop = true;
            this.rdo_Nam.Text = "Nam";
            this.rdo_Nam.UseVisualStyleBackColor = true;
            // 
            // rdo_Nu
            // 
            this.rdo_Nu.AutoSize = true;
            this.rdo_Nu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Nu.Location = new System.Drawing.Point(956, 60);
            this.rdo_Nu.Margin = new System.Windows.Forms.Padding(6);
            this.rdo_Nu.Name = "rdo_Nu";
            this.rdo_Nu.Size = new System.Drawing.Size(86, 40);
            this.rdo_Nu.TabIndex = 4;
            this.rdo_Nu.TabStop = true;
            this.rdo_Nu.Text = "Nữ";
            this.rdo_Nu.UseVisualStyleBackColor = true;
            // 
            // dgv_ListKH
            // 
            this.dgv_ListKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgv_ListKH.Location = new System.Drawing.Point(64, 138);
            this.dgv_ListKH.Margin = new System.Windows.Forms.Padding(6);
            this.dgv_ListKH.Name = "dgv_ListKH";
            this.dgv_ListKH.RowHeadersWidth = 82;
            this.dgv_ListKH.Size = new System.Drawing.Size(1436, 525);
            this.dgv_ListKH.TabIndex = 5;
            this.dgv_ListKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListKH_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaKH";
            this.Column1.HeaderText = "Mã khách hàng";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenKH";
            this.Column2.HeaderText = "Tên khách hàng";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SDT";
            this.Column3.HeaderText = "Số điện thoại";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DiaChi";
            this.Column4.HeaderText = "Địa chỉ";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GTinh";
            this.Column5.HeaderText = "Giới tính";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NGSinh";
            this.Column6.HeaderText = "Ngày sinh";
            this.Column6.MinimumWidth = 10;
            this.Column6.Name = "Column6";
            this.Column6.Width = 200;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Email";
            this.Column7.HeaderText = "E - Mail";
            this.Column7.MinimumWidth = 10;
            this.Column7.Name = "Column7";
            this.Column7.Width = 200;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(696, 204);
            this.lbl_Email.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(121, 36);
            this.lbl_Email.TabIndex = 28;
            this.lbl_Email.Text = "E - Mail";
            // 
            // date_NgSinh
            // 
            this.date_NgSinh.CustomFormat = "";
            this.date_NgSinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_NgSinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_NgSinh.Location = new System.Drawing.Point(872, 121);
            this.date_NgSinh.Margin = new System.Windows.Forms.Padding(6);
            this.date_NgSinh.Name = "date_NgSinh";
            this.date_NgSinh.Size = new System.Drawing.Size(482, 44);
            this.date_NgSinh.TabIndex = 6;
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(872, 188);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(482, 44);
            this.txt_Email.TabIndex = 7;
            // 
            // txt_Address
            // 
            this.txt_Address.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.Location = new System.Drawing.Point(184, 256);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(482, 44);
            this.txt_Address.TabIndex = 3;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(184, 188);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(6);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(482, 44);
            this.txt_SDT.TabIndex = 2;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress);
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(184, 119);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(482, 44);
            this.txt_Name.TabIndex = 1;
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaKH.Location = new System.Drawing.Point(184, 52);
            this.txt_MaKH.Margin = new System.Windows.Forms.Padding(6);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(482, 44);
            this.txt_MaKH.TabIndex = 0;
            // 
            // lbl_NgSinh
            // 
            this.lbl_NgSinh.AutoSize = true;
            this.lbl_NgSinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgSinh.Location = new System.Drawing.Point(696, 133);
            this.lbl_NgSinh.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_NgSinh.Name = "lbl_NgSinh";
            this.lbl_NgSinh.Size = new System.Drawing.Size(140, 36);
            this.lbl_NgSinh.TabIndex = 18;
            this.lbl_NgSinh.Text = "Ngày sinh";
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDT.Location = new System.Drawing.Point(40, 204);
            this.lbl_SDT.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(75, 36);
            this.lbl_SDT.TabIndex = 17;
            this.lbl_SDT.Text = "SĐT";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(696, 63);
            this.lbl_Gender.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(129, 36);
            this.lbl_Gender.TabIndex = 16;
            this.lbl_Gender.Text = "Giới tính";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(40, 269);
            this.lbl_Address.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(107, 36);
            this.lbl_Address.TabIndex = 15;
            this.lbl_Address.Text = "Địa chỉ";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(40, 133);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(116, 36);
            this.lbl_Name.TabIndex = 20;
            this.lbl_Name.Text = "Tên KH";
            // 
            // lbl_MaKH
            // 
            this.lbl_MaKH.AutoSize = true;
            this.lbl_MaKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaKH.Location = new System.Drawing.Point(40, 63);
            this.lbl_MaKH.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_MaKH.Name = "lbl_MaKH";
            this.lbl_MaKH.Size = new System.Drawing.Size(110, 36);
            this.lbl_MaKH.TabIndex = 14;
            this.lbl_MaKH.Text = "Mã KH";
            // 
            // gb_KH
            // 
            this.gb_KH.Controls.Add(this.rdo_Nam);
            this.gb_KH.Controls.Add(this.rdo_Nu);
            this.gb_KH.Controls.Add(this.lbl_Email);
            this.gb_KH.Controls.Add(this.date_NgSinh);
            this.gb_KH.Controls.Add(this.txt_Email);
            this.gb_KH.Controls.Add(this.txt_Address);
            this.gb_KH.Controls.Add(this.txt_SDT);
            this.gb_KH.Controls.Add(this.txt_Name);
            this.gb_KH.Controls.Add(this.txt_MaKH);
            this.gb_KH.Controls.Add(this.lbl_NgSinh);
            this.gb_KH.Controls.Add(this.lbl_SDT);
            this.gb_KH.Controls.Add(this.lbl_Gender);
            this.gb_KH.Controls.Add(this.lbl_Address);
            this.gb_KH.Controls.Add(this.lbl_Name);
            this.gb_KH.Controls.Add(this.lbl_MaKH);
            this.gb_KH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_KH.Location = new System.Drawing.Point(64, 689);
            this.gb_KH.Margin = new System.Windows.Forms.Padding(4);
            this.gb_KH.Name = "gb_KH";
            this.gb_KH.Padding = new System.Windows.Forms.Padding(4);
            this.gb_KH.Size = new System.Drawing.Size(1436, 331);
            this.gb_KH.TabIndex = 0;
            this.gb_KH.TabStop = false;
            this.gb_KH.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // btn_NhapLai
            // 
            this.btn_NhapLai.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_NhapLai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_NhapLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhapLai.Image = ((System.Drawing.Image)(resources.GetObject("btn_NhapLai.Image")));
            this.btn_NhapLai.Location = new System.Drawing.Point(1244, 1036);
            this.btn_NhapLai.Margin = new System.Windows.Forms.Padding(6);
            this.btn_NhapLai.Name = "btn_NhapLai";
            this.btn_NhapLai.Size = new System.Drawing.Size(258, 96);
            this.btn_NhapLai.TabIndex = 4;
            this.btn_NhapLai.Text = "NHẬP LẠI";
            this.btn_NhapLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NhapLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_NhapLai.UseVisualStyleBackColor = false;
            this.btn_NhapLai.Click += new System.EventHandler(this.btn_NhapLai_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.Location = new System.Drawing.Point(848, 1036);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(258, 96);
            this.btn_Sua.TabIndex = 3;
            this.btn_Sua.Text = "SỬA";
            this.btn_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.Location = new System.Drawing.Point(456, 1036);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(258, 96);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "XÓA";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.Location = new System.Drawing.Point(64, 1036);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(258, 96);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "THÊM";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SeaShell;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Constantia", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(275, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1080, 73);
            this.label6.TabIndex = 20;
            this.label6.Text = "QUẢN LÍ DANH SÁCH KHÁCH HÀNG";
            // 
            // frm_QLKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1552, 1161);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gb_KH);
            this.Controls.Add(this.dgv_ListKH);
            this.Controls.Add(this.btn_NhapLai);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_QLKH";
            this.Text = "QUẢN LÍ DANH SÁCH KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.frm_ListKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListKH)).EndInit();
            this.gb_KH.ResumeLayout(false);
            this.gb_KH.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdo_Nam;
        private System.Windows.Forms.RadioButton rdo_Nu;
        private System.Windows.Forms.DataGridView dgv_ListKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Button btn_NhapLai;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DateTimePicker date_NgSinh;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.Label lbl_NgSinh;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_MaKH;
        private System.Windows.Forms.GroupBox gb_KH;
        private System.Windows.Forms.Label label6;
    }
}