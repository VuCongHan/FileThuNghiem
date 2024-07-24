
namespace GUI_QuanLyCafe
{
    partial class Login_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_frm));
            this.ForgotPassword_lblk = new System.Windows.Forms.LinkLabel();
            this.Memo_ckb = new System.Windows.Forms.CheckBox();
            this.LoadBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.ShowHide_ckb = new System.Windows.Forms.CheckBox();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Login_grb = new System.Windows.Forms.GroupBox();
            this.Login_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Show_ptb = new System.Windows.Forms.PictureBox();
            this.Hide_ptb = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Login_grb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Show_ptb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hide_ptb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ForgotPassword_lblk
            // 
            this.ForgotPassword_lblk.AutoSize = true;
            this.ForgotPassword_lblk.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPassword_lblk.Location = new System.Drawing.Point(71, 231);
            this.ForgotPassword_lblk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ForgotPassword_lblk.Name = "ForgotPassword_lblk";
            this.ForgotPassword_lblk.Size = new System.Drawing.Size(199, 31);
            this.ForgotPassword_lblk.TabIndex = 5;
            this.ForgotPassword_lblk.TabStop = true;
            this.ForgotPassword_lblk.Text = "Quên mật khẩu ?";
            this.ForgotPassword_lblk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgotPassword_lblk_LinkClicked);
            // 
            // Memo_ckb
            // 
            this.Memo_ckb.AutoSize = true;
            this.Memo_ckb.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Memo_ckb.Location = new System.Drawing.Point(76, 186);
            this.Memo_ckb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Memo_ckb.Name = "Memo_ckb";
            this.Memo_ckb.Size = new System.Drawing.Size(245, 35);
            this.Memo_ckb.TabIndex = 3;
            this.Memo_ckb.Text = "Ghi nhớ đăng nhập";
            this.Memo_ckb.UseVisualStyleBackColor = true;
            // 
            // LoadBar
            // 
            this.LoadBar.BorderRadius = 10;
            this.LoadBar.FillColor = System.Drawing.Color.LightGray;
            this.LoadBar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBar.ForeColor = System.Drawing.Color.White;
            this.LoadBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.LoadBar.Location = new System.Drawing.Point(191, 449);
            this.LoadBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadBar.Name = "LoadBar";
            this.LoadBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LoadBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LoadBar.ShadowDecoration.Parent = this.LoadBar;
            this.LoadBar.ShowPercentage = true;
            this.LoadBar.Size = new System.Drawing.Size(412, 31);
            this.LoadBar.TabIndex = 9;
            this.LoadBar.TabStop = false;
            this.LoadBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.LoadBar.Visible = false;
            // 
            // ShowHide_ckb
            // 
            this.ShowHide_ckb.AutoSize = true;
            this.ShowHide_ckb.BackColor = System.Drawing.Color.Transparent;
            this.ShowHide_ckb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ShowHide_ckb.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowHide_ckb.Location = new System.Drawing.Point(624, 122);
            this.ShowHide_ckb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowHide_ckb.Name = "ShowHide_ckb";
            this.ShowHide_ckb.Size = new System.Drawing.Size(71, 35);
            this.ShowHide_ckb.TabIndex = 8;
            this.ShowHide_ckb.TabStop = false;
            this.ShowHide_ckb.Text = "     ";
            this.ShowHide_ckb.UseVisualStyleBackColor = false;
            this.ShowHide_ckb.CheckedChanged += new System.EventHandler(this.ShowHide_ckb_CheckedChanged);
            // 
            // Password_txt
            // 
            this.Password_txt.BackColor = System.Drawing.SystemColors.Window;
            this.Password_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_txt.Location = new System.Drawing.Point(197, 119);
            this.Password_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(413, 38);
            this.Password_txt.TabIndex = 2;
            this.Password_txt.Text = "1";
            this.Password_txt.UseSystemPasswordChar = true;
            this.Password_txt.TextChanged += new System.EventHandler(this.Password_txt_TextChanged);
            // 
            // Email_txt
            // 
            this.Email_txt.BackColor = System.Drawing.SystemColors.Window;
            this.Email_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_txt.Location = new System.Drawing.Point(197, 62);
            this.Email_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(413, 38);
            this.Email_txt.TabIndex = 1;
            this.Email_txt.Text = "chinhchu@gmail.com";
            this.Email_txt.TextChanged += new System.EventHandler(this.Email_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login_grb
            // 
            this.Login_grb.BackColor = System.Drawing.Color.Transparent;
            this.Login_grb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Login_grb.Controls.Add(this.Login_btn);
            this.Login_grb.Controls.Add(this.ForgotPassword_lblk);
            this.Login_grb.Controls.Add(this.Memo_ckb);
            this.Login_grb.Controls.Add(this.Show_ptb);
            this.Login_grb.Controls.Add(this.Hide_ptb);
            this.Login_grb.Controls.Add(this.ShowHide_ckb);
            this.Login_grb.Controls.Add(this.Password_txt);
            this.Login_grb.Controls.Add(this.Email_txt);
            this.Login_grb.Controls.Add(this.label1);
            this.Login_grb.Controls.Add(this.label2);
            this.Login_grb.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_grb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Login_grb.Location = new System.Drawing.Point(16, 155);
            this.Login_grb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Login_grb.Name = "Login_grb";
            this.Login_grb.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Login_grb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Login_grb.Size = new System.Drawing.Size(740, 286);
            this.Login_grb.TabIndex = 7;
            this.Login_grb.TabStop = false;
            this.Login_grb.Text = "Đăng nhập";
            // 
            // Login_btn
            // 
            this.Login_btn.BorderRadius = 10;
            this.Login_btn.BorderThickness = 2;
            this.Login_btn.CheckedState.Parent = this.Login_btn;
            this.Login_btn.CustomImages.Parent = this.Login_btn;
            this.Login_btn.FillColor = System.Drawing.Color.White;
            this.Login_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.ForeColor = System.Drawing.Color.Black;
            this.Login_btn.HoverState.Parent = this.Login_btn;
            this.Login_btn.Image = global::GUI_QuanLyCafe.Properties.Resources.Login_in_icon;
            this.Login_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Login_btn.Location = new System.Drawing.Point(416, 174);
            this.Login_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.ShadowDecoration.Parent = this.Login_btn;
            this.Login_btn.Size = new System.Drawing.Size(196, 62);
            this.Login_btn.TabIndex = 39;
            this.Login_btn.Text = "Đăng nhập";
            this.Login_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Show_ptb
            // 
            this.Show_ptb.Image = global::GUI_QuanLyCafe.Properties.Resources.eye;
            this.Show_ptb.Location = new System.Drawing.Point(651, 117);
            this.Show_ptb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Show_ptb.Name = "Show_ptb";
            this.Show_ptb.Size = new System.Drawing.Size(53, 38);
            this.Show_ptb.TabIndex = 9;
            this.Show_ptb.TabStop = false;
            this.Show_ptb.Visible = false;
            // 
            // Hide_ptb
            // 
            this.Hide_ptb.Image = global::GUI_QuanLyCafe.Properties.Resources.invisible;
            this.Hide_ptb.Location = new System.Drawing.Point(651, 117);
            this.Hide_ptb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Hide_ptb.Name = "Hide_ptb";
            this.Hide_ptb.Size = new System.Drawing.Size(53, 38);
            this.Hide_ptb.TabIndex = 9;
            this.Hide_ptb.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::GUI_QuanLyCafe.Properties.Resources._1200px_Highlands_Coffee_logo_svg;
            this.pictureBox2.Location = new System.Drawing.Point(280, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(229, 146);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 152;
            this.pictureBox2.TabStop = false;
            // 
            // Login_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 490);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LoadBar);
            this.Controls.Add(this.Login_grb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Login_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_frm_FormClosing);
            this.Load += new System.EventHandler(this.Login_frm_Load);
            this.Login_grb.ResumeLayout(false);
            this.Login_grb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Show_ptb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hide_ptb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel ForgotPassword_lblk;
        private System.Windows.Forms.CheckBox Memo_ckb;
        private System.Windows.Forms.PictureBox Show_ptb;
        private System.Windows.Forms.PictureBox Hide_ptb;
        private Guna.UI2.WinForms.Guna2ProgressBar LoadBar;
        private System.Windows.Forms.CheckBox ShowHide_ckb;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox Login_grb;
        private Guna.UI2.WinForms.Guna2Button Login_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}