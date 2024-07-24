
namespace GUI_QuanLyCafe
{
    partial class Menu_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_frm));
            this.Menu_tc = new System.Windows.Forms.TabControl();
            this.CF = new System.Windows.Forms.TabPage();
            this.Cafe_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.FZ = new System.Windows.Forms.TabPage();
            this.Freeze_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.TE = new System.Windows.Forms.TabPage();
            this.Tea_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.FD = new System.Windows.Forms.TabPage();
            this.Food_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.CK = new System.Windows.Forms.TabPage();
            this.Cake_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.SD = new System.Windows.Forms.TabPage();
            this.SoftDrink_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.OR = new System.Windows.Forms.TabPage();
            this.Other_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.ListOrder_dgv = new System.Windows.Forms.DataGridView();
            this.Add_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Delete_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Menu_tc.SuspendLayout();
            this.CF.SuspendLayout();
            this.FZ.SuspendLayout();
            this.TE.SuspendLayout();
            this.FD.SuspendLayout();
            this.CK.SuspendLayout();
            this.SD.SuspendLayout();
            this.OR.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListOrder_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu_tc
            // 
            this.Menu_tc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu_tc.Controls.Add(this.CF);
            this.Menu_tc.Controls.Add(this.FZ);
            this.Menu_tc.Controls.Add(this.TE);
            this.Menu_tc.Controls.Add(this.FD);
            this.Menu_tc.Controls.Add(this.CK);
            this.Menu_tc.Controls.Add(this.SD);
            this.Menu_tc.Controls.Add(this.OR);
            this.Menu_tc.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_tc.Location = new System.Drawing.Point(5, 3);
            this.Menu_tc.Name = "Menu_tc";
            this.Menu_tc.SelectedIndex = 0;
            this.Menu_tc.Size = new System.Drawing.Size(867, 646);
            this.Menu_tc.TabIndex = 26;
            this.Menu_tc.Selected += new System.Windows.Forms.TabControlEventHandler(this.Menu_tc_Selected);
            // 
            // CF
            // 
            this.CF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CF.Controls.Add(this.Cafe_flp);
            this.CF.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CF.Location = new System.Drawing.Point(4, 36);
            this.CF.Name = "CF";
            this.CF.Padding = new System.Windows.Forms.Padding(3);
            this.CF.Size = new System.Drawing.Size(859, 606);
            this.CF.TabIndex = 0;
            this.CF.Text = "Cafe";
            this.CF.UseVisualStyleBackColor = true;
            // 
            // Cafe_flp
            // 
            this.Cafe_flp.AutoScroll = true;
            this.Cafe_flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cafe_flp.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cafe_flp.Location = new System.Drawing.Point(3, 3);
            this.Cafe_flp.Name = "Cafe_flp";
            this.Cafe_flp.Size = new System.Drawing.Size(853, 600);
            this.Cafe_flp.TabIndex = 1;
            // 
            // FZ
            // 
            this.FZ.Controls.Add(this.Freeze_flp);
            this.FZ.Location = new System.Drawing.Point(4, 36);
            this.FZ.Name = "FZ";
            this.FZ.Padding = new System.Windows.Forms.Padding(3);
            this.FZ.Size = new System.Drawing.Size(859, 606);
            this.FZ.TabIndex = 1;
            this.FZ.Text = "Đá xay";
            this.FZ.UseVisualStyleBackColor = true;
            // 
            // Freeze_flp
            // 
            this.Freeze_flp.AutoScroll = true;
            this.Freeze_flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Freeze_flp.Location = new System.Drawing.Point(3, 3);
            this.Freeze_flp.Name = "Freeze_flp";
            this.Freeze_flp.Size = new System.Drawing.Size(853, 600);
            this.Freeze_flp.TabIndex = 2;
            // 
            // TE
            // 
            this.TE.Controls.Add(this.Tea_flp);
            this.TE.Location = new System.Drawing.Point(4, 36);
            this.TE.Name = "TE";
            this.TE.Padding = new System.Windows.Forms.Padding(3);
            this.TE.Size = new System.Drawing.Size(859, 606);
            this.TE.TabIndex = 2;
            this.TE.Text = "Trà";
            this.TE.UseVisualStyleBackColor = true;
            // 
            // Tea_flp
            // 
            this.Tea_flp.AutoScroll = true;
            this.Tea_flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tea_flp.Location = new System.Drawing.Point(3, 3);
            this.Tea_flp.Name = "Tea_flp";
            this.Tea_flp.Size = new System.Drawing.Size(853, 600);
            this.Tea_flp.TabIndex = 2;
            // 
            // FD
            // 
            this.FD.Controls.Add(this.Food_flp);
            this.FD.Location = new System.Drawing.Point(4, 36);
            this.FD.Name = "FD";
            this.FD.Padding = new System.Windows.Forms.Padding(3);
            this.FD.Size = new System.Drawing.Size(859, 606);
            this.FD.TabIndex = 3;
            this.FD.Text = "Đồ ăn";
            this.FD.UseVisualStyleBackColor = true;
            // 
            // Food_flp
            // 
            this.Food_flp.AutoScroll = true;
            this.Food_flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Food_flp.Location = new System.Drawing.Point(3, 3);
            this.Food_flp.Name = "Food_flp";
            this.Food_flp.Size = new System.Drawing.Size(853, 600);
            this.Food_flp.TabIndex = 2;
            // 
            // CK
            // 
            this.CK.Controls.Add(this.Cake_flp);
            this.CK.Location = new System.Drawing.Point(4, 36);
            this.CK.Name = "CK";
            this.CK.Padding = new System.Windows.Forms.Padding(3);
            this.CK.Size = new System.Drawing.Size(859, 606);
            this.CK.TabIndex = 5;
            this.CK.Text = "Bánh ngọt";
            this.CK.UseVisualStyleBackColor = true;
            // 
            // Cake_flp
            // 
            this.Cake_flp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cake_flp.AutoScroll = true;
            this.Cake_flp.Location = new System.Drawing.Point(0, 5);
            this.Cake_flp.Name = "Cake_flp";
            this.Cake_flp.Size = new System.Drawing.Size(858, 600);
            this.Cake_flp.TabIndex = 6;
            // 
            // SD
            // 
            this.SD.Controls.Add(this.SoftDrink_flp);
            this.SD.Location = new System.Drawing.Point(4, 36);
            this.SD.Name = "SD";
            this.SD.Padding = new System.Windows.Forms.Padding(3);
            this.SD.Size = new System.Drawing.Size(859, 606);
            this.SD.TabIndex = 6;
            this.SD.Text = "Nước giải khát";
            this.SD.UseVisualStyleBackColor = true;
            // 
            // SoftDrink_flp
            // 
            this.SoftDrink_flp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SoftDrink_flp.AutoScroll = true;
            this.SoftDrink_flp.Location = new System.Drawing.Point(0, 5);
            this.SoftDrink_flp.Name = "SoftDrink_flp";
            this.SoftDrink_flp.Size = new System.Drawing.Size(858, 600);
            this.SoftDrink_flp.TabIndex = 7;
            // 
            // OR
            // 
            this.OR.Controls.Add(this.Other_flp);
            this.OR.Location = new System.Drawing.Point(4, 36);
            this.OR.Name = "OR";
            this.OR.Padding = new System.Windows.Forms.Padding(3);
            this.OR.Size = new System.Drawing.Size(859, 606);
            this.OR.TabIndex = 7;
            this.OR.Text = "Khác";
            this.OR.UseVisualStyleBackColor = true;
            // 
            // Other_flp
            // 
            this.Other_flp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Other_flp.AutoScroll = true;
            this.Other_flp.Location = new System.Drawing.Point(0, 5);
            this.Other_flp.Name = "Other_flp";
            this.Other_flp.Size = new System.Drawing.Size(858, 600);
            this.Other_flp.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Name_lbl);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(878, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 128);
            this.panel1.TabIndex = 27;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::GUI_QuanLyCafe.Properties.Resources._1200px_Highlands_Coffee_logo_svg;
            this.pictureBox2.Location = new System.Drawing.Point(412, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 153;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 26);
            this.label1.TabIndex = 152;
            this.label1.Text = "HighLands Coffee";
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_lbl.Location = new System.Drawing.Point(19, 74);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(52, 23);
            this.Name_lbl.TabIndex = 0;
            this.Name_lbl.Text = "Tên :";
            // 
            // ListOrder_dgv
            // 
            this.ListOrder_dgv.AllowUserToResizeColumns = false;
            this.ListOrder_dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ListOrder_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListOrder_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListOrder_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListOrder_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ListOrder_dgv.BackgroundColor = System.Drawing.Color.White;
            this.ListOrder_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListOrder_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListOrder_dgv.ColumnHeadersHeight = 40;
            this.ListOrder_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListOrder_dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.ListOrder_dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ListOrder_dgv.Location = new System.Drawing.Point(878, 132);
            this.ListOrder_dgv.MultiSelect = false;
            this.ListOrder_dgv.Name = "ListOrder_dgv";
            this.ListOrder_dgv.ReadOnly = true;
            this.ListOrder_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListOrder_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ListOrder_dgv.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ListOrder_dgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ListOrder_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListOrder_dgv.ShowCellErrors = false;
            this.ListOrder_dgv.ShowCellToolTips = false;
            this.ListOrder_dgv.ShowEditingIcon = false;
            this.ListOrder_dgv.ShowRowErrors = false;
            this.ListOrder_dgv.Size = new System.Drawing.Size(592, 453);
            this.ListOrder_dgv.TabIndex = 28;
            // 
            // Add_btn
            // 
            this.Add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_btn.Animated = true;
            this.Add_btn.BorderRadius = 10;
            this.Add_btn.BorderThickness = 2;
            this.Add_btn.CheckedState.Parent = this.Add_btn;
            this.Add_btn.CustomImages.Parent = this.Add_btn;
            this.Add_btn.FillColor = System.Drawing.Color.White;
            this.Add_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.ForeColor = System.Drawing.Color.Black;
            this.Add_btn.HoverState.Parent = this.Add_btn;
            this.Add_btn.Image = global::GUI_QuanLyCafe.Properties.Resources.add_icon;
            this.Add_btn.Location = new System.Drawing.Point(1163, 599);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.ShadowDecoration.Parent = this.Add_btn;
            this.Add_btn.Size = new System.Drawing.Size(145, 50);
            this.Add_btn.TabIndex = 41;
            this.Add_btn.Text = "Thêm món";
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_btn.Animated = true;
            this.Delete_btn.BorderRadius = 10;
            this.Delete_btn.BorderThickness = 2;
            this.Delete_btn.CheckedState.Parent = this.Delete_btn;
            this.Delete_btn.CustomImages.Parent = this.Delete_btn;
            this.Delete_btn.FillColor = System.Drawing.Color.White;
            this.Delete_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.ForeColor = System.Drawing.Color.Black;
            this.Delete_btn.HoverState.Parent = this.Delete_btn;
            this.Delete_btn.Image = global::GUI_QuanLyCafe.Properties.Resources.Actions_edit_delete_icon;
            this.Delete_btn.Location = new System.Drawing.Point(1325, 599);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.ShadowDecoration.Parent = this.Delete_btn;
            this.Delete_btn.Size = new System.Drawing.Size(145, 50);
            this.Delete_btn.TabIndex = 43;
            this.Delete_btn.Text = "Xóa món";
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Menu_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1475, 661);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ListOrder_dgv);
            this.Controls.Add(this.Menu_tc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1230, 700);
            this.Name = "Menu_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_frm_FormClosing);
            this.Load += new System.EventHandler(this.Menu_frm_Load);
            this.Menu_tc.ResumeLayout(false);
            this.CF.ResumeLayout(false);
            this.FZ.ResumeLayout(false);
            this.TE.ResumeLayout(false);
            this.FD.ResumeLayout(false);
            this.CK.ResumeLayout(false);
            this.SD.ResumeLayout(false);
            this.OR.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListOrder_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl Menu_tc;
        private System.Windows.Forms.TabPage CF;
        private System.Windows.Forms.FlowLayoutPanel Cafe_flp;
        private System.Windows.Forms.TabPage FZ;
        private System.Windows.Forms.FlowLayoutPanel Freeze_flp;
        private System.Windows.Forms.TabPage TE;
        private System.Windows.Forms.FlowLayoutPanel Tea_flp;
        private System.Windows.Forms.TabPage FD;
        private System.Windows.Forms.FlowLayoutPanel Food_flp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.DataGridView ListOrder_dgv;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button Add_btn;
        private Guna.UI2.WinForms.Guna2Button Delete_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage CK;
        private System.Windows.Forms.FlowLayoutPanel Cake_flp;
        private System.Windows.Forms.TabPage SD;
        private System.Windows.Forms.TabPage OR;
        private System.Windows.Forms.FlowLayoutPanel Other_flp;
        private System.Windows.Forms.FlowLayoutPanel SoftDrink_flp;
    }
}