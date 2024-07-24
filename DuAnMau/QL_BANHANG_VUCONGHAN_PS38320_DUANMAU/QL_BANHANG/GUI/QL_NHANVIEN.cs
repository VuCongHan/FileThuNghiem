using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class QL_NHANVIEN : Form
    {
        TaiKhoanBLL TaiKhoanBLL = new TaiKhoanBLL();
        public QL_NHANVIEN()
        {
            InitializeComponent();
        }
        
        private void QL_NHANVIEN_Load(object sender, EventArgs e)
        {
            LoadNVdata();
            dataGridViewDSNV.CellClick += DataGridViewDSNV_CellClick;
            txtTimKiem.TextChanged += new EventHandler(txtTimKiem_TextChanged);
        }

        // Sự kiện loadNV lên DataGridView
        private void LoadNVdata()
        {
            List<NhanVienDTO> nhanVien = TaiKhoanBLL.HienThiNV();
            dataGridViewDSNV.DataSource = nhanVien;
        }

        // Sự kiện sau khi nhấn vào thì ta mở texbox và chức năng khác
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtHoTen.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtMatKhau.ReadOnly = false;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
        }

        // Sau khi nhấn vào thì ta đưa lên các texbox và checkbox
        private void DataGridViewDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra chỉ số hàng hợp lệ
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridViewDSNV.Rows[e.RowIndex];

                    txtEmail.Text = row.Cells["Email"].Value?.ToString();
                    txtHoTen.Text = row.Cells["TenNV"].Value?.ToString();
                    txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
                    txtMatKhau.Text = row.Cells["MatKhau"].Value?.ToString();

                    byte VaiTro = (byte)row.Cells["VaiTro"].Value;
                    byte TinhTrang = (byte)row.Cells["TinhTrang"].Value;

                    chkQL.Checked = (VaiTro == 1);
                    chkNV.Checked = (VaiTro == 0);

                    chkHD.Checked = (TinhTrang == 1);
                    chkKHD.Checked = (TinhTrang == 0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi chọn hàng\nChi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Sự kiện Thêm nhân viên
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string matkhau = txtMatKhau.Text;
                if (string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                    string.IsNullOrWhiteSpace(matkhau) ||
                    (!chkQL.Checked && !chkNV.Checked) ||
                    (!chkHD.Checked && !chkKHD.Checked))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin và chọn vai trò cũng như tình trạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra nếu mật khẩu không rỗng thì mã hóa
                if (!string.IsNullOrEmpty(matkhau))
                {
                    matkhau = TaiKhoanBLL.MaHoaMD5(matkhau);
                }

                if (!txtEmail.Text.EndsWith("@gmail.com"))
                {
                    MessageBox.Show("Email phải có định dạng @gmail.com!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                NhanVienDTO nhanVien = new NhanVienDTO()
                {
                    Email = txtEmail.Text,
                    TenNV = txtHoTen.Text,
                    DiaChi = txtDiaChi.Text,
                    VaiTro = chkQL.Checked ? (byte)1 : (byte)0,
                    TinhTrang = chkHD.Checked ? (byte)1 : (byte)0,
                    MatKhau = matkhau,
                };

                bool result = TaiKhoanBLL.ThemNV(nhanVien);

                if (result)
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNVdata();
                }
                else
                {
                    MessageBox.Show("Email đã tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm nhân viên\nChi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Sự kiện xóa nhân viên
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewDSNV.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(result == DialogResult.Yes)
                {
                    try
                    {
                        DataGridViewRow s = dataGridViewDSNV.SelectedRows[0];
                        string email = s.Cells["Email"].Value.ToString();

                        NhanVienDTO nhanVien = new NhanVienDTO()
                        {
                            Email = email,
                        };

                        bool result1 = TaiKhoanBLL.XoaNV(nhanVien);

                        if (result1)
                        {
                            MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadNVdata();
                        }
                        else
                        {

                            MessageBox.Show("Xóa nhân viên thấy bại!\nLý do: Bạn nên xóa khách hàng và sản phẩm có liên quan tới nhân viên này, bằng cách tìm kiếm nhân viên trùng mã nhân viên với nhân viên này và xóa, sau đó quay lại để xóa nhân viên này. Nếu vẫn muốn giữ tệp khách hàng và sản phẩm thì nên để nhân viên này ngừng hoạt động!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
        }

        // Sự kiện làm mới lại texbox và checkbox
        private void btnLMTT_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtMatKhau.Text = "";
            txtTimKiem.Text = "";
            chkQL.Checked = false;
            chkNV.Checked = false;
            chkHD.Checked = false;
            chkKHD.Checked = false;
            LoadNVdata();
        }

        // Sự kiện Sửa
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(dataGridViewDSNV.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow s = dataGridViewDSNV.SelectedRows[0];
                    string email = s.Cells["Email"].Value.ToString();

                    string tenNV = txtHoTen.Text;
                    string diaChi = txtDiaChi.Text;
                    byte vaitro =   chkQL.Checked ? (byte)1 : (byte)0;
                    byte tinhtrang = chkHD.Checked ? (byte)1 : (byte)0;
                    string matkhau = txtMatKhau.Text;

                    // Kiểm tra nếu mật khẩu không rỗng thì mã hóa
                    if (!string.IsNullOrEmpty(matkhau))
                    {
                        matkhau = TaiKhoanBLL.MaHoaMD5(matkhau);
                    }

                    NhanVienDTO nhanVien = new NhanVienDTO()
                    {
                        Email = email,
                        TenNV = tenNV,
                        DiaChi = diaChi,
                        VaiTro = vaitro,
                        TinhTrang = tinhtrang,
                        MatKhau = matkhau
                    };

                    bool result = TaiKhoanBLL.SuaNV(nhanVien);

                    if (result)
                    {
                        MessageBox.Show("Sửa thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadNVdata();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin nhân viên thất bại!\nCẩn thận không sửa Email\nMật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi cập nhật nhân viên\nChi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên trên bảng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Sự kiện Tìm kiếm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string timkiem = txtTimKiem.Text.Trim();
                if (!string.IsNullOrEmpty(timkiem))
                {
                    List<NhanVienDTO> result = TaiKhoanBLL.TimKiemNV(timkiem);
                    dataGridViewDSNV.DataSource = result;
                }
                else
                {
                    LoadNVdata();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tìm kiếm nhân viên\nChi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chkQL_CheckedChanged(object sender, EventArgs e)
        {
            if (chkQL.Checked)
            {
                chkNV.Checked = false;
            }
        }

        private void chkNV_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNV.Checked)
            {
                chkQL.Checked = false;
            }
        }
        private void chkKHD_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKHD.Checked)
            {
                chkHD.Checked = false;
            }
        }

        private void chkHD_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkHD.Checked)
            {
                chkKHD.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}