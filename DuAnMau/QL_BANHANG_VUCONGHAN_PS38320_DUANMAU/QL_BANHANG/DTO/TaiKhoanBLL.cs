using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanAccess tkaccess = new TaiKhoanAccess();

        // Xử lý nghiệp vụ Check đăng nhập bao gồm: Kiểm tra tính hợp lệ của tài khoản(Vai trò và tình trạng),
        // kiểm tra email hoặc mật khẩu của tài khoản rỗng không?
        public string CheckLogic(NhanVienDTO taikhoan)
        {
            if (taikhoan.Email == "")
            {
                return "TK_Rong";
            }
            if(taikhoan.MatKhau == "")
            {
                return "MK_Rong";
            }
            
            string info = tkaccess.CheckLogic(taikhoan);
            return info;
        }

        // Xử lý nghiệp vụ truy xuất danh sách các nhân viên từ lớp DAL cho giao diện người dùng để hiển thị
        public List<NhanVienDTO> HienThiNV()
        {
            
            return tkaccess.HienThiNhanVienDTO();
        }

        // Xử lý nghiệp vụ sử dụng để thêm một nhân viên mới vào cơ sở dữ liệu.
        public bool ThemNV(NhanVienDTO nhanVien)
        {
            if (tkaccess.KiemTraTonTaiEmail(nhanVien.Email))
            {
                return false;
            }
            return tkaccess.ThemNVDTO(nhanVien);
        }

        // Xử lý nghiệp vụ xóa một nhân viên khỏi cơ sở dữ liệu
        public bool XoaNV(NhanVienDTO nhanVien)
        {
            return tkaccess.XoaNVDTO(nhanVien);
        }

        // Xử lý nghiệp vụ cập nhật thông tin của một nhân viên trong cơ sở dữ liệu
        public bool SuaNV(NhanVienDTO nhanVien)
        {
            return tkaccess.SuaNVDTO(nhanVien);
        }

        // Xử lý nghiệp vụ sử dụng để tìm kiếm các nhân viên trong cơ sở dữ liệu
        public List<NhanVienDTO> TimKiemNV(string timkiem)
        {
            return tkaccess.TimKiemNVDTO(timkiem);
        }

        // Xử lý nghiệp vụ đổi mật khẩu
        public string DoiMK(string email, string matkhaucu, string matkhaumoi, string nhaplaiMK)
        {
            return tkaccess.DoiMKDTO(email, matkhaucu, matkhaumoi, nhaplaiMK);
        }

        // Xử lý nghiệp vụ Check Email
        public string CheckEmail(string email)
        {
            return tkaccess.CheckEmailDTO(email);
        }

        // Xử lý nghiệp vụ Cập nhật mật khẩu sau khi gửi mail
        public bool CapNhatMatKhau(string email, string matKhauMoi)
        {
            return tkaccess.CapNhatMatKhauDTO(email, matKhauMoi);
        }

        // Xử lý nghiệp vụ Random mật khẩu
        public string RanDomMK()
        {
            // Chuỗi ký tự mà bạn muốn sử dụng cho mật khẩu ngẫu nhiên
            string kytu = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            // Độ dài của mật khẩu ngẫu nhiên bạn muốn tạo
            int dodai = 10;

            // StringBuilder để xây dựng mật khẩu ngẫu nhiên
            StringBuilder matkhau = new StringBuilder();
            Random random = new Random();

            // Lặp qua từng ký tự để tạo mật khẩu ngẫu nhiên
            for (int i = 0; i < dodai; i++)
            {
                // Lấy một ký tự ngẫu nhiên từ chuỗi chars
                char randomKytu = kytu[random.Next(kytu.Length)];

                // Thêm ký tự ngẫu nhiên vào mật khẩu
                matkhau.Append(randomKytu);
            }

            // Trả về mật khẩu ngẫu nhiên đã tạo
            return matkhau.ToString();
        }

        // Xử lý nghiệp vụ Gửi Mail
        public void GuiEmail(string email, string matkhaumoi)
        {
            try
            {
                string EmailCuaToi = "vuconghan1908@gmail.com";
                string matkhau = "tjkw srnx eirf bncg";

                // Tạo đối tượng MailMessage để xây dựng email
                MailMessage mailMessage = new MailMessage(EmailCuaToi, email);
                mailMessage.Subject = "Bạn đã sử dụng tính năng quên mật khẩu";
                mailMessage.Body = $"Chào anh/chị mật khẩu mới truy cập hệ thống là: {matkhaumoi}";

                // Cấu hình thông tin SMTP
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587; // Port của SMTP Server
                smtpClient.Credentials = new NetworkCredential(EmailCuaToi, matkhau);
                smtpClient.EnableSsl = true; // Kích hoạt SSL

                // Gửi email
                smtpClient.Send(mailMessage);

                // Gửi email thành công
                Console.WriteLine("Gửi email thành công!");
            }
            catch (Exception ex)
            {
                // Xử lý khi gửi email thất bại
                Console.WriteLine("Gửi email thất bại: " + ex.Message);
            }
        }

        // Xử lý nghiệp vụ Hiển thị khách hàng
        public List<KhachHangDTO> HienThiKhachHang()
        {
            return tkaccess.HienThiKhachHangDTO();
        }

        // Xử lý nghiệp vụ Tìm kiếm khách hàng
        public List<KhachHangDTO> TimKiemKH(string timkiem)
        {
            return tkaccess.TimKiemKHDTO(timkiem);
        }

        // Xử lý nghiệp vụ Thêm khách hàng
        public bool ThemKH(KhachHangDTO khachhang, NhanVienDTO nhanvien)
        {
            return tkaccess.ThemKHDTO(khachhang, nhanvien);
        }

        // Xử lý nghiệp vụ Xóa khách hàng
        public bool XoaKH(KhachHangDTO khachhang)
        {
            return tkaccess.XoaKHDTO(khachhang);
        }

        // Xử lý nghiệp vụ Sửa khách hàng
        public bool SuaKH(KhachHangDTO khachhang)
        {
            return tkaccess.SuaKHDTO(khachhang);
        }

        // Xử lý nghiệp vụ Hiển thị sản phẩm
        public List<HangDTO> HienThiSP()
        {
            return tkaccess.HienThiSPDTO();
        }

        // Xử lý nghiệp vụ Tìm kiếm sản phẩm
        public List<HangDTO> TimKiemSanPham(string sanpham)
        {
            return tkaccess.TimKiemSanPhamDTO(sanpham);
        }

        // Xử lý nghiệp vụ Thêm hàng
        public bool ThemHang(HangDTO hang, NhanVienDTO nhanvien)
        {
            return tkaccess.ThemHangDTO(hang, nhanvien);
        }

        // Xử lý nghiệp vụ Sửa sản phẩm
        public bool SuaSP(HangDTO hang)
        {
            return tkaccess.SuaSP(hang);
        }

        // Xử lý nghiệp vụ Xóa sản phẩm
        public bool XoaSP(HangDTO hang)
        {
            return tkaccess.XoaSP(hang);
        }

        // Xử lý nghiệp vụ Thống kê sản phẩm
        public DataTable ThongKeSP()
        {
            return tkaccess.ThongKeSPDTO();
        }

        // Xử lý nghiệp vụ Thống kê sản phẩm
        public DataTable ThongKeTonKho()
        {
            return tkaccess.ThongKeTonKhoĐTO();
        }

        // Xử lý mã hóa MD5
        public string MaHoaMD5(string input)
        {
            // Tạo một đối tượng MD5
            using (MD5 md5 = MD5.Create())
            {
                // Chuyển đổi input thành mảng byte và mã hóa thành MD5
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Chuyển đổi mảng byte thành chuỗi hexa
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}
