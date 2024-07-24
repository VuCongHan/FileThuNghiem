
namespace GUI_QuanLyCafe
{
    partial class Material_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Material_frm));
            this.Edit_ckb = new System.Windows.Forms.CheckBox();
            this.Status_txt = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.Type_cbb = new System.Windows.Forms.ComboBox();
            this.PathPicture_txt = new System.Windows.Forms.TextBox();
            this.Type_lbl = new System.Windows.Forms.Label();
            this.Producer_txt = new System.Windows.Forms.TextBox();
            this.Producer_lbl = new System.Windows.Forms.Label();
            this.ListMaterial_dgv = new System.Windows.Forms.DataGridView();
            this.Amount_txt = new System.Windows.Forms.TextBox();
            this.Log_Menu = new System.Windows.Forms.MenuStrip();
            this.Log_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Date_date = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Edit_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Delete_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Add_btn = new Guna.UI2.WinForms.Guna2Button();
            this.VND_txt = new System.Windows.Forms.TextBox();
            this.Price_txt = new System.Windows.Forms.TextBox();
            this.Find_txt = new System.Windows.Forms.TextBox();
            this.NameMaterial_txt = new System.Windows.Forms.TextBox();
            this.IdMaterial_txt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Price_lbl = new System.Windows.Forms.Label();
            this.Amount_lbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NameMaterial__lbl = new System.Windows.Forms.Label();
            this.IdMaterial_lbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CreateID_btn = new Guna.UI2.WinForms.Guna2Button();
            this.ResetFind_btn = new Guna.UI2.WinForms.Guna2Button();
            this.OpenFilePicture_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Picture_ptb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListMaterial_dgv)).BeginInit();
            this.Log_Menu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_ptb)).BeginInit();
            this.SuspendLayout();
            // 
            // Edit_ckb
            // 
            this.Edit_ckb.AutoSize = true;
            this.Edit_ckb.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_ckb.Location = new System.Drawing.Point(97, 6);
            this.Edit_ckb.Name = "Edit_ckb";
            this.Edit_ckb.Size = new System.Drawing.Size(15, 14);
            this.Edit_ckb.TabIndex = 14;
            this.Edit_ckb.UseVisualStyleBackColor = true;
            this.Edit_ckb.CheckedChanged += new System.EventHandler(this.Edit_ckb_CheckedChanged);
            // 
            // Status_txt
            // 
            this.Status_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_txt.Location = new System.Drawing.Point(581, 250);
            this.Status_txt.Name = "Status_txt";
            this.Status_txt.ReadOnly = true;
            this.Status_txt.Size = new System.Drawing.Size(144, 32);
            this.Status_txt.TabIndex = 116;
            this.Status_txt.TabStop = false;
            this.Status_txt.Text = "Hết hàng";
            this.Status_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(482, 253);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(93, 23);
            this.label22.TabIndex = 145;
            this.label22.Text = "Trạng thái";
            // 
            // Type_cbb
            // 
            this.Type_cbb.BackColor = System.Drawing.Color.White;
            this.Type_cbb.Enabled = false;
            this.Type_cbb.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_cbb.FormattingEnabled = true;
            this.Type_cbb.Items.AddRange(new object[] {
            "Cái",
            "Chai/Lon",
            "Gói",
            "Hộp"});
            this.Type_cbb.Location = new System.Drawing.Point(347, 250);
            this.Type_cbb.Name = "Type_cbb";
            this.Type_cbb.Size = new System.Drawing.Size(119, 31);
            this.Type_cbb.TabIndex = 115;
            this.Type_cbb.SelectedValueChanged += new System.EventHandler(this.Type_cbb_SelectedValueChanged);
            this.Type_cbb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Type_cbb_KeyDown);
            // 
            // PathPicture_txt
            // 
            this.PathPicture_txt.Enabled = false;
            this.PathPicture_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathPicture_txt.Location = new System.Drawing.Point(934, 404);
            this.PathPicture_txt.Name = "PathPicture_txt";
            this.PathPicture_txt.ReadOnly = true;
            this.PathPicture_txt.Size = new System.Drawing.Size(50, 32);
            this.PathPicture_txt.TabIndex = 144;
            this.PathPicture_txt.TabStop = false;
            this.PathPicture_txt.Visible = false;
            this.PathPicture_txt.TextChanged += new System.EventHandler(this.PathPicture_txt_TextChanged);
            // 
            // Type_lbl
            // 
            this.Type_lbl.AutoSize = true;
            this.Type_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_lbl.Location = new System.Drawing.Point(235, 253);
            this.Type_lbl.Name = "Type_lbl";
            this.Type_lbl.Size = new System.Drawing.Size(104, 23);
            this.Type_lbl.TabIndex = 141;
            this.Type_lbl.Text = "Đơn vị tính";
            // 
            // Producer_txt
            // 
            this.Producer_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Producer_txt.Location = new System.Drawing.Point(164, 303);
            this.Producer_txt.Name = "Producer_txt";
            this.Producer_txt.ReadOnly = true;
            this.Producer_txt.Size = new System.Drawing.Size(302, 32);
            this.Producer_txt.TabIndex = 117;
            this.Producer_txt.TextChanged += new System.EventHandler(this.Producer_txt_TextChanged);
            // 
            // Producer_lbl
            // 
            this.Producer_lbl.AutoSize = true;
            this.Producer_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Producer_lbl.Location = new System.Drawing.Point(41, 306);
            this.Producer_lbl.Name = "Producer_lbl";
            this.Producer_lbl.Size = new System.Drawing.Size(117, 23);
            this.Producer_lbl.TabIndex = 140;
            this.Producer_lbl.Text = "Nhà sản xuất";
            // 
            // ListMaterial_dgv
            // 
            this.ListMaterial_dgv.AllowUserToAddRows = false;
            this.ListMaterial_dgv.AllowUserToDeleteRows = false;
            this.ListMaterial_dgv.AllowUserToResizeColumns = false;
            this.ListMaterial_dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ListMaterial_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListMaterial_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListMaterial_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ListMaterial_dgv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListMaterial_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListMaterial_dgv.ColumnHeadersHeight = 40;
            this.ListMaterial_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListMaterial_dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.ListMaterial_dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ListMaterial_dgv.Location = new System.Drawing.Point(45, 462);
            this.ListMaterial_dgv.MultiSelect = false;
            this.ListMaterial_dgv.Name = "ListMaterial_dgv";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListMaterial_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ListMaterial_dgv.RowHeadersVisible = false;
            this.ListMaterial_dgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListMaterial_dgv.RowTemplate.Height = 3;
            this.ListMaterial_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListMaterial_dgv.ShowCellErrors = false;
            this.ListMaterial_dgv.ShowCellToolTips = false;
            this.ListMaterial_dgv.ShowEditingIcon = false;
            this.ListMaterial_dgv.ShowRowErrors = false;
            this.ListMaterial_dgv.Size = new System.Drawing.Size(1157, 371);
            this.ListMaterial_dgv.TabIndex = 131;
            this.ListMaterial_dgv.TabStop = false;
            this.ListMaterial_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListMaterial_dgv_CellClick);
            // 
            // Amount_txt
            // 
            this.Amount_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount_txt.Location = new System.Drawing.Point(142, 250);
            this.Amount_txt.Name = "Amount_txt";
            this.Amount_txt.ReadOnly = true;
            this.Amount_txt.Size = new System.Drawing.Size(87, 32);
            this.Amount_txt.TabIndex = 114;
            this.Amount_txt.Text = "0";
            this.Amount_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Amount_txt.TextChanged += new System.EventHandler(this.Amount_txt_TextChanged);
            // 
            // Log_Menu
            // 
            this.Log_Menu.BackColor = System.Drawing.Color.Transparent;
            this.Log_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Log_MenuItem});
            this.Log_Menu.Location = new System.Drawing.Point(0, 0);
            this.Log_Menu.Name = "Log_Menu";
            this.Log_Menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Log_Menu.Size = new System.Drawing.Size(1237, 40);
            this.Log_Menu.TabIndex = 149;
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
            // Date_date
            // 
            this.Date_date.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_date.CustomFormat = "dd/MM/yyyy";
            this.Date_date.Enabled = false;
            this.Date_date.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_date.Location = new System.Drawing.Point(627, 197);
            this.Date_date.Name = "Date_date";
            this.Date_date.Size = new System.Drawing.Size(288, 32);
            this.Date_date.TabIndex = 119;
            this.Date_date.CloseUp += new System.EventHandler(this.Date_date_CloseUp);
            this.Date_date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Date_date_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Edit_btn);
            this.groupBox1.Controls.Add(this.Delete_btn);
            this.groupBox1.Controls.Add(this.Edit_ckb);
            this.groupBox1.Controls.Add(this.Add_btn);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 88);
            this.groupBox1.TabIndex = 135;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chỉnh sửa";
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
            this.Edit_btn.Location = new System.Drawing.Point(293, 34);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.ShadowDecoration.Parent = this.Edit_btn;
            this.Edit_btn.Size = new System.Drawing.Size(95, 40);
            this.Edit_btn.TabIndex = 158;
            this.Edit_btn.Text = "Sửa";
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
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
            this.Delete_btn.Location = new System.Drawing.Point(163, 34);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.ShadowDecoration.Parent = this.Delete_btn;
            this.Delete_btn.Size = new System.Drawing.Size(95, 40);
            this.Delete_btn.TabIndex = 157;
            this.Delete_btn.Text = "Xóa";
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
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
            this.Add_btn.Location = new System.Drawing.Point(31, 34);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.ShadowDecoration.Parent = this.Add_btn;
            this.Add_btn.Size = new System.Drawing.Size(95, 40);
            this.Add_btn.TabIndex = 156;
            this.Add_btn.Text = "Thêm";
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // VND_txt
            // 
            this.VND_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VND_txt.Location = new System.Drawing.Point(864, 143);
            this.VND_txt.Name = "VND_txt";
            this.VND_txt.ReadOnly = true;
            this.VND_txt.Size = new System.Drawing.Size(51, 32);
            this.VND_txt.TabIndex = 132;
            this.VND_txt.TabStop = false;
            this.VND_txt.Text = "VNĐ";
            this.VND_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Price_txt
            // 
            this.Price_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_txt.Location = new System.Drawing.Point(628, 143);
            this.Price_txt.Name = "Price_txt";
            this.Price_txt.ReadOnly = true;
            this.Price_txt.Size = new System.Drawing.Size(237, 32);
            this.Price_txt.TabIndex = 118;
            this.Price_txt.Text = "0";
            this.Price_txt.TextChanged += new System.EventHandler(this.Price_txt_TextChanged);
            this.Price_txt.Leave += new System.EventHandler(this.Price_txt_Leave);
            // 
            // Find_txt
            // 
            this.Find_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Find_txt.Location = new System.Drawing.Point(563, 404);
            this.Find_txt.Name = "Find_txt";
            this.Find_txt.Size = new System.Drawing.Size(315, 32);
            this.Find_txt.TabIndex = 133;
            this.Find_txt.TabStop = false;
            this.Find_txt.TextChanged += new System.EventHandler(this.Find_txt_TextChanged);
            // 
            // NameMaterial_txt
            // 
            this.NameMaterial_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameMaterial_txt.Location = new System.Drawing.Point(192, 197);
            this.NameMaterial_txt.Name = "NameMaterial_txt";
            this.NameMaterial_txt.ReadOnly = true;
            this.NameMaterial_txt.Size = new System.Drawing.Size(274, 32);
            this.NameMaterial_txt.TabIndex = 113;
            this.NameMaterial_txt.TextChanged += new System.EventHandler(this.NameMaterial_txt_TextChanged);
            // 
            // IdMaterial_txt
            // 
            this.IdMaterial_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.IdMaterial_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdMaterial_txt.Location = new System.Drawing.Point(192, 141);
            this.IdMaterial_txt.Name = "IdMaterial_txt";
            this.IdMaterial_txt.ReadOnly = true;
            this.IdMaterial_txt.Size = new System.Drawing.Size(241, 32);
            this.IdMaterial_txt.TabIndex = 112;
            this.IdMaterial_txt.TextChanged += new System.EventHandler(this.IdMaterial_txt_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(480, 200);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 23);
            this.label14.TabIndex = 127;
            this.label14.Text = "Ngày nhập hàng";
            // 
            // Price_lbl
            // 
            this.Price_lbl.AutoSize = true;
            this.Price_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_lbl.Location = new System.Drawing.Point(479, 146);
            this.Price_lbl.Name = "Price_lbl";
            this.Price_lbl.Size = new System.Drawing.Size(141, 23);
            this.Price_lbl.TabIndex = 125;
            this.Price_lbl.Text = "Giá nguyên liệu";
            // 
            // Amount_lbl
            // 
            this.Amount_lbl.AutoSize = true;
            this.Amount_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount_lbl.Location = new System.Drawing.Point(41, 253);
            this.Amount_lbl.Name = "Amount_lbl";
            this.Amount_lbl.Size = new System.Drawing.Size(85, 23);
            this.Amount_lbl.TabIndex = 124;
            this.Amount_lbl.Text = "Số lượng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(467, 407);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 23);
            this.label9.TabIndex = 123;
            this.label9.Text = "Tìm kiếm";
            // 
            // NameMaterial__lbl
            // 
            this.NameMaterial__lbl.AutoSize = true;
            this.NameMaterial__lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameMaterial__lbl.Location = new System.Drawing.Point(41, 203);
            this.NameMaterial__lbl.Name = "NameMaterial__lbl";
            this.NameMaterial__lbl.Size = new System.Drawing.Size(142, 23);
            this.NameMaterial__lbl.TabIndex = 122;
            this.NameMaterial__lbl.Text = "Tên nguyên liệu";
            // 
            // IdMaterial_lbl
            // 
            this.IdMaterial_lbl.AutoSize = true;
            this.IdMaterial_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdMaterial_lbl.Location = new System.Drawing.Point(41, 146);
            this.IdMaterial_lbl.Name = "IdMaterial_lbl";
            this.IdMaterial_lbl.Size = new System.Drawing.Size(138, 23);
            this.IdMaterial_lbl.TabIndex = 129;
            this.IdMaterial_lbl.Text = "Mã nguyên liệu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(477, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(375, 31);
            this.label12.TabIndex = 121;
            this.label12.Text = "DANH SÁCH NGUYÊN LIỆU";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::GUI_QuanLyCafe.Properties.Resources._1200px_Highlands_Coffee_logo_svg;
            this.pictureBox2.Location = new System.Drawing.Point(5, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 162;
            this.pictureBox2.TabStop = false;
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
            this.CreateID_btn.Location = new System.Drawing.Point(430, 141);
            this.CreateID_btn.Name = "CreateID_btn";
            this.CreateID_btn.ShadowDecoration.Parent = this.CreateID_btn;
            this.CreateID_btn.Size = new System.Drawing.Size(36, 32);
            this.CreateID_btn.TabIndex = 161;
            this.CreateID_btn.Click += new System.EventHandler(this.CreateID_btn_Click);
            // 
            // ResetFind_btn
            // 
            this.ResetFind_btn.Animated = true;
            this.ResetFind_btn.BorderThickness = 1;
            this.ResetFind_btn.CheckedState.Parent = this.ResetFind_btn;
            this.ResetFind_btn.CustomImages.Parent = this.ResetFind_btn;
            this.ResetFind_btn.Enabled = false;
            this.ResetFind_btn.FillColor = System.Drawing.Color.White;
            this.ResetFind_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetFind_btn.ForeColor = System.Drawing.Color.Black;
            this.ResetFind_btn.HoverState.Parent = this.ResetFind_btn;
            this.ResetFind_btn.Image = global::GUI_QuanLyCafe.Properties.Resources.Refreshicon;
            this.ResetFind_btn.Location = new System.Drawing.Point(877, 404);
            this.ResetFind_btn.Name = "ResetFind_btn";
            this.ResetFind_btn.ShadowDecoration.Parent = this.ResetFind_btn;
            this.ResetFind_btn.Size = new System.Drawing.Size(38, 32);
            this.ResetFind_btn.TabIndex = 160;
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
            this.OpenFilePicture_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFilePicture_btn.ForeColor = System.Drawing.Color.Black;
            this.OpenFilePicture_btn.HoverState.Parent = this.OpenFilePicture_btn;
            this.OpenFilePicture_btn.Image = global::GUI_QuanLyCafe.Properties.Resources.folder1;
            this.OpenFilePicture_btn.Location = new System.Drawing.Point(877, 250);
            this.OpenFilePicture_btn.Name = "OpenFilePicture_btn";
            this.OpenFilePicture_btn.ShadowDecoration.Parent = this.OpenFilePicture_btn;
            this.OpenFilePicture_btn.Size = new System.Drawing.Size(38, 32);
            this.OpenFilePicture_btn.TabIndex = 159;
            this.OpenFilePicture_btn.Visible = false;
            this.OpenFilePicture_btn.Click += new System.EventHandler(this.OpenFilePicture_btn_Click);
            // 
            // Picture_ptb
            // 
            this.Picture_ptb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Picture_ptb.Location = new System.Drawing.Point(934, 141);
            this.Picture_ptb.Name = "Picture_ptb";
            this.Picture_ptb.Size = new System.Drawing.Size(268, 295);
            this.Picture_ptb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture_ptb.TabIndex = 137;
            this.Picture_ptb.TabStop = false;
            // 
            // Material_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1237, 863);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.CreateID_btn);
            this.Controls.Add(this.ResetFind_btn);
            this.Controls.Add(this.OpenFilePicture_btn);
            this.Controls.Add(this.Status_txt);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.Type_cbb);
            this.Controls.Add(this.PathPicture_txt);
            this.Controls.Add(this.Type_lbl);
            this.Controls.Add(this.Producer_txt);
            this.Controls.Add(this.Producer_lbl);
            this.Controls.Add(this.Picture_ptb);
            this.Controls.Add(this.ListMaterial_dgv);
            this.Controls.Add(this.Amount_txt);
            this.Controls.Add(this.Log_Menu);
            this.Controls.Add(this.Date_date);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.VND_txt);
            this.Controls.Add(this.Price_txt);
            this.Controls.Add(this.Find_txt);
            this.Controls.Add(this.NameMaterial_txt);
            this.Controls.Add(this.IdMaterial_txt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Price_lbl);
            this.Controls.Add(this.Amount_lbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NameMaterial__lbl);
            this.Controls.Add(this.IdMaterial_lbl);
            this.Controls.Add(this.label12);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Material_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nguyên liệu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Material_frm_FormClosing);
            this.Load += new System.EventHandler(this.Material_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListMaterial_dgv)).EndInit();
            this.Log_Menu.ResumeLayout(false);
            this.Log_Menu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_ptb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Edit_ckb;
        private System.Windows.Forms.TextBox Status_txt;
        private System.Windows.Forms.ToolStripMenuItem Log_MenuItem;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox Type_cbb;
        private System.Windows.Forms.TextBox PathPicture_txt;
        private System.Windows.Forms.Label Type_lbl;
        private System.Windows.Forms.TextBox Producer_txt;
        private System.Windows.Forms.Label Producer_lbl;
        private System.Windows.Forms.PictureBox Picture_ptb;
        private System.Windows.Forms.DataGridView ListMaterial_dgv;
        private System.Windows.Forms.TextBox Amount_txt;
        private System.Windows.Forms.MenuStrip Log_Menu;
        private System.Windows.Forms.DateTimePicker Date_date;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox VND_txt;
        private System.Windows.Forms.TextBox Price_txt;
        private System.Windows.Forms.TextBox Find_txt;
        private System.Windows.Forms.TextBox NameMaterial_txt;
        private System.Windows.Forms.TextBox IdMaterial_txt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Price_lbl;
        private System.Windows.Forms.Label Amount_lbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label NameMaterial__lbl;
        private System.Windows.Forms.Label IdMaterial_lbl;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Button Edit_btn;
        private Guna.UI2.WinForms.Guna2Button Delete_btn;
        private Guna.UI2.WinForms.Guna2Button Add_btn;
        private Guna.UI2.WinForms.Guna2Button OpenFilePicture_btn;
        private Guna.UI2.WinForms.Guna2Button ResetFind_btn;
        private Guna.UI2.WinForms.Guna2Button CreateID_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}