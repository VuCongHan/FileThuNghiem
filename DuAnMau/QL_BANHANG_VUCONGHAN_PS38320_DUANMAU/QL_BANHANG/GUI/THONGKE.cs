using BLL;
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
    public partial class THONGKE : Form
    {
        TaiKhoanBLL TaiKhoanBLL = new TaiKhoanBLL();
        public THONGKE()
        {
            InitializeComponent();
            
        }

        private void THONGKE_Load(object sender, EventArgs e)
        {
            LoadTKSP();
            LoadTKSPTK();
        }

        private void LoadTKSP()
        {
            try
            {
                DataTable dataTable = TaiKhoanBLL.ThongKeSP();
                dataGridViewSPNK.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadTKSPTK()
        {
            try
            {
                DataTable dataTable = TaiKhoanBLL.ThongKeTonKho();
                dataGridViewSPTK.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        private void tabTKSPNhapKho_Click(object sender, EventArgs e)
        {
            
        }

        private void tabTKSPTonKho_Click(object sender, EventArgs e)
        {
            
        }
    }
}
