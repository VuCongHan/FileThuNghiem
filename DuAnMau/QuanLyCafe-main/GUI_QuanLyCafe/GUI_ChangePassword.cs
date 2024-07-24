using BUS_QuanLyCafe;
using DTO_QuanLyCafe;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace GUI_QuanLyCafe
{
    public partial class ChangePassword_frm : Form
    {
        public ChangePassword_frm()
        {
            InitializeComponent();
        }
        DTO_Staff staff = new DTO_Staff();
        private void Change_btn_Click(object sender, EventArgs e)
        {
            staff.Email = Login_frm.Email;
            staff.Password = BUS_Staff.Instance.Encryption(OldPassword_txt.Text); ;

            if (Login_frm.Email == "admin")
            {
                MessageBox.Show("Đổi mật khẩu thất bại, đây là tài khoản admin không được phép thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (BUS_Staff.Instance.AcceptLogin(staff) == true)
                {
                    try
                    {
                        DoiMK_grb.Enabled = false;
                        string Encryption = BUS_Staff.Instance.Encryption(NewPassword_txt.Text);
                        staff.Password = Encryption;
                        BUS_Staff.Instance.UpdatePassword(staff);
                        MessageBox.Show("Đổi mật khẩu thành công, về màn hình đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Process.Start(Application.ExecutablePath);
                        Process.GetCurrentProcess().Kill();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    DoiMK_grb.Enabled = true;
                    MessageBox.Show("Mật khẩu hiện tại không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.ActiveControl = OldPassword_txt;
                }
            }
        }

        private void ShowHideOP_ckb_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowHideOP_ckb.Checked == true)
            {
                ShowOP_ptb.Show();
                HideOP_ptb.Hide();
                OldPassword_txt.UseSystemPasswordChar = false;
            }
            else
            {
                ShowOP_ptb.Hide();
                HideOP_ptb.Show();
                OldPassword_txt.UseSystemPasswordChar = true;
            }
        }

        private void ShowHideNP_ckb_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowHideNP_ckb.Checked == true)
            {
                ShowNP_ptb.Show();
                HideNP_ptb.Hide();
                NewPassword_txt.UseSystemPasswordChar = false;
            }
            else
            {
                ShowNP_ptb.Hide();
                HideNP_ptb.Show();
                NewPassword_txt.UseSystemPasswordChar = true;
            }
        }

        private void ShowHideANP_ckb_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowHideANP_ckb.Checked == true)
            {
                ShowANP_ptb.Show();
                HideANP_ptb.Hide();
                AgainNewPassword_txt.UseSystemPasswordChar = false;
            }
            else
            {
                ShowANP_ptb.Hide();
                HideANP_ptb.Show();
                AgainNewPassword_txt.UseSystemPasswordChar = true;
            }
        }

        private void ChangePassword_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShowHideOP_ckb.Checked = false;
            ShowHideNP_ckb.Checked = false;
            ShowHideANP_ckb.Checked = false;

            OldPassword_txt.Text = "";
            NewPassword_txt.Text = "";
            AgainNewPassword_txt.Text = "";
        }

        private void NewPassword_txt_TextChanged(object sender, EventArgs e)
        {
            if (NewPassword_txt.Text.Length >= 6)
            {
                AgainNewPassword_txt_TextChanged(sender, e);
            }
            else
            {
                Change_btn.Enabled = false;
            }
        }

        private void AgainNewPassword_txt_TextChanged(object sender, EventArgs e)
        {
            if (NewPassword_txt.Text == AgainNewPassword_txt.Text)
            {
                Change_btn.Enabled = true;
            }
            else
            {
                Change_btn.Enabled = false;
            }
        }

        private void ChangePassword_frm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            ShowHideOP_ckb_CheckedChanged(sender, e);
            ShowHideNP_ckb_CheckedChanged(sender, e);
            ShowHideANP_ckb_CheckedChanged(sender, e);
        }
    }
}
