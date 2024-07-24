using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ĐoiMatKhau : Form
    {
        TaiKhoanBLL TaiKhoanBLL = new TaiKhoanBLL();
        string emai;
        public ĐoiMatKhau(string emai)
        {
            InitializeComponent();
            this.emai = emai;
            txtEmail.Text = emai; // Hiển thị email lên texbox
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            string email = this.emai;
            string mkcu = txtMKC.Text;
            string mkmoi = txtMKM.Text;
            string nhaplaiMK = txtNLMK.Text;

            if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(mkcu) ||
                string.IsNullOrEmpty(mkmoi) || string.IsNullOrEmpty(nhaplaiMK))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin mới đổi được mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            string mahoaMKCu = TaiKhoanBLL.MaHoaMD5(mkcu);
            string mahoaMKMoi = TaiKhoanBLL.MaHoaMD5(mkmoi);
            string mahoaNhaplaiMk = TaiKhoanBLL.MaHoaMD5(nhaplaiMK);

            string ketqua = TaiKhoanBLL.DoiMK(email, mahoaMKCu, mahoaMKMoi, mahoaNhaplaiMk);

            // Kiểm tra kết quả và đăng xuất nếu thành công
            if (ketqua == "Đổi mật khẩu thành công")
            {
                MessageBox.Show(ketqua, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Đăng xuất và hiển thị lại form đăng nhập
                TrangChu1 trangChu1 = new TrangChu1();
                trangChu1.Show();
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(ketqua, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
