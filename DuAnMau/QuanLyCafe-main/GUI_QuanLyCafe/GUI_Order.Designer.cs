
namespace GUI_QuanLyCafe
{
    partial class Order_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_frm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOut_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePassword_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Manage_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Staff_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Material_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Voucher_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Statistic_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Payment_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Delete_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Edit_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Add_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TotalOrder_lbl = new System.Windows.Forms.Label();
            this.VAT_lbl = new System.Windows.Forms.Label();
            this.Total_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.NameStafff_lbl = new System.Windows.Forms.Label();
            this.CheckIn_lbl = new System.Windows.Forms.Label();
            this.NameTable_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Bill_lv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.Log_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Table_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Time_lbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(187)))), ((int)(((byte)(150)))));
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.Manage_tsmi,
            this.Statistic_tsmi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1323, 31);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogOut_MenuItem,
            this.ChangePassword_MenuItem});
            this.hệThốngToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hệThốngToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(98, 27);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // LogOut_MenuItem
            // 
            this.LogOut_MenuItem.Image = global::GUI_QuanLyCafe.Properties.Resources.Apps_session_logout_icon1;
            this.LogOut_MenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.LogOut_MenuItem.Name = "LogOut_MenuItem";
            this.LogOut_MenuItem.Size = new System.Drawing.Size(209, 38);
            this.LogOut_MenuItem.Text = "Đăng xuất";
            this.LogOut_MenuItem.Click += new System.EventHandler(this.LogOut_MenuItem_Click);
            // 
            // ChangePassword_MenuItem
            // 
            this.ChangePassword_MenuItem.Image = global::GUI_QuanLyCafe.Properties.Resources.padlock;
            this.ChangePassword_MenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ChangePassword_MenuItem.Name = "ChangePassword_MenuItem";
            this.ChangePassword_MenuItem.Size = new System.Drawing.Size(209, 38);
            this.ChangePassword_MenuItem.Text = "Đổi mật khẩu";
            this.ChangePassword_MenuItem.Click += new System.EventHandler(this.ChangePassword_MenuItem_Click);
            // 
            // Manage_tsmi
            // 
            this.Manage_tsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Staff_MenuItem,
            this.Material_MenuItem,
            this.Voucher_MenuItem});
            this.Manage_tsmi.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manage_tsmi.ForeColor = System.Drawing.Color.Black;
            this.Manage_tsmi.Name = "Manage_tsmi";
            this.Manage_tsmi.Size = new System.Drawing.Size(87, 27);
            this.Manage_tsmi.Text = "Quản lý";
            // 
            // Staff_MenuItem
            // 
            this.Staff_MenuItem.Image = global::GUI_QuanLyCafe.Properties.Resources.id_card;
            this.Staff_MenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Staff_MenuItem.Name = "Staff_MenuItem";
            this.Staff_MenuItem.Size = new System.Drawing.Size(197, 38);
            this.Staff_MenuItem.Text = "Nhân viên";
            this.Staff_MenuItem.Click += new System.EventHandler(this.Staff_MenuItem_Click);
            // 
            // Material_MenuItem
            // 
            this.Material_MenuItem.Image = global::GUI_QuanLyCafe.Properties.Resources.product;
            this.Material_MenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Material_MenuItem.Name = "Material_MenuItem";
            this.Material_MenuItem.Size = new System.Drawing.Size(197, 38);
            this.Material_MenuItem.Text = "Nguyên liệu";
            this.Material_MenuItem.Click += new System.EventHandler(this.Material_MenuItem_Click);
            // 
            // Voucher_MenuItem
            // 
            this.Voucher_MenuItem.Image = global::GUI_QuanLyCafe.Properties.Resources.coupon;
            this.Voucher_MenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Voucher_MenuItem.Name = "Voucher_MenuItem";
            this.Voucher_MenuItem.Size = new System.Drawing.Size(197, 38);
            this.Voucher_MenuItem.Text = "Voucher";
            this.Voucher_MenuItem.Click += new System.EventHandler(this.Voucher_MenuItem_Click);
            // 
            // Statistic_tsmi
            // 
            this.Statistic_tsmi.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statistic_tsmi.ForeColor = System.Drawing.Color.Black;
            this.Statistic_tsmi.Name = "Statistic_tsmi";
            this.Statistic_tsmi.Size = new System.Drawing.Size(99, 27);
            this.Statistic_tsmi.Text = "Thống kê";
            this.Statistic_tsmi.Click += new System.EventHandler(this.Statistic_tsmi_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.Payment_btn);
            this.panel3.Controls.Add(this.Delete_btn);
            this.panel3.Controls.Add(this.Edit_btn);
            this.panel3.Controls.Add(this.Add_btn);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.Bill_lv);
            this.panel3.Location = new System.Drawing.Point(646, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(669, 732);
            this.panel3.TabIndex = 0;
            // 
            // Payment_btn
            // 
            this.Payment_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Payment_btn.Animated = true;
            this.Payment_btn.BorderRadius = 10;
            this.Payment_btn.BorderThickness = 2;
            this.Payment_btn.CheckedState.Parent = this.Payment_btn;
            this.Payment_btn.CustomImages.Parent = this.Payment_btn;
            this.Payment_btn.Enabled = false;
            this.Payment_btn.FillColor = System.Drawing.Color.White;
            this.Payment_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment_btn.ForeColor = System.Drawing.Color.Black;
            this.Payment_btn.HoverState.Parent = this.Payment_btn;
            this.Payment_btn.Image = global::GUI_QuanLyCafe.Properties.Resources.income;
            this.Payment_btn.Location = new System.Drawing.Point(512, 667);
            this.Payment_btn.Name = "Payment_btn";
            this.Payment_btn.ShadowDecoration.Parent = this.Payment_btn;
            this.Payment_btn.Size = new System.Drawing.Size(150, 50);
            this.Payment_btn.TabIndex = 43;
            this.Payment_btn.Text = "Thanh toán";
            this.Payment_btn.Click += new System.EventHandler(this.Payment_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Delete_btn.Animated = true;
            this.Delete_btn.BorderRadius = 10;
            this.Delete_btn.BorderThickness = 2;
            this.Delete_btn.CheckedState.Parent = this.Delete_btn;
            this.Delete_btn.CustomImages.Parent = this.Delete_btn;
            this.Delete_btn.Enabled = false;
            this.Delete_btn.FillColor = System.Drawing.Color.White;
            this.Delete_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.ForeColor = System.Drawing.Color.Black;
            this.Delete_btn.HoverState.Parent = this.Delete_btn;
            this.Delete_btn.Image = global::GUI_QuanLyCafe.Properties.Resources.Actions_edit_delete_icon;
            this.Delete_btn.Location = new System.Drawing.Point(186, 667);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.ShadowDecoration.Parent = this.Delete_btn;
            this.Delete_btn.Size = new System.Drawing.Size(150, 50);
            this.Delete_btn.TabIndex = 42;
            this.Delete_btn.Text = "Xóa hóa đơn";
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Edit_btn
            // 
            this.Edit_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Edit_btn.Animated = true;
            this.Edit_btn.BorderRadius = 10;
            this.Edit_btn.BorderThickness = 2;
            this.Edit_btn.CheckedState.Parent = this.Edit_btn;
            this.Edit_btn.CustomImages.Parent = this.Edit_btn;
            this.Edit_btn.Enabled = false;
            this.Edit_btn.FillColor = System.Drawing.Color.White;
            this.Edit_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_btn.ForeColor = System.Drawing.Color.Black;
            this.Edit_btn.HoverState.Parent = this.Edit_btn;
            this.Edit_btn.Image = global::GUI_QuanLyCafe.Properties.Resources.exchange;
            this.Edit_btn.Location = new System.Drawing.Point(350, 667);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.ShadowDecoration.Parent = this.Edit_btn;
            this.Edit_btn.Size = new System.Drawing.Size(150, 50);
            this.Edit_btn.TabIndex = 41;
            this.Edit_btn.Text = "Chuyển bàn";
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Add_btn.Animated = true;
            this.Add_btn.BorderRadius = 10;
            this.Add_btn.BorderThickness = 2;
            this.Add_btn.CheckedState.Parent = this.Add_btn;
            this.Add_btn.CustomImages.Parent = this.Add_btn;
            this.Add_btn.Enabled = false;
            this.Add_btn.FillColor = System.Drawing.Color.White;
            this.Add_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.ForeColor = System.Drawing.Color.Black;
            this.Add_btn.HoverState.Parent = this.Add_btn;
            this.Add_btn.Image = global::GUI_QuanLyCafe.Properties.Resources.add_icon;
            this.Add_btn.Location = new System.Drawing.Point(21, 667);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.ShadowDecoration.Parent = this.Add_btn;
            this.Add_btn.Size = new System.Drawing.Size(150, 50);
            this.Add_btn.TabIndex = 40;
            this.Add_btn.Text = "Thêm món";
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.TotalOrder_lbl);
            this.panel2.Controls.Add(this.VAT_lbl);
            this.panel2.Controls.Add(this.Total_lbl);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(21, 532);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 114);
            this.panel2.TabIndex = 22;
            // 
            // TotalOrder_lbl
            // 
            this.TotalOrder_lbl.AutoSize = true;
            this.TotalOrder_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalOrder_lbl.ForeColor = System.Drawing.Color.Black;
            this.TotalOrder_lbl.Location = new System.Drawing.Point(2, 9);
            this.TotalOrder_lbl.Name = "TotalOrder_lbl";
            this.TotalOrder_lbl.Size = new System.Drawing.Size(141, 23);
            this.TotalOrder_lbl.TabIndex = 16;
            this.TotalOrder_lbl.Text = "Tổng hóa đơn : ";
            // 
            // VAT_lbl
            // 
            this.VAT_lbl.AutoSize = true;
            this.VAT_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VAT_lbl.ForeColor = System.Drawing.Color.Black;
            this.VAT_lbl.Location = new System.Drawing.Point(2, 44);
            this.VAT_lbl.Name = "VAT_lbl";
            this.VAT_lbl.Size = new System.Drawing.Size(168, 23);
            this.VAT_lbl.TabIndex = 15;
            this.VAT_lbl.Text = "Thuế VAT (10%) : ";
            // 
            // Total_lbl
            // 
            this.Total_lbl.AutoSize = true;
            this.Total_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_lbl.ForeColor = System.Drawing.Color.Red;
            this.Total_lbl.Location = new System.Drawing.Point(2, 80);
            this.Total_lbl.Name = "Total_lbl";
            this.Total_lbl.Size = new System.Drawing.Size(146, 23);
            this.Total_lbl.TabIndex = 14;
            this.Total_lbl.Text = "Số tiền phải trả :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.NameStafff_lbl);
            this.panel1.Controls.Add(this.CheckIn_lbl);
            this.panel1.Controls.Add(this.NameTable_lbl);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(21, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 130);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::GUI_QuanLyCafe.Properties.Resources._1200px_Highlands_Coffee_logo_svg;
            this.pictureBox2.Location = new System.Drawing.Point(464, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 151;
            this.pictureBox2.TabStop = false;
            // 
            // NameStafff_lbl
            // 
            this.NameStafff_lbl.AutoSize = true;
            this.NameStafff_lbl.Location = new System.Drawing.Point(2, 91);
            this.NameStafff_lbl.Name = "NameStafff_lbl";
            this.NameStafff_lbl.Size = new System.Drawing.Size(98, 23);
            this.NameStafff_lbl.TabIndex = 2;
            this.NameStafff_lbl.Text = "Thu ngân :";
            // 
            // CheckIn_lbl
            // 
            this.CheckIn_lbl.AutoSize = true;
            this.CheckIn_lbl.Location = new System.Drawing.Point(2, 52);
            this.CheckIn_lbl.Name = "CheckIn_lbl";
            this.CheckIn_lbl.Size = new System.Drawing.Size(88, 23);
            this.CheckIn_lbl.TabIndex = 1;
            this.CheckIn_lbl.Text = "Giờ vào :";
            // 
            // NameTable_lbl
            // 
            this.NameTable_lbl.AutoSize = true;
            this.NameTable_lbl.Location = new System.Drawing.Point(2, 13);
            this.NameTable_lbl.Name = "NameTable_lbl";
            this.NameTable_lbl.Size = new System.Drawing.Size(52, 23);
            this.NameTable_lbl.TabIndex = 0;
            this.NameTable_lbl.Text = "Tên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "HÓA ĐƠN";
            // 
            // Bill_lv
            // 
            this.Bill_lv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bill_lv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bill_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.Bill_lv.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_lv.FullRowSelect = true;
            this.Bill_lv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Bill_lv.HideSelection = false;
            this.Bill_lv.Location = new System.Drawing.Point(21, 180);
            this.Bill_lv.MultiSelect = false;
            this.Bill_lv.Name = "Bill_lv";
            this.Bill_lv.Size = new System.Drawing.Size(641, 353);
            this.Bill_lv.TabIndex = 16;
            this.Bill_lv.UseCompatibleStateImageBehavior = false;
            this.Bill_lv.View = System.Windows.Forms.View.Details;
            this.Bill_lv.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.Bill_lv_ColumnWidthChanging);
            this.Bill_lv.DoubleClick += new System.EventHandler(this.Bill_lv_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 150;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.Log_btn);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.Table_flp);
            this.panel4.Location = new System.Drawing.Point(0, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(640, 732);
            this.panel4.TabIndex = 15;
            // 
            // Log_btn
            // 
            this.Log_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Log_btn.Animated = true;
            this.Log_btn.CheckedState.Parent = this.Log_btn;
            this.Log_btn.CustomImages.Parent = this.Log_btn;
            this.Log_btn.FillColor = System.Drawing.Color.Transparent;
            this.Log_btn.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_btn.ForeColor = System.Drawing.Color.White;
            this.Log_btn.HoverState.Parent = this.Log_btn;
            this.Log_btn.Image = global::GUI_QuanLyCafe.Properties.Resources.log_format;
            this.Log_btn.ImageSize = new System.Drawing.Size(33, 33);
            this.Log_btn.Location = new System.Drawing.Point(3, 679);
            this.Log_btn.Name = "Log_btn";
            this.Log_btn.ShadowDecoration.Parent = this.Log_btn;
            this.Log_btn.Size = new System.Drawing.Size(53, 45);
            this.Log_btn.TabIndex = 20;
            this.Log_btn.Click += new System.EventHandler(this.Log_btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "DANH SÁCH BÀN";
            // 
            // Table_flp
            // 
            this.Table_flp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Table_flp.AutoScroll = true;
            this.Table_flp.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Table_flp.Location = new System.Drawing.Point(57, 51);
            this.Table_flp.Name = "Table_flp";
            this.Table_flp.Size = new System.Drawing.Size(583, 671);
            this.Table_flp.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Time_lbl
            // 
            this.Time_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Time_lbl.AutoSize = true;
            this.Time_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(187)))), ((int)(((byte)(150)))));
            this.Time_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_lbl.ForeColor = System.Drawing.Color.Black;
            this.Time_lbl.Location = new System.Drawing.Point(1024, 6);
            this.Time_lbl.Name = "Time_lbl";
            this.Time_lbl.Size = new System.Drawing.Size(292, 23);
            this.Time_lbl.TabIndex = 16;
            this.Time_lbl.Text = "Ca tối  SSS 00/00/0000 00:00:00";
            // 
            // Order_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1323, 771);
            this.Controls.Add(this.Time_lbl);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1100, 810);
            this.Name = "Order_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Order_frm_FormClosing);
            this.Load += new System.EventHandler(this.Order_frm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Manage_tsmi;
        private System.Windows.Forms.ToolStripMenuItem LogOut_MenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TotalOrder_lbl;
        private System.Windows.Forms.Label VAT_lbl;
        private System.Windows.Forms.Label Total_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CheckIn_lbl;
        private System.Windows.Forms.Label NameTable_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView Bill_lv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel Table_flp;
        private System.Windows.Forms.Label NameStafff_lbl;
        private System.Windows.Forms.ToolStripMenuItem ChangePassword_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Staff_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Material_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Statistic_tsmi;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem Voucher_MenuItem;
        private System.Windows.Forms.Label Time_lbl;
        private Guna.UI2.WinForms.Guna2Button Add_btn;
        private Guna.UI2.WinForms.Guna2Button Payment_btn;
        private Guna.UI2.WinForms.Guna2Button Delete_btn;
        private Guna.UI2.WinForms.Guna2Button Edit_btn;
        private Guna.UI2.WinForms.Guna2Button Log_btn;
    }
}

