using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        NhanVienDTO taikhoan = new NhanVienDTO();
        TaiKhoanBLL tkBLL = new TaiKhoanBLL();
        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện đăng nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string email = txtTK.Text; // Lấy giá trị email từ người dùng
            TrangChu1 trangChu = new TrangChu1(email);

            string matkhau = txtMK.Text;
            string mahoa = tkBLL.MaHoaMD5(matkhau); // Băm mật khẩu sử dụng MD5

            taikhoan.Email = txtTK.Text;
            taikhoan.MatKhau = mahoa;

            string result = tkBLL.CheckLogic(taikhoan);

            switch (result)
            {
                case "Quản lý":
                    MessageBox.Show("Đăng nhập thành công với vai trò quản lý!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TrangChu1 trangChu1 = new TrangChu1(email);
                    trangChu1.AnHienChucNangChhoQL();
                    trangChu1.Show();
                    this.Close();
                    break;
                case "Nhân viên":
                    MessageBox.Show("Đăng nhập thành công với vai trò nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TrangChu1 trangChu11 = new TrangChu1(email);
                    trangChu11.AnHienChucNangNV();
                    trangChu11.Show();
                    this.Close();
                    break;
                case "Tài khoản mật khẩu không chính xác":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                case "TK_Rong":
                    MessageBox.Show("Tài khoản không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                case "MK_Rong":
                    MessageBox.Show("Mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                case "Tài khoản không hoạt động":
                    MessageBox.Show("Người này không còn được phép hoạt động trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                default:
                    MessageBox.Show("Có lỗi xảy ra trong quá trình đăng nhập\nXem lại phân quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            TrangChu1 tangChu1 = new TrangChu1();
            tangChu1.Show();
            this.Close();
        }

        // Sự kiện quên mật khẩu
        private void btnQuenMK_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Bạn có muốn gửi mật khẩu mới về email của bạn không?", "Xác nhận gửi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(thongbao == DialogResult.Yes)
            {
                // Lấy email từ TextBox
                string email = txtTK.Text;

                taikhoan.Email = email;

                // Gọi phương thức từ tầng BLL để kiểm tra email và xử lý lưu mật khẩu mới vào cơ sở dữ liệu
                string result = tkBLL.CheckEmail(email);

                // Kiểm tra kết quả trả về từ phương thức BLL
                if (result == "Email tồn tại")
                {
                    // Tạo mật khẩu ngẫu nhiên
                    string matkhaumoi = tkBLL.RanDomMK();

                    // Gửi mật khẩu mới đến email của người dùng
                    tkBLL.GuiEmail(email, matkhaumoi);

                    string mahoaMatkhaumoi = tkBLL.MaHoaMD5(matkhaumoi); // Băm mật khẩu sử dụng MD5

                    tkBLL.CapNhatMatKhau(email, mahoaMatkhaumoi);// Cập nhật mật khẩu mới vào CSDL

                    // Hiển thị thông báo cho người dùng
                    MessageBox.Show("Mật khẩu mới đã được gửi đến email của bạn. Vui lòng kiểm tra email để lấy mật khẩu mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == "Email không tồn tại")
                {
                    // Hiển thị thông báo cho người dùng
                    MessageBox.Show("Email không tồn tại trong hệ thống. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void chkNhoMK_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
