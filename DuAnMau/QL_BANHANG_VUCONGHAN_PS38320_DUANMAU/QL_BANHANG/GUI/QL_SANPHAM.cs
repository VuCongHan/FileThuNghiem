using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace GUI
{
    public partial class QL_SANPHAM : Form
    {
        TaiKhoanBLL TaiKhoanBLL = new TaiKhoanBLL();
        string email;
        public QL_SANPHAM(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void QL_SANPHAM_Load(object sender, EventArgs e)
        {
            LoadSP();
            txtTimKiemSP.TextChanged += new EventHandler(txtTimKiemSP_TextChanged);
            dataGridViewDSSP.CellClick += dataGridViewDSSP_CellClick;
        }

        private void LoadSP()
        {
            List<HangDTO> SP = TaiKhoanBLL.HienThiSP();
            dataGridViewDSSP.DataSource = SP;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaHang.ReadOnly = false;
            txtTenHang.ReadOnly = false;
            txtSoLuong.ReadOnly = false;
            txtDGB.ReadOnly = false;
            txtDGN.ReadOnly = false;
            txtGhiChu.ReadOnly = false;
            btnLuuSP.Enabled = true;
            btnCapNhatSP.Enabled = true;
            btnXoaSP.Enabled = true;
        }

        private void btnLMTT_Click(object sender, EventArgs e)
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            txtSoLuong.Text = "";
            txtDGB.Text = "";
            txtDGN.Text = "";
            txtHinh.Text = "";
            txtGhiChu.Text = "";
            txtTimKiemSP.Text = "";
            pictureBoxSP.Image = null;
            LoadSP();
        }

        private void tbnLMDS_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Sự kiện Tìm kiếm sản phẩm
        private void txtTimKiemSP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string timkiem = txtTimKiemSP.Text.Trim();
                if (!string.IsNullOrEmpty(timkiem))
                {
                    List<HangDTO> result = TaiKhoanBLL.TimKiemSanPham(timkiem);
                    dataGridViewDSSP.DataSource = result;
                }
                else
                {
                    LoadSP();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tìm kiếm sản phẩm\nChi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Sự kiện sau khi nhấn vào datagridview hiển thị lên thồn tin
        private void dataGridViewDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra chỉ số hàng hợp lệ
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridViewDSSP.Rows[e.RowIndex];
                    // Kiểm tra giá trị không phải null trước khi lấy và gán vào TextBox
                    txtMaHang.Text = row.Cells["MaHang"].Value?.ToString();
                    txtTenHang.Text = row.Cells["TenHang"].Value?.ToString();
                    txtSoLuong.Text = row.Cells["SoLuong"].Value?.ToString();
                    txtDGB.Text = row.Cells["DonGiaBan"].Value?.ToString();
                    txtDGN.Text = row.Cells["DonGiaNhap"].Value?.ToString();
                    txtHinh.Text = row.Cells["HinhAnh"].Value?.ToString();
                    txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString();

                    // Hiển thị hình ảnh lên PictureBox
                    string filePath = txtHinh.Text;
                    if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
                    {
                        pictureBoxSP.Image = Image.FromFile(filePath);
                    }
                    else
                    {
                        pictureBoxSP.Image = null; // hoặc hiển thị một hình ảnh mặc định khác
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi chọn hàng\nChi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Sự kiện Thêm sản phẩm
        private void btnLuuSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTenHang.Text) ||
                    string.IsNullOrWhiteSpace(txtSoLuong.Text) ||
                    string.IsNullOrWhiteSpace(txtDGB.Text) ||
                    string.IsNullOrWhiteSpace(txtDGN.Text) ||
                    string.IsNullOrWhiteSpace(txtHinh.Text)||
                    string.IsNullOrWhiteSpace(txtGhiChu.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                /// Lấy thông tin từ các điều khiển trên giao diện người dùng
                string tenHang = txtTenHang.Text;

                int soLuong;
                if (!int.TryParse(txtSoLuong.Text, out soLuong))
                {
                    MessageBox.Show("Số lượng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double donGiaBan;
                if (!double.TryParse(txtDGB.Text, out donGiaBan))
                {
                    MessageBox.Show("Đơn giá bán không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double donGiaNhap;
                if (!double.TryParse(txtDGN.Text, out donGiaNhap))
                {
                    MessageBox.Show("Đơn giá nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string hinhAnh = txtHinh.Text;
                string ghiChu = txtGhiChu.Text;

                // Truyền thông tin đến phương thức ThemHang của lớp BLL
                HangDTO hang = new HangDTO()
                {
                    TenHang = tenHang,
                    SoLuong = soLuong,
                    DonGiaBan = donGiaBan,
                    DonGiaNhap = donGiaNhap,
                    HinhAnh = hinhAnh,
                    GhiChu = ghiChu
                };

                // Truyền thông tin email từ form đăng nhập
                string email = this.email;

                NhanVienDTO nhanVien = new NhanVienDTO() 
                { 
                    Email = email,
                };
                
                

                // Gọi phương thức từ lớp BLL để thêm hàng vào cơ sở dữ liệu
                bool result = TaiKhoanBLL.ThemHang(hang, nhanVien);

                if (result)
                {
                    MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSP();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi thêm sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm sản phẩm\nChi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Sự kiện Sửa sản phẩm
        private void btnCapNhatSP_Click(object sender, EventArgs e)
        {
            if (dataGridViewDSSP.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow s = dataGridViewDSSP.SelectedRows[0];
                    int mahang;
                    if (!int.TryParse(txtMaHang.Text, out mahang))
                    {
                        MessageBox.Show("Mã hàng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string tenhang = txtTenHang.Text;
                    int soluong;
                    if (!int.TryParse(txtSoLuong.Text, out soluong))
                    {
                        MessageBox.Show("Số lượng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    double dgb;
                    if (!double.TryParse(txtDGB.Text, out dgb))
                    {
                        MessageBox.Show("Đơn giá bán không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    double dgn;
                    if (!double.TryParse(txtDGN.Text, out dgn))
                    {
                        MessageBox.Show("Đơn giá nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string hinhanh = txtHinh.Text;
                    string ghichu = txtGhiChu.Text;

                    HangDTO hangDTO = new HangDTO()
                    {
                        MaHang = mahang,
                        TenHang = tenhang,
                        SoLuong = soluong,
                        DonGiaBan = dgb,
                        DonGiaNhap = dgn,
                        HinhAnh = hinhanh,
                        GhiChu = ghichu,
                    };

                    bool result = TaiKhoanBLL.SuaSP(hangDTO);

                    if (result)
                    {
                        MessageBox.Show("Sửa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSP();
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi sửa sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi cập nhật sản phẩm\nChi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm bảng trên bảng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Sự kiện Xóa sản phẩm
        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (dataGridViewDSSP.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DataGridViewRow s = dataGridViewDSSP.SelectedRows[0];
                        int mahang = (int)s.Cells["MaHang"].Value;

                        HangDTO hangDTO = new HangDTO() 
                        { 
                            MaHang = mahang,
                        };

                        bool result1 = TaiKhoanBLL.XoaSP(hangDTO);

                        if (result1)
                        {
                            MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadSP();
                        }
                        else
                        {

                            MessageBox.Show("Xóa sản phẩm thất bại!\nLý do: Bạn nên xóa khách hàng và sản phẩm có liên quan tới nhân viên này, bằng cách tìm kiếm nhân viên trùng mã nhân viên với nhân viên này và xóa, sau đó quay lại để xóa nhân viên này. Nếu vẫn muốn giữ tệp khách hàng và sản phẩm thì nên để nhân viên này ngừng hoạt động!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnThemHinh_Click(object sender, EventArgs e)
        {
            // Tạo một hộp thoại mở tệp để người dùng chọn tệp hình ảnh
            OpenFileDialog openFile = new OpenFileDialog
            {
                Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*",
                FilterIndex = 2, // Mặc định chọn định dạng JPEG
                Title = "Chọn ảnh minh họa cho sản phẩm"
            };

            // Nếu người dùng chọn tệp và nhấn OK
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Lấy đường dẫn tệp hình ảnh đã chọn
                    string dcfile = openFile.FileName;

                    // Hiển thị hình ảnh trong PictureBox
                    pictureBoxSP.Image = Image.FromFile(dcfile);

                    // Hiển thị đường dẫn tệp trong TextBox
                    txtHinh.Text = dcfile;
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu xảy ra lỗi trong quá trình thực hiện
                    MessageBox.Show("Đã xảy ra lỗi\nChi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
