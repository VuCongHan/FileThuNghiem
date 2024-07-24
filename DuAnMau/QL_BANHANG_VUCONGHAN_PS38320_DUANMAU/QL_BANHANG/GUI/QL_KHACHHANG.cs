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
    public partial class QL_KHACHHANG : Form
    {
        TaiKhoanBLL TaiKhoanBLL = new TaiKhoanBLL();
        string email;
        public QL_KHACHHANG(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void QL_KHACHHANG_Load(object sender, EventArgs e)
        {
            LoadKH();
            dataGridViewDSKH.CellClick += dataGridViewDSKH_CellClick;
            txtTimKiemKH.TextChanged += new EventHandler(txtTimKiemKH_TextChanged);
        }

        // Nhấn vào thì hiện các button và cho phép điền vào texbox
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtDienThoai.ReadOnly = false;
            txtHoTen.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            btnLuuKH.Enabled = true;
            btnCapNhatKH.Enabled = true;
            btnXoaKH.Enabled = true;
        }

        // Sự kiện loadKH lên DataGridView
        private void LoadKH()
        {
            List<KhachHangDTO> KH = TaiKhoanBLL.HienThiKhachHang();
            dataGridViewDSKH.DataSource = KH;
        }

        // Sau khi nhấn vào thì ta đưa lên các texbox và checkbox
        private void dataGridViewDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow s = dataGridViewDSKH.Rows[e.RowIndex];
                    string dienthoai = s.Cells["DienThoai"].Value.ToString();
                    string tenKH = s.Cells["TenKhachHang"].Value.ToString();
                    string diachi = s.Cells["DiaChi"].Value.ToString();
                    string phai = s.Cells["Phai"].Value.ToString();

                    txtDienThoai.Text = dienthoai;
                    txtHoTen.Text = tenKH;
                    txtDiaChi.Text = diachi;

                    if(phai == "Nam")
                    {
                        rdoNam.Checked = true;
                    }
                    else if(phai == "Nữ")
                    {
                        rdoNu.Checked = true;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi chọn khách hàng\nChi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Sự kiện tìm kiếm khách hàng
        private void txtTimKiemKH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string timkiem = txtTimKiemKH.Text.Trim();
                if (!string.IsNullOrEmpty(timkiem))
                {
                    List<KhachHangDTO> result = TaiKhoanBLL.TimKiemKH(timkiem);
                    dataGridViewDSKH.DataSource = result;
                }
                else
                {
                    LoadKH();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tìm kiếm khách hàng\nChi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLMTT_Click(object sender, EventArgs e)
        {
            txtDienThoai.Text = "";
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtTimKiemKH.Text = "";
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            LoadKH();
        }

        private void tbnLMDS_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLuuKH_Click(object sender, EventArgs e)
        {
            try
            {
                string dienthoai = txtDienThoai.Text;
                string hovaten = txtHoTen.Text;
                string diachi = txtDiaChi.Text;
                bool nam = rdoNam.Checked;
                bool nu = rdoNu.Checked;
                string phai = nam ? "Nam" : "Nữ";

                if (string.IsNullOrEmpty(dienthoai) || string.IsNullOrEmpty(hovaten) || string.IsNullOrEmpty(diachi) || (!nam && !nu))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!System.Text.RegularExpressions.Regex.IsMatch(dienthoai, @"^\d+$"))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ, vui lòng nhập chỉ các ký tự số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                KhachHangDTO khachHangDTO = new KhachHangDTO()
                { 
                    DienThoai = dienthoai,
                    TenKhachHang = hovaten,
                    DiaChi = diachi,
                    Phai = phai
                };

                string email = this.email;

                NhanVienDTO nhanVienDTO = new NhanVienDTO()
                {
                    Email = email,
                };

                bool result = TaiKhoanBLL.ThemKH(khachHangDTO, nhanVienDTO);

                if (result)
                {
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKH();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi thêm khách hàng! Vui lòng thêm số điện thoại không bị trùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm khách hàng\nChi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCapNhatKH_Click(object sender, EventArgs e)
        {
            if (dataGridViewDSKH.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow s = dataGridViewDSKH.SelectedRows[0];
                    string dienthoai = s.Cells["DienThoai"].Value.ToString();

                    string hovaten = txtHoTen.Text;
                    string diachi = txtDiaChi.Text;
                    string phai = rdoNam.Checked ? "Nam" : (rdoNu.Checked ? "Nữ" : "");


                    KhachHangDTO khachHangDTO = new KhachHangDTO()
                    {
                        DienThoai = dienthoai,
                        TenKhachHang = hovaten,
                        DiaChi = diachi,
                        Phai = phai
                    };

                    bool result = TaiKhoanBLL.SuaKH(khachHangDTO);

                    if (result)
                    {
                        MessageBox.Show("Sửa thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadKH();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin khách hàng thất bại!\nCẩn thận không sửa số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi cập nhật khách hàng\nChi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng trên bảng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (dataGridViewDSKH.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DataGridViewRow s = dataGridViewDSKH.SelectedRows[0];
                        string dienthoai = s.Cells["DienThoai"].Value.ToString();

                        KhachHangDTO khachHangDTO = new KhachHangDTO()
                        {
                            DienThoai = dienthoai,
                        };

                        bool result1 = TaiKhoanBLL.XoaKH(khachHangDTO);

                        if (result1)
                        {
                            MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadKH();
                        }
                        else
                        {

                            MessageBox.Show("Xóa khách hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa nhân viên\nChi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
