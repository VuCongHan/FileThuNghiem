namespace GUI
{
    partial class TrangChu1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hỆTHỐNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.dangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrDmk = new System.Windows.Forms.ToolStripMenuItem();
            this.tHOÁTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.QLNV = new System.Windows.Forms.ToolStripMenuItem();
            this.DMQL_SP = new System.Windows.Forms.ToolStripMenuItem();
            this.DMQL_KH = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongKeSP = new System.Windows.Forms.ToolStripMenuItem();
            this.hƯỚNGDẪNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gIỚITHIỆUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.caigido = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hỆTHỐNGToolStripMenuItem,
            this.tstrDanhMuc,
            this.tstrThongKe,
            this.hƯỚNGDẪNToolStripMenuItem,
            this.gIỚITHIỆUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1402, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hỆTHỐNGToolStripMenuItem
            // 
            this.hỆTHỐNGToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.hỆTHỐNGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangnhap,
            this.dangxuat,
            this.tstrDmk,
            this.tHOÁTToolStripMenuItem});
            this.hỆTHỐNGToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hỆTHỐNGToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.hỆTHỐNGToolStripMenuItem.Name = "hỆTHỐNGToolStripMenuItem";
            this.hỆTHỐNGToolStripMenuItem.Size = new System.Drawing.Size(113, 23);
            this.hỆTHỐNGToolStripMenuItem.Text = "HỆ THỐNG";
            this.hỆTHỐNGToolStripMenuItem.Click += new System.EventHandler(this.hỆTHỐNGToolStripMenuItem_Click);
            // 
            // dangnhap
            // 
            this.dangnhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.Size = new System.Drawing.Size(216, 26);
            this.dangnhap.Text = "ĐĂNG NHẬP";
            this.dangnhap.Click += new System.EventHandler(this.dangnhap_Click);
            // 
            // dangxuat
            // 
            this.dangxuat.Enabled = false;
            this.dangxuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dangxuat.Name = "dangxuat";
            this.dangxuat.Size = new System.Drawing.Size(216, 26);
            this.dangxuat.Text = "ĐĂNG XUẤT";
            this.dangxuat.Click += new System.EventHandler(this.dangxuat_Click);
            // 
            // tstrDmk
            // 
            this.tstrDmk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tstrDmk.Name = "tstrDmk";
            this.tstrDmk.Size = new System.Drawing.Size(216, 26);
            this.tstrDmk.Text = "ĐỔI MẬT KHẨU";
            this.tstrDmk.Visible = false;
            this.tstrDmk.Click += new System.EventHandler(this.tstrDmk_Click);
            // 
            // tHOÁTToolStripMenuItem
            // 
            this.tHOÁTToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tHOÁTToolStripMenuItem.Name = "tHOÁTToolStripMenuItem";
            this.tHOÁTToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.tHOÁTToolStripMenuItem.Text = "THOÁT";
            this.tHOÁTToolStripMenuItem.Click += new System.EventHandler(this.tHOÁTToolStripMenuItem_Click);
            // 
            // tstrDanhMuc
            // 
            this.tstrDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QLNV,
            this.DMQL_SP,
            this.DMQL_KH});
            this.tstrDanhMuc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tstrDanhMuc.ForeColor = System.Drawing.Color.Green;
            this.tstrDanhMuc.Name = "tstrDanhMuc";
            this.tstrDanhMuc.Size = new System.Drawing.Size(115, 23);
            this.tstrDanhMuc.Text = "DANH MỤC";
            this.tstrDanhMuc.Visible = false;
            // 
            // QLNV
            // 
            this.QLNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.QLNV.Name = "QLNV";
            this.QLNV.Size = new System.Drawing.Size(240, 26);
            this.QLNV.Text = "QL_NHÂN VIÊN";
            this.QLNV.Click += new System.EventHandler(this.QLNV_Click);
            // 
            // DMQL_SP
            // 
            this.DMQL_SP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DMQL_SP.Name = "DMQL_SP";
            this.DMQL_SP.Size = new System.Drawing.Size(240, 26);
            this.DMQL_SP.Text = "QL_SẢN PHẨM";
            this.DMQL_SP.Click += new System.EventHandler(this.DMQL_SP_Click);
            // 
            // DMQL_KH
            // 
            this.DMQL_KH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DMQL_KH.Name = "DMQL_KH";
            this.DMQL_KH.Size = new System.Drawing.Size(240, 26);
            this.DMQL_KH.Text = "QL_KHÁCH HÀNG";
            this.DMQL_KH.Click += new System.EventHandler(this.DMQL_KH_Click);
            // 
            // tstrThongKe
            // 
            this.tstrThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuThongKeSP});
            this.tstrThongKe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tstrThongKe.ForeColor = System.Drawing.Color.Green;
            this.tstrThongKe.Name = "tstrThongKe";
            this.tstrThongKe.Size = new System.Drawing.Size(112, 23);
            this.tstrThongKe.Text = "THỐNG KÊ";
            this.tstrThongKe.Visible = false;
            // 
            // menuThongKeSP
            // 
            this.menuThongKeSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.menuThongKeSP.Name = "menuThongKeSP";
            this.menuThongKeSP.Size = new System.Drawing.Size(272, 26);
            this.menuThongKeSP.Text = "THỐNG KÊ SẢN PHẨM";
            this.menuThongKeSP.Click += new System.EventHandler(this.menuThongKeSP_Click);
            // 
            // hƯỚNGDẪNToolStripMenuItem
            // 
            this.hƯỚNGDẪNToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hƯỚNGDẪNToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.hƯỚNGDẪNToolStripMenuItem.Name = "hƯỚNGDẪNToolStripMenuItem";
            this.hƯỚNGDẪNToolStripMenuItem.Size = new System.Drawing.Size(128, 23);
            this.hƯỚNGDẪNToolStripMenuItem.Text = "HƯỚNG DẪN";
            this.hƯỚNGDẪNToolStripMenuItem.Click += new System.EventHandler(this.hƯỚNGDẪNToolStripMenuItem_Click);
            // 
            // gIỚITHIỆUToolStripMenuItem
            // 
            this.gIỚITHIỆUToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gIỚITHIỆUToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.gIỚITHIỆUToolStripMenuItem.Name = "gIỚITHIỆUToolStripMenuItem";
            this.gIỚITHIỆUToolStripMenuItem.Size = new System.Drawing.Size(118, 23);
            this.gIỚITHIỆUToolStripMenuItem.Text = "GIỚI THIỆU";
            this.gIỚITHIỆUToolStripMenuItem.Click += new System.EventHandler(this.gIỚITHIỆUToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(727, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(536, 57);
            this.label6.TabIndex = 9;
            this.label6.Text = "QUẢN LÝ BÁN HÀNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(584, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(858, 57);
            this.label1.TabIndex = 8;
            this.label1.Text = "CHÀO MỪNG ĐẾN VỚI HỆ THỐNG";
            // 
            // caigido
            // 
            this.caigido.AutoSize = true;
            this.caigido.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.caigido.Location = new System.Drawing.Point(1284, 8);
            this.caigido.Name = "caigido";
            this.caigido.Size = new System.Drawing.Size(118, 19);
            this.caigido.TabIndex = 10;
            this.caigido.Text = "CHÀO MỪNG";
            this.caigido.Click += new System.EventHandler(this.label2_Click);
            // 
            // TrangChu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1402, 635);
            this.Controls.Add(this.caigido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "TrangChu1";
            this.Text = "HỆ THỐNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TrangChu1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hỆTHỐNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangnhap;
        private System.Windows.Forms.ToolStripMenuItem dangxuat;
        private System.Windows.Forms.ToolStripMenuItem tHOÁTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hƯỚNGDẪNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tstrDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem QLNV;
        private System.Windows.Forms.ToolStripMenuItem DMQL_SP;
        private System.Windows.Forms.ToolStripMenuItem gIỚITHIỆUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tstrDmk;
        private System.Windows.Forms.ToolStripMenuItem DMQL_KH;
        private System.Windows.Forms.ToolStripMenuItem tstrThongKe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem menuThongKeSP;
        private System.Windows.Forms.Label caigido;
    }
}