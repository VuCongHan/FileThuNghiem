
namespace GUI_QuanLyCafe
{
    partial class MenuManager_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuManager_frm));
            this.Name_lbl = new System.Windows.Forms.Label();
            this.Price_lbl = new System.Windows.Forms.Label();
            this.ds = new System.Windows.Forms.Label();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.Price_txt = new System.Windows.Forms.TextBox();
            this.Category_cbb = new System.Windows.Forms.ComboBox();
            this.FindBy_cbb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Edit_ckb = new System.Windows.Forms.CheckBox();
            this.Edit_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Add_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Delete_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Find_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MenuList_dgv = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PathPicture_txt = new System.Windows.Forms.TextBox();
            this.NameTemp_txt = new System.Windows.Forms.TextBox();
            this.CreateID_btn = new Guna.UI2.WinForms.Guna2Button();
            this.ResetFind_btn = new Guna.UI2.WinForms.Guna2Button();
            this.OpenFilePicture_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Picture_ptb = new System.Windows.Forms.PictureBox();
            this.Log_Menu = new System.Windows.Forms.MenuStrip();
            this.Log_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuList_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_ptb)).BeginInit();
            this.Log_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_lbl.Location = new System.Drawing.Point(12, 140);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(77, 21);
            this.Name_lbl.TabIndex = 0;
            this.Name_lbl.Text = "Tên món";
            // 
            // Price_lbl
            // 
            this.Price_lbl.AutoSize = true;
            this.Price_lbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_lbl.Location = new System.Drawing.Point(12, 191);
            this.Price_lbl.Name = "Price_lbl";
            this.Price_lbl.Size = new System.Drawing.Size(36, 21);
            this.Price_lbl.TabIndex = 1;
            this.Price_lbl.Text = "Giá";
            // 
            // ds
            // 
            this.ds.AutoSize = true;
            this.ds.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ds.Location = new System.Drawing.Point(12, 244);
            this.ds.Name = "ds";
            this.ds.Size = new System.Drawing.Size(86, 21);
            this.ds.TabIndex = 2;
            this.ds.Text = "Danh mục";
            // 
            // Name_txt
            // 
            this.Name_txt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_txt.Location = new System.Drawing.Point(104, 137);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.ReadOnly = true;
            this.Name_txt.Size = new System.Drawing.Size(236, 29);
            this.Name_txt.TabIndex = 3;
            this.Name_txt.TextChanged += new System.EventHandler(this.Name_txt_TextChanged);
            // 
            // Price_txt
            // 
            this.Price_txt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_txt.Location = new System.Drawing.Point(104, 188);
            this.Price_txt.Name = "Price_txt";
            this.Price_txt.ReadOnly = true;
            this.Price_txt.Size = new System.Drawing.Size(224, 29);
            this.Price_txt.TabIndex = 4;
            this.Price_txt.TextChanged += new System.EventHandler(this.Price_txt_TextChanged);
            this.Price_txt.Leave += new System.EventHandler(this.Price_txt_Leave);
            // 
            // Category_cbb
            // 
            this.Category_cbb.Enabled = false;
            this.Category_cbb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_cbb.FormattingEnabled = true;
            this.Category_cbb.Location = new System.Drawing.Point(104, 244);
            this.Category_cbb.Name = "Category_cbb";
            this.Category_cbb.Size = new System.Drawing.Size(271, 29);
            this.Category_cbb.TabIndex = 5;
            this.Category_cbb.SelectedValueChanged += new System.EventHandler(this.Category_cbb_SelectedValueChanged);
            this.Category_cbb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Category_cbb_KeyDown);
            // 
            // FindBy_cbb
            // 
            this.FindBy_cbb.AutoCompleteCustomSource.AddRange(new string[] {
            "Nam\t",
            "Nữ ",
            "Khác"});
            this.FindBy_cbb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.FindBy_cbb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindBy_cbb.FormattingEnabled = true;
            this.FindBy_cbb.Items.AddRange(new object[] {
            "Tất cả",
            "Mã số",
            "Họ tên",
            "Giới tính",
            "Email",
            "Số điện thoại",
            "Địa chỉ",
            "Ngày sinh"});
            this.FindBy_cbb.Location = new System.Drawing.Point(381, 384);
            this.FindBy_cbb.Name = "FindBy_cbb";
            this.FindBy_cbb.Size = new System.Drawing.Size(123, 29);
            this.FindBy_cbb.TabIndex = 126;
            this.FindBy_cbb.TabStop = false;
            this.FindBy_cbb.Text = "Tất cả";
            this.FindBy_cbb.SelectedValueChanged += new System.EventHandler(this.FindBy_cbb_SelectedValueChanged);
            this.FindBy_cbb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindBy_cbb_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Edit_ckb);
            this.groupBox1.Controls.Add(this.Edit_btn);
            this.groupBox1.Controls.Add(this.Add_btn);
            this.groupBox1.Controls.Add(this.Delete_btn);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 71);
            this.groupBox1.TabIndex = 125;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chỉnh sửa";
            // 
            // Edit_ckb
            // 
            this.Edit_ckb.AutoSize = true;
            this.Edit_ckb.Location = new System.Drawing.Point(92, 4);
            this.Edit_ckb.Name = "Edit_ckb";
            this.Edit_ckb.Size = new System.Drawing.Size(15, 14);
            this.Edit_ckb.TabIndex = 14;
            this.Edit_ckb.TabStop = false;
            this.Edit_ckb.UseVisualStyleBackColor = true;
            this.Edit_ckb.CheckedChanged += new System.EventHandler(this.Edit_ckb_CheckedChanged);
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
            this.Edit_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_btn.ForeColor = System.Drawing.Color.Black;
            this.Edit_btn.HoverState.Parent = this.Edit_btn;
            this.Edit_btn.Image = global::GUI_QuanLyCafe.Properties.Resources.edit_icon;
            this.Edit_btn.Location = new System.Drawing.Point(249, 29);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.ShadowDecoration.Parent = this.Edit_btn;
            this.Edit_btn.Size = new System.Drawing.Size(90, 30);
            this.Edit_btn.TabIndex = 164;
            this.Edit_btn.Text = "Sửa";
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
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
            this.Add_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.ForeColor = System.Drawing.Color.Black;
            this.Add_btn.HoverState.Parent = this.Add_btn;
            this.Add_btn.Image = global::GUI_QuanLyCafe.Properties.Resources.add_icon;
            this.Add_btn.Location = new System.Drawing.Point(17, 29);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.ShadowDecoration.Parent = this.Add_btn;
            this.Add_btn.Size = new System.Drawing.Size(90, 30);
            this.Add_btn.TabIndex = 162;
            this.Add_btn.Text = "Thêm";
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
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
            this.Delete_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.ForeColor = System.Drawing.Color.Black;
            this.Delete_btn.HoverState.Parent = this.Delete_btn;
            this.Delete_btn.Image = global::GUI_QuanLyCafe.Properties.Resources.Actions_edit_delete_icon;
            this.Delete_btn.Location = new System.Drawing.Point(130, 29);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.ShadowDecoration.Parent = this.Delete_btn;
            this.Delete_btn.Size = new System.Drawing.Size(90, 30);
            this.Delete_btn.TabIndex = 163;
            this.Delete_btn.Text = "Xóa";
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Find_txt
            // 
            this.Find_txt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Find_txt.Location = new System.Drawing.Point(104, 384);
            this.Find_txt.Name = "Find_txt";
            this.Find_txt.Size = new System.Drawing.Size(271, 29);
            this.Find_txt.TabIndex = 123;
            this.Find_txt.TabStop = false;
            this.Find_txt.TextChanged += new System.EventHandler(this.Find_txt_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 21);
            this.label9.TabIndex = 122;
            this.label9.Text = "Tìm kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 31);
            this.label3.TabIndex = 127;
            this.label3.Text = "QUẢN  LÝ MENU";
            // 
            // MenuList_dgv
            // 
            this.MenuList_dgv.AllowUserToAddRows = false;
            this.MenuList_dgv.AllowUserToDeleteRows = false;
            this.MenuList_dgv.AllowUserToResizeColumns = false;
            this.MenuList_dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MenuList_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MenuList_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MenuList_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MenuList_dgv.BackgroundColor = System.Drawing.Color.White;
            this.MenuList_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MenuList_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MenuList_dgv.ColumnHeadersHeight = 40;
            this.MenuList_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MenuList_dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.MenuList_dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.MenuList_dgv.Location = new System.Drawing.Point(12, 430);
            this.MenuList_dgv.MultiSelect = false;
            this.MenuList_dgv.Name = "MenuList_dgv";
            this.MenuList_dgv.ReadOnly = true;
            this.MenuList_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MenuList_dgv.RowHeadersVisible = false;
            this.MenuList_dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuList_dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.MenuList_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MenuList_dgv.ShowCellErrors = false;
            this.MenuList_dgv.ShowCellToolTips = false;
            this.MenuList_dgv.ShowEditingIcon = false;
            this.MenuList_dgv.ShowRowErrors = false;
            this.MenuList_dgv.Size = new System.Drawing.Size(622, 200);
            this.MenuList_dgv.TabIndex = 168;
            this.MenuList_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MenuList_dgv_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(327, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(48, 29);
            this.textBox1.TabIndex = 169;
            this.textBox1.Text = "VNĐ";
            // 
            // PathPicture_txt
            // 
            this.PathPicture_txt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathPicture_txt.Location = new System.Drawing.Point(437, 334);
            this.PathPicture_txt.Name = "PathPicture_txt";
            this.PathPicture_txt.ReadOnly = true;
            this.PathPicture_txt.Size = new System.Drawing.Size(36, 29);
            this.PathPicture_txt.TabIndex = 170;
            this.PathPicture_txt.TabStop = false;
            this.PathPicture_txt.Visible = false;
            // 
            // NameTemp_txt
            // 
            this.NameTemp_txt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTemp_txt.Location = new System.Drawing.Point(381, 137);
            this.NameTemp_txt.Name = "NameTemp_txt";
            this.NameTemp_txt.ReadOnly = true;
            this.NameTemp_txt.Size = new System.Drawing.Size(50, 29);
            this.NameTemp_txt.TabIndex = 171;
            this.NameTemp_txt.Visible = false;
            // 
            // CreateID_btn
            // 
            this.CreateID_btn.Animated = true;
            this.CreateID_btn.BorderThickness = 1;
            this.CreateID_btn.CheckedState.Parent = this.CreateID_btn;
            this.CreateID_btn.CustomImages.Parent = this.CreateID_btn;
            this.CreateID_btn.Enabled = false;
            this.CreateID_btn.FillColor = System.Drawing.Color.White;
            this.CreateID_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateID_btn.ForeColor = System.Drawing.Color.Black;
            this.CreateID_btn.HoverState.Parent = this.CreateID_btn;
            this.CreateID_btn.Image = global::GUI_QuanLyCafe.Properties.Resources.id;
            this.CreateID_btn.Location = new System.Drawing.Point(339, 137);
            this.CreateID_btn.Name = "CreateID_btn";
            this.CreateID_btn.ShadowDecoration.Parent = this.CreateID_btn;
            this.CreateID_btn.Size = new System.Drawing.Size(36, 29);
            this.CreateID_btn.TabIndex = 174;
            this.CreateID_btn.Click += new System.EventHandler(this.CreateID_btn_Click);
            // 
            // ResetFind_btn
            // 
            this.ResetFind_btn.Animated = true;
            this.ResetFind_btn.BorderRadius = 5;
            this.ResetFind_btn.BorderThickness = 1;
            this.ResetFind_btn.CheckedState.Parent = this.ResetFind_btn;
            this.ResetFind_btn.CustomImages.Parent = this.ResetFind_btn;
            this.ResetFind_btn.FillColor = System.Drawing.Color.White;
            this.ResetFind_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetFind_btn.ForeColor = System.Drawing.Color.Black;
            this.ResetFind_btn.HoverState.Parent = this.ResetFind_btn;
            this.ResetFind_btn.Image = global::GUI_QuanLyCafe.Properties.Resources.Refreshicon;
            this.ResetFind_btn.Location = new System.Drawing.Point(510, 384);
            this.ResetFind_btn.Name = "ResetFind_btn";
            this.ResetFind_btn.ShadowDecoration.Parent = this.ResetFind_btn;
            this.ResetFind_btn.Size = new System.Drawing.Size(32, 29);
            this.ResetFind_btn.TabIndex = 166;
            this.ResetFind_btn.Click += new System.EventHandler(this.ResetFind_btn_Click);
            // 
            // OpenFilePicture_btn
            // 
            this.OpenFilePicture_btn.Animated = true;
            this.OpenFilePicture_btn.BorderRadius = 5;
            this.OpenFilePicture_btn.BorderThickness = 1;
            this.OpenFilePicture_btn.CheckedState.Parent = this.OpenFilePicture_btn;
            this.OpenFilePicture_btn.CustomImages.Parent = this.OpenFilePicture_btn;
            this.OpenFilePicture_btn.Enabled = false;
            this.OpenFilePicture_btn.FillColor = System.Drawing.Color.White;
            this.OpenFilePicture_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFilePicture_btn.ForeColor = System.Drawing.Color.Black;
            this.OpenFilePicture_btn.HoverState.Parent = this.OpenFilePicture_btn;
            this.OpenFilePicture_btn.Image = global::GUI_QuanLyCafe.Properties.Resources.folder1;
            this.OpenFilePicture_btn.Location = new System.Drawing.Point(393, 334);
            this.OpenFilePicture_btn.Name = "OpenFilePicture_btn";
            this.OpenFilePicture_btn.ShadowDecoration.Parent = this.OpenFilePicture_btn;
            this.OpenFilePicture_btn.Size = new System.Drawing.Size(38, 29);
            this.OpenFilePicture_btn.TabIndex = 165;
            this.OpenFilePicture_btn.Visible = false;
            this.OpenFilePicture_btn.Click += new System.EventHandler(this.OpenFilePicture_btn_Click);
            // 
            // Picture_ptb
            // 
            this.Picture_ptb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Picture_ptb.Image = global::GUI_QuanLyCafe.Properties.Resources.questionmark;
            this.Picture_ptb.Location = new System.Drawing.Point(437, 137);
            this.Picture_ptb.Name = "Picture_ptb";
            this.Picture_ptb.Size = new System.Drawing.Size(197, 226);
            this.Picture_ptb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture_ptb.TabIndex = 7;
            this.Picture_ptb.TabStop = false;
            // 
            // Log_Menu
            // 
            this.Log_Menu.BackColor = System.Drawing.Color.Transparent;
            this.Log_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Log_MenuItem});
            this.Log_Menu.Location = new System.Drawing.Point(0, 0);
            this.Log_Menu.Name = "Log_Menu";
            this.Log_Menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Log_Menu.Size = new System.Drawing.Size(647, 40);
            this.Log_Menu.TabIndex = 175;
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
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::GUI_QuanLyCafe.Properties.Resources._1200px_Highlands_Coffee_logo_svg;
            this.pictureBox2.Location = new System.Drawing.Point(5, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 176;
            this.pictureBox2.TabStop = false;
            // 
            // MenuManager_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(647, 636);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Log_Menu);
            this.Controls.Add(this.CreateID_btn);
            this.Controls.Add(this.NameTemp_txt);
            this.Controls.Add(this.PathPicture_txt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MenuList_dgv);
            this.Controls.Add(this.ResetFind_btn);
            this.Controls.Add(this.OpenFilePicture_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FindBy_cbb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Find_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Picture_ptb);
            this.Controls.Add(this.Category_cbb);
            this.Controls.Add(this.Price_txt);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.ds);
            this.Controls.Add(this.Price_lbl);
            this.Controls.Add(this.Name_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuManager_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuManager_frm_FormClosing);
            this.Load += new System.EventHandler(this.MenuManager_frm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuList_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_ptb)).EndInit();
            this.Log_Menu.ResumeLayout(false);
            this.Log_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.Label Price_lbl;
        private System.Windows.Forms.Label ds;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.TextBox Price_txt;
        private System.Windows.Forms.ComboBox Category_cbb;
        private System.Windows.Forms.PictureBox Picture_ptb;
        private System.Windows.Forms.ComboBox FindBy_cbb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Edit_ckb;
        private System.Windows.Forms.TextBox Find_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button Edit_btn;
        private Guna.UI2.WinForms.Guna2Button Add_btn;
        private Guna.UI2.WinForms.Guna2Button Delete_btn;
        private Guna.UI2.WinForms.Guna2Button ResetFind_btn;
        private Guna.UI2.WinForms.Guna2Button OpenFilePicture_btn;
        private System.Windows.Forms.DataGridView MenuList_dgv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox PathPicture_txt;
        private System.Windows.Forms.TextBox NameTemp_txt;
        private Guna.UI2.WinForms.Guna2Button CreateID_btn;
        private System.Windows.Forms.MenuStrip Log_Menu;
        private System.Windows.Forms.ToolStripMenuItem Log_MenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}