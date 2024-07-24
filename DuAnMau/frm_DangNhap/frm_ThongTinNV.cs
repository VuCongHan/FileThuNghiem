using BUL_QLBANHANG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_DangNhap
{
    public partial class frm_ThongTinNV : Form
    {
        public frm_ThongTinNV()
        {
            InitializeComponent();
        }
        Thread th;
        string stremail;
        BUL_NHANVIEN bul_NHANVIEN = new BUL_QLBANHANG.BUL_NHANVIEN();
        public frm_ThongTinNV(string email)
        {
            InitializeComponent();
            stremail = email;
            txt_email.Text = stremail;
            txt_email.Enabled = false;
        }
        public string encryption(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encrypt.ToString();
        }
        public void SendMail(string email, string matKhau)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 25);
                NetworkCredential cred = new NetworkCredential("sender@gmail.com", "chonduoi");
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("sender@gmail.com");
                Msg.To.Add(email);
                Msg.Subject = "Ban da su dung tinh nang quen Mat Khau";
                Msg.Body = "Chào anh/chị. Mật khẩu mới truy cập phần mềm là" + matKhau;
                client.Credentials = cred;
                client.EnableSsl = true;
                client.Send(Msg);
                MessageBox.Show("Một Email phục hồi mật khẩu đã được gửi tới bạn");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhauCu.Focus();
                return;
            }
            else if (txt_MatKhauMoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MatKhauMoi.Focus();
                return;
            }
            else if (txt_MatKhauMoi2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MatKhauMoi2.Focus();
                return;
            }
            else if (txt_MatKhauMoi2.Text.Trim() != txt_MatKhauMoi.Text.Trim())
            {
                MessageBox.Show("Bạn phải nhập mật khẩu và nhập lại mật khẩu giống nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MatKhauMoi.Focus();
                return;
            }
            else
            {
                if(MessageBox.Show("Bạn có chắc muốn cập nhật mật khẩu", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string matkhaumoi = encryption(txt_MatKhauMoi.Text);
                    string matkhaucu = encryption(txtMatKhauCu.Text);
                    if (bul_NHANVIEN.UpdateMatKhau(txt_email.Text, matkhaucu, matkhaumoi))
                    {
                        Form1.profile = 1;
                        Form1.session = 0;
                        SendMail(stremail, txt_MatKhauMoi2.Text);
                        MessageBox.Show("Cập nhật mật khẩu thành công, bạn cần phải đăng nhập lại");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng, Cập nhật mật khẩu không thành công");
                        txtMatKhauCu.Text = null;
                        txt_MatKhauMoi.Text = null;
                        txt_MatKhauMoi2.Text = null;
                    }
                }
                else
                {
                    txtMatKhauCu.Text = null;
                    txt_MatKhauMoi.Text = null;
                    txt_MatKhauMoi2.Text = null;
                }
            }
        }
    }
}
