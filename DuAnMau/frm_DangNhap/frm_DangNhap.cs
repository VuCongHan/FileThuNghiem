using BUL_QLBANHANG;
using DTO_QLBANHANG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_DangNhap
{// fdjshdsjkdklsdksdlk
    public partial class frm_DangNhap : Form

    {
        BUL_NHANVIEN bul_NHANVIEN = new BUL_QLBANHANG.BUL_NHANVIEN();
        public string vaitro { get; set; }
        public string matkhau { get; set; }
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            DTO_NHANVIEN nv = new DTO_NHANVIEN();
            nv.Email = txtEmail.Text; 
            BUL_NHANVIEN bul_NHANVIEN = new BUL_NHANVIEN();
            nv.MatKhau = bul_NHANVIEN.encryption(txtMatKhau.Text);
            if (bul_NHANVIEN.NhanVienDangNhap(nv))
            {
                Form1.email = nv.Email;
                DataTable dt = bul_NHANVIEN.VaiTroNhanVien(nv.Email);
                vaitro = dt.Rows[0][0].ToString();
                MessageBox.Show("Đăng nhập thành công");
                Form1.session = 1; //cập nhật trạng thái đăng nhập thành công
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công, kiểm tra lại email hoặc mật khẩu");
                txtEmail.Text = null;
                txtMatKhau.Text = null;
                txtEmail.Focus();
            }
        }

        //Quên mật khẩu

        private void label4_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != null)
            {
                if (bul_NHANVIEN.NhanQuenMatKhau(txtEmail.Text))
                {
                    StringBuilder builder = new StringBuilder();
                    builder.Append(randomString(4, true));
                    builder.Append(randomNumber(1000,9999));
                    builder.Append(randomString(2, false));
                    string matKhauMoi = bul_NHANVIEN.encryption(builder.ToString());
                    bul_NHANVIEN.TaoMatKhau(txtEmail.Text, matKhauMoi);
                    SendMail(txtEmail.Text, builder.ToString());
                }
                else
                {
                    MessageBox.Show("Email không tồn tại, vui lòng nhập lại Email!!!");
                }
            }
            else
            {
                MessageBox.Show("Bạn cần nhập email nhận thông tin phục hồi mật khẩu");
                txtEmail.Focus();
            }
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Tạo chuỗi ngẫu nhiên
        public string randomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random rd = new Random();
            char ch;
            for (int i = 0;i<=size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * rd.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        //Random số
        public int randomNumber(int min, int max)
        {
            Random rd = new Random();
            return rd.Next(min, max);
        }

        private void btn_QuenMatKhau_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
