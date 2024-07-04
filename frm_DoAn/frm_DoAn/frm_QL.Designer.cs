namespace frm_DoAn
{
    partial class frm_QL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QL));
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.btn_TCNV = new System.Windows.Forms.Button();
            this.btn_TCKH = new System.Windows.Forms.Button();
            this.btn_TCHH = new System.Windows.Forms.Button();
            this.panel_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Main
            // 
            this.panel_Main.BackColor = System.Drawing.Color.SeaShell;
            this.panel_Main.Location = new System.Drawing.Point(0, 142);
            this.panel_Main.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1544, 1335);
            this.panel_Main.TabIndex = 3;
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.SeaShell;
            this.panel_Menu.Controls.Add(this.btn_TCNV);
            this.panel_Menu.Controls.Add(this.btn_TCKH);
            this.panel_Menu.Controls.Add(this.btn_TCHH);
            this.panel_Menu.Location = new System.Drawing.Point(0, 2);
            this.panel_Menu.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(1544, 144);
            this.panel_Menu.TabIndex = 2;
            // 
            // btn_TCNV
            // 
            this.btn_TCNV.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_TCNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TCNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TCNV.Image = ((System.Drawing.Image)(resources.GetObject("btn_TCNV.Image")));
            this.btn_TCNV.Location = new System.Drawing.Point(1115, 12);
            this.btn_TCNV.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TCNV.Name = "btn_TCNV";
            this.btn_TCNV.Size = new System.Drawing.Size(413, 106);
            this.btn_TCNV.TabIndex = 2;
            this.btn_TCNV.Text = "NHÂN VIÊN";
            this.btn_TCNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TCNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TCNV.UseVisualStyleBackColor = false;
            this.btn_TCNV.Click += new System.EventHandler(this.btn_TCNV_Click);
            // 
            // btn_TCKH
            // 
            this.btn_TCKH.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_TCKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TCKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TCKH.Image = ((System.Drawing.Image)(resources.GetObject("btn_TCKH.Image")));
            this.btn_TCKH.Location = new System.Drawing.Point(564, 12);
            this.btn_TCKH.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TCKH.Name = "btn_TCKH";
            this.btn_TCKH.Size = new System.Drawing.Size(413, 106);
            this.btn_TCKH.TabIndex = 2;
            this.btn_TCKH.Text = "KHÁCH HÀNG";
            this.btn_TCKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TCKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TCKH.UseVisualStyleBackColor = false;
            this.btn_TCKH.Click += new System.EventHandler(this.btn_TCKH_Click);
            // 
            // btn_TCHH
            // 
            this.btn_TCHH.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_TCHH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TCHH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TCHH.Image = ((System.Drawing.Image)(resources.GetObject("btn_TCHH.Image")));
            this.btn_TCHH.Location = new System.Drawing.Point(13, 11);
            this.btn_TCHH.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TCHH.Name = "btn_TCHH";
            this.btn_TCHH.Size = new System.Drawing.Size(413, 106);
            this.btn_TCHH.TabIndex = 2;
            this.btn_TCHH.Text = "HÀNG HÓA";
            this.btn_TCHH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TCHH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TCHH.UseVisualStyleBackColor = false;
            this.btn_TCHH.Click += new System.EventHandler(this.btn_TCHH_Click);
            // 
            // frm_QL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1554, 1484);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_Menu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_QL";
            this.Text = "MENU QUẢN LÍ";
            this.panel_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Button btn_TCNV;
        private System.Windows.Forms.Button btn_TCKH;
        private System.Windows.Forms.Button btn_TCHH;
    }
}