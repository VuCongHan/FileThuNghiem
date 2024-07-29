using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class DangNhap : Form
    {
        TaiKhoan taikhoan = new TaiKhoan();
        TaikhoanBLL tkBLL = new TaikhoanBLL();
        public DangNhap()
        {
            InitializeComponent();
        }
        // hfudisgdfkjs
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            taikhoan.sTaiKhoan = txtTK.Text;
            taikhoan.sMatKhau = txtMK.Text;
            string getuser = tkBLL.CheckLogic(taikhoan);

            // Thể hiện trả lại kết quả nếu nghiệp vụ không đúng
            switch (getuser)
            {
                case "TK_Rong":
                    MessageBox.Show("Tài khoản không đc để trống!");
                    return;
                case "MK_Rong":
                    MessageBox.Show("Mật khẩu không đc để trống!");
                    return;
                case "Tài khoản mật khẩu không chính xác":
                    MessageBox.Show("Tài khoản mật khẩu không chính xác!");
                    return;
            }

            MessageBox.Show("Đăng nhập thành công hệ thống!");
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
