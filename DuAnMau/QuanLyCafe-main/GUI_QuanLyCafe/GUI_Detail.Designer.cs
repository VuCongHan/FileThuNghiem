
namespace GUI_QuanLyCafe
{
    partial class Detail_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detail_frm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Note_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.Add_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Amount_nud = new Guna.UI2.WinForms.Guna2NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Amount_nud)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ghi chú";
            // 
            // Note_txt
            // 
            this.Note_txt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note_txt.Location = new System.Drawing.Point(107, 113);
            this.Note_txt.Multiline = true;
            this.Note_txt.Name = "Note_txt";
            this.Note_txt.Size = new System.Drawing.Size(259, 110);
            this.Note_txt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên";
            // 
            // Name_txt
            // 
            this.Name_txt.Enabled = false;
            this.Name_txt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_txt.Location = new System.Drawing.Point(107, 18);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(259, 29);
            this.Name_txt.TabIndex = 6;
            // 
            // Add_btn
            // 
            this.Add_btn.Animated = true;
            this.Add_btn.BorderRadius = 10;
            this.Add_btn.BorderThickness = 2;
            this.Add_btn.CheckedState.Parent = this.Add_btn;
            this.Add_btn.CustomImages.Parent = this.Add_btn;
            this.Add_btn.FillColor = System.Drawing.Color.White;
            this.Add_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.ForeColor = System.Drawing.Color.Black;
            this.Add_btn.HoverState.Parent = this.Add_btn;
            this.Add_btn.Image = global::GUI_QuanLyCafe.Properties.Resources.add_icon;
            this.Add_btn.Location = new System.Drawing.Point(265, 234);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.ShadowDecoration.Parent = this.Add_btn;
            this.Add_btn.Size = new System.Drawing.Size(101, 40);
            this.Add_btn.TabIndex = 155;
            this.Add_btn.Text = "Thêm";
            this.Add_btn.Click += new System.EventHandler(this.Addd_btn_Click);
            // 
            // Amount_nud
            // 
            this.Amount_nud.BackColor = System.Drawing.Color.Transparent;
            this.Amount_nud.BorderColor = System.Drawing.Color.Black;
            this.Amount_nud.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Amount_nud.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Amount_nud.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Amount_nud.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Amount_nud.DisabledState.Parent = this.Amount_nud;
            this.Amount_nud.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(187)))), ((int)(((byte)(150)))));
            this.Amount_nud.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.Amount_nud.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Amount_nud.FocusedState.Parent = this.Amount_nud;
            this.Amount_nud.FocusedState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Amount_nud.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount_nud.ForeColor = System.Drawing.Color.Black;
            this.Amount_nud.Location = new System.Drawing.Point(107, 65);
            this.Amount_nud.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Amount_nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Amount_nud.Name = "Amount_nud";
            this.Amount_nud.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Amount_nud.ShadowDecoration.Parent = this.Amount_nud;
            this.Amount_nud.Size = new System.Drawing.Size(259, 29);
            this.Amount_nud.TabIndex = 156;
            this.Amount_nud.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(187)))), ((int)(((byte)(150)))));
            this.Amount_nud.UpDownButtonForeColor = System.Drawing.Color.Black;
            this.Amount_nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Detail_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(393, 285);
            this.Controls.Add(this.Amount_nud);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Note_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Detail_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detail";
            this.Load += new System.EventHandler(this.Detail_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Amount_nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Note_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Name_txt;
        private Guna.UI2.WinForms.Guna2Button Add_btn;
        private Guna.UI2.WinForms.Guna2NumericUpDown Amount_nud;
    }
}