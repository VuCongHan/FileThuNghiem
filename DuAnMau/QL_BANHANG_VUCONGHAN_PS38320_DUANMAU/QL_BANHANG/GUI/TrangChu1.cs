using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TrangChu1 : Form
    {
        private string email; //

        // Phương thức truy cập get/set cho biến email
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public TrangChu1(string email) : this() // Gọi constructor không đối số
        {
            this.email = email;
        }
        public TrangChu1()
        {
            InitializeComponent();
        }

        private void TrangChu1_Load(object sender, EventArgs e)
        {
            loadlabel();
        }
        
        private void loadlabel()
        {
            caigido.Visible = true;
            caigido.Text = "CHÀO MỪNG: " + email;
        }

        

        // Ẩn hiện chức năng cho quản lý
        public void AnHienChucNangChhoQL()
        {
            dangnhap.Enabled = false;
            dangxuat.Enabled = true;
            tstrDanhMuc.Visible = true;
            tstrThongKe.Visible = true;
        }

        
        public void AnHienChucNangNV()
        {
            AnHienChucNangChhoQL();
            tstrDmk.Visible = true;
            tstrDanhMuc.Visible = true;
            QLNV.Visible = false;
        }

        public void AnChucNangChoNV()
        {
            QLNV.Visible = false;
            tstrThongKe.Visible = false;

            dangnhap.Enabled = false;
        }
        private void dangxuat_Click(object sender, EventArgs e)
        {
            Form1 dangnhap = new Form1();
            dangnhap.ShowDialog();
            this.Close();
        }

        private void tHOÁTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DMQL_SP_Click(object sender, EventArgs e)
        {
            QL_SANPHAM qL_SANPHAM = new QL_SANPHAM(email);
            qL_SANPHAM.Show();
        }

        // Mở file pdf giới thiệu
        private void gIỚITHIỆUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string doidgdan = @"C:\Users\vuhan\Desktop\DuAnMau\QL_BANHANG_VUCONGHAN_PS38320_DUANMAU";
            string tenfile = "VYTA_DETEST_02.pdf";
            string filepath = Path.Combine(doidgdan, tenfile);

            try
            {
                Process.Start(filepath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi\nChi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tstrDmk_Click(object sender, EventArgs e)
        {
            ĐoiMatKhau đoiMatKhau = new ĐoiMatKhau(email);
            đoiMatKhau.Show();
        }

        private void QLNV_Click(object sender, EventArgs e)
        {
            QL_NHANVIEN qL_NHANVIEN = new QL_NHANVIEN();
            qL_NHANVIEN.Show();
        }

        private void DMQL_KH_Click(object sender, EventArgs e)
        {
            QL_KHACHHANG qL_KHACHHANG = new QL_KHACHHANG(email);
            qL_KHACHHANG.Show();
        }

        private void menuThongKeSP_Click(object sender, EventArgs e)
        {
            THONGKE tHONGKE = new THONGKE();
            tHONGKE.Show();
        }

        private void dangnhap_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Hide();
        }

        private void hỆTHỐNGToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Mở file pdf hướng dẫn
        private void hƯỚNGDẪNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string doidgdan = @"C:\Users\vuhan\Desktop\DuAnMau\QL_BANHANG_VUCONGHAN_PS38320_DUANMAU";
            string tenfile = "VYTA_DETEST_02.pdf";
            string filepath = Path.Combine(doidgdan, tenfile);

            try
            {
                Process.Start(filepath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi\nChi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
