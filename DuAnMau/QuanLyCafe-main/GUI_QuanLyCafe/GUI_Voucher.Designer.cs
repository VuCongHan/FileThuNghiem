
namespace GUI_QuanLyCafe
{
    partial class Voucher_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Voucher_frm));
            this.Find_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Edit_ckb = new System.Windows.Forms.CheckBox();
            this.Delete_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Edit_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Add_btn = new Guna.UI2.WinForms.Guna2Button();
            this.ListVoucher_dgv = new System.Windows.Forms.DataGridView();
            this.IdVoucher_lbl = new System.Windows.Forms.Label();
            this.IdVoucher_txt = new System.Windows.Forms.TextBox();
            this.Percent_lbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NameVoucher_txt = new System.Windows.Forms.TextBox();
            this.Percent_txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CreateID_btn = new Guna.UI2.WinForms.Guna2Button();
            this.NameVoucher_lbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Log_Menu = new System.Windows.Forms.MenuStrip();
            this.Log_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetFind_btn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListVoucher_dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Log_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Find_txt
            // 
            this.Find_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Find_txt.Location = new System.Drawing.Point(559, 133);
            this.Find_txt.Name = "Find_txt";
            this.Find_txt.Size = new System.Drawing.Size(366, 32);
            this.Find_txt.TabIndex = 120;
            this.Find_txt.TabStop = false;
            this.Find_txt.TextChanged += new System.EventHandler(this.Find_txt_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(463, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 23);
            this.label9.TabIndex = 119;
            this.label9.Text = "Tìm kiếm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Edit_ckb);
            this.groupBox2.Controls.Add(this.Delete_btn);
            this.groupBox2.Controls.Add(this.Edit_btn);
            this.groupBox2.Controls.Add(this.Add_btn);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 99);
            this.groupBox2.TabIndex = 118;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chỉnh sửa";
            // 
            // Edit_ckb
            // 
            this.Edit_ckb.AutoSize = true;
            this.Edit_ckb.Location = new System.Drawing.Point(98, 7);
            this.Edit_ckb.Name = "Edit_ckb";
            this.Edit_ckb.Size = new System.Drawing.Size(15, 14);
            this.Edit_ckb.TabIndex = 14;
            this.Edit_ckb.UseVisualStyleBackColor = true;
            this.Edit_ckb.CheckedChanged += new System.EventHandler(this.Edit_ckb_CheckedChanged);
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
            this.Delete_btn.Location = new System.Drawing.Point(179, 38);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.ShadowDecoration.Parent = this.Delete_btn;
            this.Delete_btn.Size = new System.Drawing.Size(90, 40);
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
            this.Edit_btn.Location = new System.Drawing.Point(316, 38);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.ShadowDecoration.Parent = this.Edit_btn;
            this.Edit_btn.Size = new System.Drawing.Size(90, 40);
            this.Edit_btn.TabIndex = 170;
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
            this.Add_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.ForeColor = System.Drawing.Color.Black;
            this.Add_btn.HoverState.Parent = this.Add_btn;
            this.Add_btn.Image = global::GUI_QuanLyCafe.Properties.Resources.add_icon;
            this.Add_btn.Location = new System.Drawing.Point(44, 38);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.ShadowDecoration.Parent = this.Add_btn;
            this.Add_btn.Size = new System.Drawing.Size(90, 40);
            this.Add_btn.TabIndex = 168;
            this.Add_btn.Text = "Thêm";
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // ListVoucher_dgv
            // 
            this.ListVoucher_dgv.AllowUserToAddRows = false;
            this.ListVoucher_dgv.AllowUserToDeleteRows = false;
            this.ListVoucher_dgv.AllowUserToResizeColumns = false;
            this.ListVoucher_dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ListVoucher_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListVoucher_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListVoucher_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ListVoucher_dgv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListVoucher_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListVoucher_dgv.ColumnHeadersHeight = 40;
            this.ListVoucher_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListVoucher_dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.ListVoucher_dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ListVoucher_dgv.Location = new System.Drawing.Point(467, 172);
            this.ListVoucher_dgv.Name = "ListVoucher_dgv";
            this.ListVoucher_dgv.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListVoucher_dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ListVoucher_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListVoucher_dgv.ShowCellErrors = false;
            this.ListVoucher_dgv.ShowCellToolTips = false;
            this.ListVoucher_dgv.ShowEditingIcon = false;
            this.ListVoucher_dgv.ShowRowErrors = false;
            this.ListVoucher_dgv.Size = new System.Drawing.Size(496, 254);
            this.ListVoucher_dgv.TabIndex = 117;
            this.ListVoucher_dgv.TabStop = false;
            this.ListVoucher_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DanhSachKM_dgv_CellClick);
            // 
            // IdVoucher_lbl
            // 
            this.IdVoucher_lbl.AutoSize = true;
            this.IdVoucher_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdVoucher_lbl.Location = new System.Drawing.Point(26, 39);
            this.IdVoucher_lbl.Name = "IdVoucher_lbl";
            this.IdVoucher_lbl.Size = new System.Drawing.Size(137, 23);
            this.IdVoucher_lbl.TabIndex = 71;
            this.IdVoucher_lbl.Text = "Mã khuyến mãi";
            // 
            // IdVoucher_txt
            // 
            this.IdVoucher_txt.CausesValidation = false;
            this.IdVoucher_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.IdVoucher_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdVoucher_txt.Location = new System.Drawing.Point(221, 36);
            this.IdVoucher_txt.Name = "IdVoucher_txt";
            this.IdVoucher_txt.ReadOnly = true;
            this.IdVoucher_txt.Size = new System.Drawing.Size(173, 32);
            this.IdVoucher_txt.TabIndex = 1;
            this.IdVoucher_txt.TextChanged += new System.EventHandler(this.IdVoucher_txt_TextChanged);
            // 
            // Percent_lbl
            // 
            this.Percent_lbl.AutoSize = true;
            this.Percent_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percent_lbl.Location = new System.Drawing.Point(26, 134);
            this.Percent_lbl.Name = "Percent_lbl";
            this.Percent_lbl.Size = new System.Drawing.Size(194, 23);
            this.Percent_lbl.TabIndex = 69;
            this.Percent_lbl.Text = "Phần trăm khuyến mãi";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(391, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(38, 32);
            this.textBox1.TabIndex = 74;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "%";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NameVoucher_txt
            // 
            this.NameVoucher_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameVoucher_txt.Location = new System.Drawing.Point(221, 83);
            this.NameVoucher_txt.Name = "NameVoucher_txt";
            this.NameVoucher_txt.ReadOnly = true;
            this.NameVoucher_txt.Size = new System.Drawing.Size(208, 32);
            this.NameVoucher_txt.TabIndex = 2;
            this.NameVoucher_txt.TextChanged += new System.EventHandler(this.NameVoucher_txt_TextChanged);
            // 
            // Percent_txt
            // 
            this.Percent_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percent_txt.Location = new System.Drawing.Point(221, 131);
            this.Percent_txt.Name = "Percent_txt";
            this.Percent_txt.ReadOnly = true;
            this.Percent_txt.Size = new System.Drawing.Size(171, 32);
            this.Percent_txt.TabIndex = 3;
            this.Percent_txt.TextChanged += new System.EventHandler(this.Percent_txt_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CreateID_btn);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.NameVoucher_txt);
            this.groupBox1.Controls.Add(this.Percent_txt);
            this.groupBox1.Controls.Add(this.IdVoucher_txt);
            this.groupBox1.Controls.Add(this.Percent_lbl);
            this.groupBox1.Controls.Add(this.NameVoucher_lbl);
            this.groupBox1.Controls.Add(this.IdVoucher_lbl);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 181);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khuyến mãi";
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
            this.CreateID_btn.Location = new System.Drawing.Point(393, 36);
            this.CreateID_btn.Name = "CreateID_btn";
            this.CreateID_btn.ShadowDecoration.Parent = this.CreateID_btn;
            this.CreateID_btn.Size = new System.Drawing.Size(36, 32);
            this.CreateID_btn.TabIndex = 173;
            this.CreateID_btn.Click += new System.EventHandler(this.CreateID_btn_Click);
            // 
            // NameVoucher_lbl
            // 
            this.NameVoucher_lbl.AutoSize = true;
            this.NameVoucher_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameVoucher_lbl.Location = new System.Drawing.Point(25, 86);
            this.NameVoucher_lbl.Name = "NameVoucher_lbl";
            this.NameVoucher_lbl.Size = new System.Drawing.Size(141, 23);
            this.NameVoucher_lbl.TabIndex = 68;
            this.NameVoucher_lbl.Text = "Tên khuyến mãi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(334, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(364, 31);
            this.label12.TabIndex = 115;
            this.label12.Text = "DANH SÁCH KHUYẾN MÃI";
            // 
            // Log_Menu
            // 
            this.Log_Menu.BackColor = System.Drawing.Color.Transparent;
            this.Log_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Log_MenuItem});
            this.Log_Menu.Location = new System.Drawing.Point(0, 0);
            this.Log_Menu.Name = "Log_Menu";
            this.Log_Menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Log_Menu.Size = new System.Drawing.Size(975, 40);
            this.Log_Menu.TabIndex = 122;
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
            this.ResetFind_btn.Location = new System.Drawing.Point(931, 133);
            this.ResetFind_btn.Name = "ResetFind_btn";
            this.ResetFind_btn.ShadowDecoration.Parent = this.ResetFind_btn;
            this.ResetFind_btn.Size = new System.Drawing.Size(32, 32);
            this.ResetFind_btn.TabIndex = 172;
            this.ResetFind_btn.Click += new System.EventHandler(this.ResetFind_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::GUI_QuanLyCafe.Properties.Resources._1200px_Highlands_Coffee_logo_svg;
            this.pictureBox2.Location = new System.Drawing.Point(5, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 173;
            this.pictureBox2.TabStop = false;
            // 
            // Voucher_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 444);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Log_Menu);
            this.Controls.Add(this.Find_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ResetFind_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ListVoucher_dgv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Voucher_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voucher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Voucher_frm_FormClosing);
            this.Load += new System.EventHandler(this.Voucher_frm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListVoucher_dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Log_Menu.ResumeLayout(false);
            this.Log_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip Log_Menu;
        private System.Windows.Forms.ToolStripMenuItem Log_MenuItem;
        private System.Windows.Forms.TextBox Find_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox Edit_ckb;
        private System.Windows.Forms.DataGridView ListVoucher_dgv;
        private System.Windows.Forms.Label IdVoucher_lbl;
        private System.Windows.Forms.TextBox IdVoucher_txt;
        private System.Windows.Forms.Label Percent_lbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox NameVoucher_txt;
        private System.Windows.Forms.TextBox Percent_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label NameVoucher_lbl;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Button Delete_btn;
        private Guna.UI2.WinForms.Guna2Button Edit_btn;
        private Guna.UI2.WinForms.Guna2Button Add_btn;
        private Guna.UI2.WinForms.Guna2Button CreateID_btn;
        private Guna.UI2.WinForms.Guna2Button ResetFind_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}