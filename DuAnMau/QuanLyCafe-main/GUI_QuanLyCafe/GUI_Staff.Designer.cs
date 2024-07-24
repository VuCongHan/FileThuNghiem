
namespace GUI_QuanLyCafe
{
    partial class Staff_frm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_frm));
            this.ListStaff_dgv = new System.Windows.Forms.DataGridView();
            this.Log_Menu = new System.Windows.Forms.MenuStrip();
            this.Log_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Picture_ptb = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameStaff_lbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PhoneNumber_lbl = new System.Windows.Forms.Label();
            this.Role_lbl = new System.Windows.Forms.Label();
            this.Address_lbl = new System.Windows.Forms.Label();
            this.Gender_lbl = new System.Windows.Forms.Label();
            this.IdStafff_txt = new System.Windows.Forms.TextBox();
            this.PhoneNumber_txt = new System.Windows.Forms.TextBox();
            this.NameStaff_txt = new System.Windows.Forms.TextBox();
            this.Find_txt = new System.Windows.Forms.TextBox();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.Adress_txt = new System.Windows.Forms.TextBox();
            this.Gender_cbb = new System.Windows.Forms.ComboBox();
            this.Role_cbb = new System.Windows.Forms.ComboBox();
            this.Delete_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Edit_btn = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Edit_ckb = new System.Windows.Forms.CheckBox();
            this.Add_btn = new Guna.UI2.WinForms.Guna2Button();
            this.BirthDay_lbl = new System.Windows.Forms.Label();
            this.BirthDay_date = new System.Windows.Forms.DateTimePicker();
            this.ResetFind_btn = new Guna.UI2.WinForms.Guna2Button();
            this.CreateID_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Email_lbl = new System.Windows.Forms.Label();
            this.PathPicture_txt = new System.Windows.Forms.TextBox();
            this.FindBy_cbb = new System.Windows.Forms.ComboBox();
            this.OpenFilePicture_btn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListStaff_dgv)).BeginInit();
            this.Log_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_ptb)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ListStaff_dgv
            // 
            this.ListStaff_dgv.AllowUserToAddRows = false;
            this.ListStaff_dgv.AllowUserToDeleteRows = false;
            this.ListStaff_dgv.AllowUserToResizeColumns = false;
            this.ListStaff_dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ListStaff_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListStaff_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListStaff_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ListStaff_dgv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListStaff_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListStaff_dgv.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListStaff_dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.ListStaff_dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ListStaff_dgv.Location = new System.Drawing.Point(32, 567);
            this.ListStaff_dgv.MultiSelect = false;
            this.ListStaff_dgv.Name = "ListStaff_dgv";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListStaff_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ListStaff_dgv.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListStaff_dgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ListStaff_dgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListStaff_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListStaff_dgv.ShowCellErrors = false;
            this.ListStaff_dgv.ShowCellToolTips = false;
            this.ListStaff_dgv.ShowEditingIcon = false;
            this.ListStaff_dgv.ShowRowErrors = false;
            this.ListStaff_dgv.Size = new System.Drawing.Size(1036, 399);
            this.ListStaff_dgv.TabIndex = 129;
            this.ListStaff_dgv.TabStop = false;
            this.ListStaff_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListStaff_dgv_CellClick);
            // 
            // Log_Menu
            // 
            this.Log_Menu.BackColor = System.Drawing.Color.Transparent;
            this.Log_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Log_MenuItem});
            this.Log_Menu.Location = new System.Drawing.Point(0, 0);
            this.Log_Menu.Name = "Log_Menu";
            this.Log_Menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Log_Menu.Size = new System.Drawing.Size(1095, 40);
            this.Log_Menu.TabIndex = 143;
            this.Log_Menu.Text = "menuStrip1";
            // 
            // Log_MenuItem
            // 
            this.Log_MenuItem.Image = global::GUI_QuanLyCafe.Properties.Resources.log_format;
            this.Log_MenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Log_MenuItem.Name = "Log_MenuItem";
            this.Log_MenuItem.Size = new System.Drawing.Size(44, 36);
            this.Log_MenuItem.Click += new System.EventHandler(this.Log_MenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 32);
            this.label1.TabIndex = 144;
            this.label1.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // Picture_ptb
            // 
            this.Picture_ptb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Picture_ptb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Picture_ptb.Location = new System.Drawing.Point(798, 156);
            this.Picture_ptb.Name = "Picture_ptb";
            this.Picture_ptb.Size = new System.Drawing.Size(270, 336);
            this.Picture_ptb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture_ptb.TabIndex = 138;
            this.Picture_ptb.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 123;
            this.label2.Text = "Mã số";
            // 
            // NameStaff_lbl
            // 
            this.NameStaff_lbl.AutoSize = true;
            this.NameStaff_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameStaff_lbl.Location = new System.Drawing.Point(28, 222);
            this.NameStaff_lbl.Name = "NameStaff_lbl";
            this.NameStaff_lbl.Size = new System.Drawing.Size(66, 23);
            this.NameStaff_lbl.TabIndex = 116;
            this.NameStaff_lbl.Text = "Họ tên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 523);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 23);
            this.label9.TabIndex = 117;
            this.label9.Text = "Tìm kiếm";
            // 
            // PhoneNumber_lbl
            // 
            this.PhoneNumber_lbl.AutoSize = true;
            this.PhoneNumber_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber_lbl.Location = new System.Drawing.Point(28, 361);
            this.PhoneNumber_lbl.Name = "PhoneNumber_lbl";
            this.PhoneNumber_lbl.Size = new System.Drawing.Size(120, 23);
            this.PhoneNumber_lbl.TabIndex = 118;
            this.PhoneNumber_lbl.Text = "Số điện thoại";
            // 
            // Role_lbl
            // 
            this.Role_lbl.AutoSize = true;
            this.Role_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role_lbl.Location = new System.Drawing.Point(210, 293);
            this.Role_lbl.Name = "Role_lbl";
            this.Role_lbl.Size = new System.Drawing.Size(67, 23);
            this.Role_lbl.TabIndex = 121;
            this.Role_lbl.Text = "Vai trò";
            // 
            // Address_lbl
            // 
            this.Address_lbl.AutoSize = true;
            this.Address_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_lbl.Location = new System.Drawing.Point(421, 293);
            this.Address_lbl.Name = "Address_lbl";
            this.Address_lbl.Size = new System.Drawing.Size(70, 23);
            this.Address_lbl.TabIndex = 120;
            this.Address_lbl.Text = "Địa chỉ";
            // 
            // Gender_lbl
            // 
            this.Gender_lbl.AutoSize = true;
            this.Gender_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender_lbl.Location = new System.Drawing.Point(28, 293);
            this.Gender_lbl.Name = "Gender_lbl";
            this.Gender_lbl.Size = new System.Drawing.Size(85, 23);
            this.Gender_lbl.TabIndex = 119;
            this.Gender_lbl.Text = "Giới tính";
            // 
            // IdStafff_txt
            // 
            this.IdStafff_txt.CausesValidation = false;
            this.IdStafff_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdStafff_txt.Location = new System.Drawing.Point(122, 156);
            this.IdStafff_txt.Name = "IdStafff_txt";
            this.IdStafff_txt.ReadOnly = true;
            this.IdStafff_txt.Size = new System.Drawing.Size(249, 32);
            this.IdStafff_txt.TabIndex = 122;
            // 
            // PhoneNumber_txt
            // 
            this.PhoneNumber_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber_txt.Location = new System.Drawing.Point(154, 358);
            this.PhoneNumber_txt.Name = "PhoneNumber_txt";
            this.PhoneNumber_txt.ReadOnly = true;
            this.PhoneNumber_txt.Size = new System.Drawing.Size(252, 32);
            this.PhoneNumber_txt.TabIndex = 128;
            this.PhoneNumber_txt.TextChanged += new System.EventHandler(this.PhoneNumber_txt_TextChanged);
            // 
            // NameStaff_txt
            // 
            this.NameStaff_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameStaff_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameStaff_txt.Location = new System.Drawing.Point(122, 219);
            this.NameStaff_txt.Name = "NameStaff_txt";
            this.NameStaff_txt.ReadOnly = true;
            this.NameStaff_txt.Size = new System.Drawing.Size(284, 32);
            this.NameStaff_txt.TabIndex = 124;
            this.NameStaff_txt.TextChanged += new System.EventHandler(this.NameStaff_txt_TextChanged);
            // 
            // Find_txt
            // 
            this.Find_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Find_txt.Location = new System.Drawing.Point(122, 520);
            this.Find_txt.Name = "Find_txt";
            this.Find_txt.Size = new System.Drawing.Size(284, 32);
            this.Find_txt.TabIndex = 134;
            this.Find_txt.TabStop = false;
            this.Find_txt.TextChanged += new System.EventHandler(this.Find_txt_TextChanged);
            // 
            // Email_txt
            // 
            this.Email_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_txt.Location = new System.Drawing.Point(489, 218);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.ReadOnly = true;
            this.Email_txt.Size = new System.Drawing.Size(274, 32);
            this.Email_txt.TabIndex = 132;
            this.Email_txt.TextChanged += new System.EventHandler(this.Email_txt_TextChanged);
            // 
            // Adress_txt
            // 
            this.Adress_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adress_txt.Location = new System.Drawing.Point(425, 330);
            this.Adress_txt.Multiline = true;
            this.Adress_txt.Name = "Adress_txt";
            this.Adress_txt.ReadOnly = true;
            this.Adress_txt.Size = new System.Drawing.Size(336, 110);
            this.Adress_txt.TabIndex = 133;
            this.Adress_txt.TextChanged += new System.EventHandler(this.Adress_txt_TextChanged);
            // 
            // Gender_cbb
            // 
            this.Gender_cbb.AutoCompleteCustomSource.AddRange(new string[] {
            "Nam\t",
            "Nữ ",
            "Khác"});
            this.Gender_cbb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Gender_cbb.Enabled = false;
            this.Gender_cbb.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender_cbb.FormattingEnabled = true;
            this.Gender_cbb.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.Gender_cbb.Location = new System.Drawing.Point(122, 290);
            this.Gender_cbb.Name = "Gender_cbb";
            this.Gender_cbb.Size = new System.Drawing.Size(82, 31);
            this.Gender_cbb.TabIndex = 125;
            this.Gender_cbb.Text = "Nam";
            this.Gender_cbb.SelectedValueChanged += new System.EventHandler(this.Gender_cbb_SelectedValueChanged);
            this.Gender_cbb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gender_cbb_KeyDown);
            // 
            // Role_cbb
            // 
            this.Role_cbb.Enabled = false;
            this.Role_cbb.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role_cbb.FormattingEnabled = true;
            this.Role_cbb.Items.AddRange(new object[] {
            "Quản lý",
            "Thu ngân",
            "Phục vụ"});
            this.Role_cbb.Location = new System.Drawing.Point(283, 290);
            this.Role_cbb.Name = "Role_cbb";
            this.Role_cbb.Size = new System.Drawing.Size(123, 31);
            this.Role_cbb.TabIndex = 126;
            this.Role_cbb.Text = "Phục vụ";
            this.Role_cbb.SelectedValueChanged += new System.EventHandler(this.Role_cbb_SelectedValueChanged);
            this.Role_cbb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Role_cbb_KeyDown);
            // 
            // Delete_btn
            // 
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
            this.Delete_btn.Location = new System.Drawing.Point(139, 32);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.ShadowDecoration.Parent = this.Delete_btn;
            this.Delete_btn.Size = new System.Drawing.Size(100, 35);
            this.Delete_btn.TabIndex = 169;
            this.Delete_btn.Text = "Xóa";
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Edit_btn
            // 
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
            this.Edit_btn.Image = global::GUI_QuanLyCafe.Properties.Resources.edit_icon;
            this.Edit_btn.Location = new System.Drawing.Point(261, 32);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.ShadowDecoration.Parent = this.Edit_btn;
            this.Edit_btn.Size = new System.Drawing.Size(100, 35);
            this.Edit_btn.TabIndex = 170;
            this.Edit_btn.Text = "Sửa";
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Edit_ckb);
            this.groupBox1.Controls.Add(this.Edit_btn);
            this.groupBox1.Controls.Add(this.Delete_btn);
            this.groupBox1.Controls.Add(this.Add_btn);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 409);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 82);
            this.groupBox1.TabIndex = 136;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chỉnh sửa";
            // 
            // Edit_ckb
            // 
            this.Edit_ckb.AutoSize = true;
            this.Edit_ckb.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_ckb.Location = new System.Drawing.Point(98, 6);
            this.Edit_ckb.Name = "Edit_ckb";
            this.Edit_ckb.Size = new System.Drawing.Size(15, 14);
            this.Edit_ckb.TabIndex = 14;
            this.Edit_ckb.UseVisualStyleBackColor = true;
            this.Edit_ckb.CheckedChanged += new System.EventHandler(this.Edit_ckb_CheckedChanged);
            // 
            // Add_btn
            // 
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
            this.Add_btn.Location = new System.Drawing.Point(17, 32);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.ShadowDecoration.Parent = this.Add_btn;
            this.Add_btn.Size = new System.Drawing.Size(100, 35);
            this.Add_btn.TabIndex = 168;
            this.Add_btn.Text = "Thêm";
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // BirthDay_lbl
            // 
            this.BirthDay_lbl.AutoSize = true;
            this.BirthDay_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDay_lbl.Location = new System.Drawing.Point(421, 159);
            this.BirthDay_lbl.Name = "BirthDay_lbl";
            this.BirthDay_lbl.Size = new System.Drawing.Size(92, 23);
            this.BirthDay_lbl.TabIndex = 137;
            this.BirthDay_lbl.Text = "Ngày sinh";
            // 
            // BirthDay_date
            // 
            this.BirthDay_date.CustomFormat = "dd/MM/yyyy";
            this.BirthDay_date.Enabled = false;
            this.BirthDay_date.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDay_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BirthDay_date.Location = new System.Drawing.Point(519, 156);
            this.BirthDay_date.Name = "BirthDay_date";
            this.BirthDay_date.Size = new System.Drawing.Size(242, 32);
            this.BirthDay_date.TabIndex = 130;
            this.BirthDay_date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BirthDay_date_KeyDown);
            // 
            // ResetFind_btn
            // 
            this.ResetFind_btn.Animated = true;
            this.ResetFind_btn.BorderRadius = 5;
            this.ResetFind_btn.BorderThickness = 1;
            this.ResetFind_btn.CheckedState.Parent = this.ResetFind_btn;
            this.ResetFind_btn.CustomImages.Parent = this.ResetFind_btn;
            this.ResetFind_btn.FillColor = System.Drawing.Color.White;
            this.ResetFind_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetFind_btn.ForeColor = System.Drawing.Color.Black;
            this.ResetFind_btn.HoverState.Parent = this.ResetFind_btn;
            this.ResetFind_btn.Image = global::GUI_QuanLyCafe.Properties.Resources.Refreshicon;
            this.ResetFind_btn.Location = new System.Drawing.Point(548, 520);
            this.ResetFind_btn.Name = "ResetFind_btn";
            this.ResetFind_btn.ShadowDecoration.Parent = this.ResetFind_btn;
            this.ResetFind_btn.Size = new System.Drawing.Size(32, 31);
            this.ResetFind_btn.TabIndex = 172;
            this.ResetFind_btn.Click += new System.EventHandler(this.ResetFind_btn_Click);
            // 
            // CreateID_btn
            // 
            this.CreateID_btn.Animated = true;
            this.CreateID_btn.BorderThickness = 1;
            this.CreateID_btn.CheckedState.Parent = this.CreateID_btn;
            this.CreateID_btn.CustomImages.Parent = this.CreateID_btn;
            this.CreateID_btn.Enabled = false;
            this.CreateID_btn.FillColor = System.Drawing.Color.White;
            this.CreateID_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateID_btn.ForeColor = System.Drawing.Color.Black;
            this.CreateID_btn.HoverState.Parent = this.CreateID_btn;
            this.CreateID_btn.Image = global::GUI_QuanLyCafe.Properties.Resources.id;
            this.CreateID_btn.Location = new System.Drawing.Point(370, 156);
            this.CreateID_btn.Name = "CreateID_btn";
            this.CreateID_btn.ShadowDecoration.Parent = this.CreateID_btn;
            this.CreateID_btn.Size = new System.Drawing.Size(36, 32);
            this.CreateID_btn.TabIndex = 173;
            this.CreateID_btn.Click += new System.EventHandler(this.CreateID_btn_Click);
            // 
            // Email_lbl
            // 
            this.Email_lbl.AutoSize = true;
            this.Email_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_lbl.Location = new System.Drawing.Point(421, 221);
            this.Email_lbl.Name = "Email_lbl";
            this.Email_lbl.Size = new System.Drawing.Size(60, 23);
            this.Email_lbl.TabIndex = 146;
            this.Email_lbl.Text = "Email";
            // 
            // PathPicture_txt
            // 
            this.PathPicture_txt.Enabled = false;
            this.PathPicture_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathPicture_txt.Location = new System.Drawing.Point(798, 459);
            this.PathPicture_txt.Name = "PathPicture_txt";
            this.PathPicture_txt.ReadOnly = true;
            this.PathPicture_txt.Size = new System.Drawing.Size(50, 32);
            this.PathPicture_txt.TabIndex = 139;
            this.PathPicture_txt.TabStop = false;
            this.PathPicture_txt.Visible = false;
            this.PathPicture_txt.TextChanged += new System.EventHandler(this.PathPicture_txt_TextChanged);
            // 
            // FindBy_cbb
            // 
            this.FindBy_cbb.AutoCompleteCustomSource.AddRange(new string[] {
            "Nam\t",
            "Nữ ",
            "Khác"});
            this.FindBy_cbb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.FindBy_cbb.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindBy_cbb.FormattingEnabled = true;
            this.FindBy_cbb.Items.AddRange(new object[] {
            "Tất cả",
            "Mã số",
            "Họ tên",
            "Vai trò",
            "Giới tính",
            "Email",
            "Số điện thoại",
            "Địa chỉ",
            "Ngày sinh"});
            this.FindBy_cbb.Location = new System.Drawing.Point(412, 520);
            this.FindBy_cbb.Name = "FindBy_cbb";
            this.FindBy_cbb.Size = new System.Drawing.Size(130, 31);
            this.FindBy_cbb.TabIndex = 141;
            this.FindBy_cbb.TabStop = false;
            this.FindBy_cbb.Text = "Tất cả";
            this.FindBy_cbb.SelectedValueChanged += new System.EventHandler(this.FindBy_cbb_SelectedValueChanged);
            this.FindBy_cbb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindBy_cbb_KeyDown);
            // 
            // OpenFilePicture_btn
            // 
            this.OpenFilePicture_btn.Animated = true;
            this.OpenFilePicture_btn.BorderRadius = 5;
            this.OpenFilePicture_btn.BorderThickness = 1;
            this.OpenFilePicture_btn.CheckedState.Parent = this.OpenFilePicture_btn;
            this.OpenFilePicture_btn.CustomImages.Parent = this.OpenFilePicture_btn;
            this.OpenFilePicture_btn.FillColor = System.Drawing.Color.White;
            this.OpenFilePicture_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFilePicture_btn.ForeColor = System.Drawing.Color.Black;
            this.OpenFilePicture_btn.HoverState.Parent = this.OpenFilePicture_btn;
            this.OpenFilePicture_btn.Image = global::GUI_QuanLyCafe.Properties.Resources.folder1;
            this.OpenFilePicture_btn.Location = new System.Drawing.Point(723, 463);
            this.OpenFilePicture_btn.Name = "OpenFilePicture_btn";
            this.OpenFilePicture_btn.ShadowDecoration.Parent = this.OpenFilePicture_btn;
            this.OpenFilePicture_btn.Size = new System.Drawing.Size(38, 29);
            this.OpenFilePicture_btn.TabIndex = 171;
            this.OpenFilePicture_btn.Visible = false;
            this.OpenFilePicture_btn.Click += new System.EventHandler(this.OpenFilePicture_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::GUI_QuanLyCafe.Properties.Resources._1200px_Highlands_Coffee_logo_svg;
            this.pictureBox2.Location = new System.Drawing.Point(5, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 174;
            this.pictureBox2.TabStop = false;
            // 
            // Staff_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1095, 996);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.CreateID_btn);
            this.Controls.Add(this.ResetFind_btn);
            this.Controls.Add(this.OpenFilePicture_btn);
            this.Controls.Add(this.Email_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Log_Menu);
            this.Controls.Add(this.FindBy_cbb);
            this.Controls.Add(this.ListStaff_dgv);
            this.Controls.Add(this.PathPicture_txt);
            this.Controls.Add(this.Picture_ptb);
            this.Controls.Add(this.BirthDay_date);
            this.Controls.Add(this.BirthDay_lbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Role_cbb);
            this.Controls.Add(this.Gender_cbb);
            this.Controls.Add(this.Adress_txt);
            this.Controls.Add(this.Email_txt);
            this.Controls.Add(this.Find_txt);
            this.Controls.Add(this.NameStaff_txt);
            this.Controls.Add(this.PhoneNumber_txt);
            this.Controls.Add(this.IdStafff_txt);
            this.Controls.Add(this.Role_lbl);
            this.Controls.Add(this.Address_lbl);
            this.Controls.Add(this.Gender_lbl);
            this.Controls.Add(this.PhoneNumber_lbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NameStaff_lbl);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Staff_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Staff_frm_FormClosing);
            this.Load += new System.EventHandler(this.Staff_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListStaff_dgv)).EndInit();
            this.Log_Menu.ResumeLayout(false);
            this.Log_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_ptb)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ListStaff_dgv;
        private System.Windows.Forms.MenuStrip Log_Menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem Log_MenuItem;
        private System.Windows.Forms.PictureBox Picture_ptb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NameStaff_lbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label PhoneNumber_lbl;
        private System.Windows.Forms.Label Role_lbl;
        private System.Windows.Forms.Label Address_lbl;
        private System.Windows.Forms.Label Gender_lbl;
        private System.Windows.Forms.TextBox IdStafff_txt;
        private System.Windows.Forms.TextBox PhoneNumber_txt;
        private System.Windows.Forms.TextBox NameStaff_txt;
        private System.Windows.Forms.TextBox Find_txt;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.TextBox Adress_txt;
        private System.Windows.Forms.ComboBox Gender_cbb;
        private System.Windows.Forms.ComboBox Role_cbb;
        private Guna.UI2.WinForms.Guna2Button Delete_btn;
        private Guna.UI2.WinForms.Guna2Button Edit_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Edit_ckb;
        private Guna.UI2.WinForms.Guna2Button Add_btn;
        private System.Windows.Forms.Label BirthDay_lbl;
        private System.Windows.Forms.DateTimePicker BirthDay_date;
        private Guna.UI2.WinForms.Guna2Button ResetFind_btn;
        private Guna.UI2.WinForms.Guna2Button CreateID_btn;
        private System.Windows.Forms.Label Email_lbl;
        private System.Windows.Forms.TextBox PathPicture_txt;
        private System.Windows.Forms.ComboBox FindBy_cbb;
        private Guna.UI2.WinForms.Guna2Button OpenFilePicture_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}