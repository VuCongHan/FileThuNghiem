
namespace GUI_QuanLyCafe
{
    partial class ForgotPassword_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword_frm));
            this.VerificationPassword_grb = new System.Windows.Forms.GroupBox();
            this.Change_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Verification_btn = new Guna.UI2.WinForms.Guna2Button();
            this.CorrectIdVrf_ptb = new System.Windows.Forms.PictureBox();
            this.TempIdVrf_txt = new System.Windows.Forms.TextBox();
            this.IdVrf_lbl = new System.Windows.Forms.Label();
            this.IdVrf_txt = new System.Windows.Forms.TextBox();
            this.Wrong_ptb = new System.Windows.Forms.PictureBox();
            this.Correct_ptb = new System.Windows.Forms.PictureBox();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.VerificationPassword_grb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CorrectIdVrf_ptb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wrong_ptb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Correct_ptb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // VerificationPassword_grb
            // 
            this.VerificationPassword_grb.BackColor = System.Drawing.Color.Transparent;
            this.VerificationPassword_grb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.VerificationPassword_grb.Controls.Add(this.Change_btn);
            this.VerificationPassword_grb.Controls.Add(this.Verification_btn);
            this.VerificationPassword_grb.Controls.Add(this.CorrectIdVrf_ptb);
            this.VerificationPassword_grb.Controls.Add(this.TempIdVrf_txt);
            this.VerificationPassword_grb.Controls.Add(this.IdVrf_lbl);
            this.VerificationPassword_grb.Controls.Add(this.IdVrf_txt);
            this.VerificationPassword_grb.Controls.Add(this.Wrong_ptb);
            this.VerificationPassword_grb.Controls.Add(this.Correct_ptb);
            this.VerificationPassword_grb.Controls.Add(this.Email_txt);
            this.VerificationPassword_grb.Controls.Add(this.label1);
            this.VerificationPassword_grb.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerificationPassword_grb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.VerificationPassword_grb.Location = new System.Drawing.Point(12, 131);
            this.VerificationPassword_grb.Name = "VerificationPassword_grb";
            this.VerificationPassword_grb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VerificationPassword_grb.Size = new System.Drawing.Size(521, 208);
            this.VerificationPassword_grb.TabIndex = 8;
            this.VerificationPassword_grb.TabStop = false;
            this.VerificationPassword_grb.Text = "Kiểm tra Email";
            // 
            // Change_btn
            // 
            this.Change_btn.Animated = true;
            this.Change_btn.BorderRadius = 10;
            this.Change_btn.BorderThickness = 2;
            this.Change_btn.CheckedState.Parent = this.Change_btn;
            this.Change_btn.CustomImages.Parent = this.Change_btn;
            this.Change_btn.Enabled = false;
            this.Change_btn.FillColor = System.Drawing.Color.White;
            this.Change_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change_btn.ForeColor = System.Drawing.Color.Black;
            this.Change_btn.HoverState.Parent = this.Change_btn;
            this.Change_btn.Image = global::GUI_QuanLyCafe.Properties.Resources.padlock;
            this.Change_btn.Location = new System.Drawing.Point(65, 149);
            this.Change_btn.Name = "Change_btn";
            this.Change_btn.ShadowDecoration.Parent = this.Change_btn;
            this.Change_btn.Size = new System.Drawing.Size(130, 40);
            this.Change_btn.TabIndex = 155;
            this.Change_btn.Text = "Khôi phục";
            this.Change_btn.Visible = false;
            this.Change_btn.Click += new System.EventHandler(this.Change_btn_Click);
            // 
            // Verification_btn
            // 
            this.Verification_btn.Animated = true;
            this.Verification_btn.BorderRadius = 10;
            this.Verification_btn.BorderThickness = 2;
            this.Verification_btn.CheckedState.Parent = this.Verification_btn;
            this.Verification_btn.CustomImages.Parent = this.Verification_btn;
            this.Verification_btn.FillColor = System.Drawing.Color.White;
            this.Verification_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verification_btn.ForeColor = System.Drawing.Color.Black;
            this.Verification_btn.HoverState.Parent = this.Verification_btn;
            this.Verification_btn.Image = global::GUI_QuanLyCafe.Properties.Resources.check_mark;
            this.Verification_btn.Location = new System.Drawing.Point(326, 149);
            this.Verification_btn.Name = "Verification_btn";
            this.Verification_btn.ShadowDecoration.Parent = this.Verification_btn;
            this.Verification_btn.Size = new System.Drawing.Size(130, 40);
            this.Verification_btn.TabIndex = 154;
            this.Verification_btn.Text = "Kiểm tra";
            this.Verification_btn.Click += new System.EventHandler(this.Verification_btn_Click);
            // 
            // CorrectIdVrf_ptb
            // 
            this.CorrectIdVrf_ptb.Image = global::GUI_QuanLyCafe.Properties.Resources.check;
            this.CorrectIdVrf_ptb.Location = new System.Drawing.Point(464, 98);
            this.CorrectIdVrf_ptb.Name = "CorrectIdVrf_ptb";
            this.CorrectIdVrf_ptb.Size = new System.Drawing.Size(27, 26);
            this.CorrectIdVrf_ptb.TabIndex = 15;
            this.CorrectIdVrf_ptb.TabStop = false;
            this.CorrectIdVrf_ptb.Visible = false;
            // 
            // TempIdVrf_txt
            // 
            this.TempIdVrf_txt.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TempIdVrf_txt.Enabled = false;
            this.TempIdVrf_txt.Location = new System.Drawing.Point(462, 95);
            this.TempIdVrf_txt.Name = "TempIdVrf_txt";
            this.TempIdVrf_txt.Size = new System.Drawing.Size(30, 32);
            this.TempIdVrf_txt.TabIndex = 14;
            this.TempIdVrf_txt.TabStop = false;
            this.TempIdVrf_txt.Text = "1";
            this.TempIdVrf_txt.Visible = false;
            // 
            // IdVrf_lbl
            // 
            this.IdVrf_lbl.AutoSize = true;
            this.IdVrf_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdVrf_lbl.Location = new System.Drawing.Point(61, 98);
            this.IdVrf_lbl.Name = "IdVrf_lbl";
            this.IdVrf_lbl.Size = new System.Drawing.Size(114, 23);
            this.IdVrf_lbl.TabIndex = 13;
            this.IdVrf_lbl.Text = "Mã xác nhận";
            this.IdVrf_lbl.Visible = false;
            // 
            // IdVrf_txt
            // 
            this.IdVrf_txt.BackColor = System.Drawing.SystemColors.Window;
            this.IdVrf_txt.Location = new System.Drawing.Point(183, 95);
            this.IdVrf_txt.Name = "IdVrf_txt";
            this.IdVrf_txt.Size = new System.Drawing.Size(273, 32);
            this.IdVrf_txt.TabIndex = 3;
            this.IdVrf_txt.Visible = false;
            this.IdVrf_txt.TextChanged += new System.EventHandler(this.IdVrf_txt_TextChanged);
            // 
            // Wrong_ptb
            // 
            this.Wrong_ptb.Image = global::GUI_QuanLyCafe.Properties.Resources.cancel;
            this.Wrong_ptb.Location = new System.Drawing.Point(465, 42);
            this.Wrong_ptb.Name = "Wrong_ptb";
            this.Wrong_ptb.Size = new System.Drawing.Size(27, 26);
            this.Wrong_ptb.TabIndex = 10;
            this.Wrong_ptb.TabStop = false;
            this.Wrong_ptb.Visible = false;
            // 
            // Correct_ptb
            // 
            this.Correct_ptb.Image = global::GUI_QuanLyCafe.Properties.Resources.check;
            this.Correct_ptb.Location = new System.Drawing.Point(465, 42);
            this.Correct_ptb.Name = "Correct_ptb";
            this.Correct_ptb.Size = new System.Drawing.Size(27, 26);
            this.Correct_ptb.TabIndex = 9;
            this.Correct_ptb.TabStop = false;
            this.Correct_ptb.Visible = false;
            // 
            // Email_txt
            // 
            this.Email_txt.BackColor = System.Drawing.SystemColors.Window;
            this.Email_txt.Location = new System.Drawing.Point(147, 40);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(309, 32);
            this.Email_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::GUI_QuanLyCafe.Properties.Resources._1200px_Highlands_Coffee_logo_svg;
            this.pictureBox2.Location = new System.Drawing.Point(195, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 156;
            this.pictureBox2.TabStop = false;
            // 
            // ForgotPassword_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 353);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.VerificationPassword_grb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ForgotPassword_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quên mật khẩu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ForgotPassword_frm_FormClosing);
            this.VerificationPassword_grb.ResumeLayout(false);
            this.VerificationPassword_grb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CorrectIdVrf_ptb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wrong_ptb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Correct_ptb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox VerificationPassword_grb;
        private System.Windows.Forms.PictureBox CorrectIdVrf_ptb;
        private System.Windows.Forms.TextBox TempIdVrf_txt;
        private System.Windows.Forms.Label IdVrf_lbl;
        private System.Windows.Forms.TextBox IdVrf_txt;
        private System.Windows.Forms.PictureBox Wrong_ptb;
        private System.Windows.Forms.PictureBox Correct_ptb;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button Change_btn;
        private Guna.UI2.WinForms.Guna2Button Verification_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}