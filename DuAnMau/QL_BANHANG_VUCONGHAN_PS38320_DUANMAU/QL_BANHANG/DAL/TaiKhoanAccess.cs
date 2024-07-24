using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiKhoanAccess:DatabaseAccess
    {   // Thừa kế của check đăng nhập
        public string CheckLogic(NhanVienDTO taikhoan)
        {
            return CheckLogicDTO(taikhoan);
        }

        // Thừa kế của Hiển thị nhân viên lên DataGridView
        public List<NhanVienDTO> HienThiNV()
        {
            return HienThiNhanVienDTO();
        }

        // Thừa kế của Thêm Nhân viên
        public bool ThemNV(NhanVienDTO nhanVien)
        {
            return ThemNVDTO(nhanVien);
        }

        // Kiểm tra xem có Email nào tồn tại ko?
        public bool KiemTraTonTaiEmail(string email)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM NHANVIEN WHERE Email = @Email";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        // Thừa kế Xóa nhân viên
        public bool XoaNV(NhanVienDTO nhanVien)
        {
            return XoaNVDTO(nhanVien);
        }

        // Thừa kế Sửa nhân viên
        public bool SuaNV(NhanVienDTO nhanVien)

        {
            return SuaNVDTO(nhanVien);
        }

        // Thừa kế Tìm kiếm nhân viên
        public List<NhanVienDTO> TimKiemNV(string timkiem)
        {
            return TimKiemNVDTO(timkiem);
        }

        // Thừa kế đổi mật khẩu
        public string DoiMK(string email, string matkhaucu, string matkhaumoi, string nhaplaiMK)
        {
            return DoiMKDTO(email, matkhaucu, matkhaumoi, nhaplaiMK);
        }

        // Thừa kế Check Email
        public string CheckEmail(string email)
        {
            return CheckEmailDTO(email);
        }

        // Thừa kế Cạp nhật MK sau khi gửi mail
        public bool CapNhatMatKhau(string email, string matKhauMoi)
        {
            return CapNhatMatKhauDTO(email, matKhauMoi);
        }

        // Thừa kế Hiển thị khách hàng
        public List<KhachHangDTO> HienThiKhachHang()
        {
            return HienThiKhachHangDTO();
        }

        // Thừa kế Tìm kiếm khách hàng
        public List<KhachHangDTO> TimKiemKH(string timkiem)
        {
            return TimKiemKHDTO(timkiem);
        }

        // Thừa kế thêm Khách hàng
        public bool ThemKH(KhachHangDTO khachhang, NhanVienDTO nhanvien)
        {
            return ThemKHDTO(khachhang, nhanvien);
        }

        // Thừa kế Xóa khách hàng
        public bool XoaKH(KhachHangDTO khachhang)
        {
            return XoaKHDTO(khachhang);
        }

        // Thừa kế sửa khách hàng
        public bool SuaKH(KhachHangDTO khachhang)
        {
            return SuaKHDTO(khachhang);
        }

        // Thừa kế Hiển thị sản phẩm
        public List<HangDTO> HienThiSP()
        {
            return HienThiSPDTO();
        }

        // Thừa kế Tìm kiếm sản phẩm
        public List<HangDTO> TimKiemSanPham(string sanpham)
        {
            return TimKiemSanPhamDTO(sanpham);
        }

        // Thừa kế Thêm hàng
        public bool ThemHang(HangDTO hang, NhanVienDTO nhanvien)
        {
            return ThemHangDTO(hang, nhanvien);
        }

        // Thừa kế sửa sản phẩm
        public bool SuaSP(HangDTO hang)
        {
            return SuaSPDTO(hang);
        }

        // Thừa kế Xóa sản phẩm
        public bool XoaSP(HangDTO hang)
        {
            return XoaSPDTO(hang);
        }

        // Thừa kế Thống kê sản phẩm
        public DataTable ThongKeSP()
        {
            return ThongKeSPDTO();
        }

        // Thừa kế Thống kê sản phẩm Tồn kho
        public DataTable ThongKeTonKho()
        {
            return ThongKeTonKhoĐTO();
        }
    }
}
