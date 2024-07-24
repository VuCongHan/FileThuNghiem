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
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            string strcon = @"server=LAPTOP-G3S4NM5H;database=QL_BANHANG;uid=sa;pwd=vuhan1401;";
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }
    public class DatabaseAccess
    {
        // Check tài khoản đăng nhập có đúng không và Check phân quyền cho tài khoản check
        public static string CheckLogicDTO(NhanVienDTO taikhoan)
        {
            string result = "";

            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("DangNhap", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", taikhoan.Email);
                    cmd.Parameters.AddWithValue("@MatKhau", taikhoan.MatKhau);

                    // Thêm tham số trả về
                    SqlParameter returnValue = new SqlParameter();
                    returnValue.ParameterName = "@RETURN_VALUE";
                    returnValue.SqlDbType = SqlDbType.Int;
                    returnValue.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(returnValue);

                    // Thực thi thủ tục
                    cmd.ExecuteNonQuery();

                    // Lấy giá trị trả về
                    int returnCode = (int)cmd.Parameters["@RETURN_VALUE"].Value;

                    // Xác định kết quả dựa trên giá trị trả về
                    if (returnCode == 1)
                    {
                        result = "Quản lý";
                    }
                    else if (returnCode == 0)
                    {
                        result = "Nhân viên";
                    }
                    else if (returnCode == -1)
                    {
                        result = "Tài khoản mật khẩu không chính xác";
                    }
                    else if (returnCode == -2)
                    {
                        result = "Tài khoản không hoạt động";
                    }
                }
            }

            return result;
        }

        // Hiển thị nhân viên lên datagridview
        public List<NhanVienDTO> HienThiNhanVienDTO()
        {
            List<NhanVienDTO> listNVDTO = new List<NhanVienDTO>();

            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("HienThiNhanVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) 
                        {
                            NhanVienDTO NV = new NhanVienDTO()
                            {
                                ID = reader.GetInt32(0),
                                MaNV = reader.GetString(1),
                                Email = reader.GetString(2),
                                TenNV = reader.GetString(3),
                                DiaChi = reader.GetString(4),
                                VaiTro = reader.GetByte(5),
                                TinhTrang = reader.GetByte(6),
                                MatKhau = reader.GetString(7)
                            };
                            listNVDTO.Add(NV);
                        }
                    }
                }
            }
                return listNVDTO;
        }

        // Thêm nhân viên
        public bool ThemNVDTO(NhanVienDTO nhanVien)
        {
            try
            {
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("ThemNhanVien", conn))
                    {
                        cmd.CommandType= CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("Email", nhanVien.Email);
                        cmd.Parameters.AddWithValue("TenNV", nhanVien.TenNV);
                        cmd.Parameters.AddWithValue("DiaChi", nhanVien.DiaChi);
                        cmd.Parameters.AddWithValue("VaiTro", nhanVien.VaiTro);
                        cmd.Parameters.AddWithValue("TinhTrang", nhanVien.TinhTrang);
                        cmd.Parameters.AddWithValue("MatKhau", nhanVien.MatKhau);

                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }

        // Xóa nhân viên
        public bool XoaNVDTO(NhanVienDTO nhanVien)
        {
            try
            {
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("XoaNhanVien", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Email", nhanVien.Email);

                        cmd.ExecuteNonQuery();
                    }
                }
                    return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }

        // Sửa nhân viên
        public bool SuaNVDTO(NhanVienDTO nhanVien)
        {
            try
            {
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SuaNV", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Email", nhanVien.Email);
                        cmd.Parameters.AddWithValue("@TenNV", nhanVien.TenNV);
                        cmd.Parameters.AddWithValue("@DiaChi", nhanVien.DiaChi);
                        cmd.Parameters.AddWithValue("@VaiTro", nhanVien.VaiTro);
                        cmd.Parameters.AddWithValue("@TinhTrang", nhanVien.TinhTrang);
                        cmd.Parameters.AddWithValue("@MatKhau", nhanVien.MatKhau);

                        int hagahhuong = cmd .ExecuteNonQuery();

                        return hagahhuong > 0;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }

        // Tìm kiếm nhân viên
        public List<NhanVienDTO> TimKiemNVDTO(string timkiem)
        {
            List<NhanVienDTO> listnv = new List<NhanVienDTO>();

            try
            {
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("TimKiemNhanVien", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@thamsovao", timkiem);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                NhanVienDTO NV = new NhanVienDTO()
                                {
                                    MaNV = reader.GetString(0),
                                    Email = reader.GetString(1),
                                    TenNV = reader.GetString(2),
                                    DiaChi = reader.GetString(3),
                                    VaiTro = reader.GetByte(4),
                                    TinhTrang = reader.GetByte(5),
                                    MatKhau = reader.GetString(6)
                                };
                                listnv.Add(NV);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }

            return listnv;
        }

        // Đổi mật khẩu
        public string DoiMKDTO(string email, string matkhaucu, string matkhaumoi, string nhaplaiMK)
        {
            try
            {
                string result = "";

                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("DoiMatKhau", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@MatKhauCu", matkhaucu);
                        cmd.Parameters.AddWithValue("@MatKhauMoi", matkhaumoi);
                        cmd.Parameters.AddWithValue("@NhapLaiMatKhauMoi", nhaplaiMK);

                        // Thêm tham số trả về
                        SqlParameter returnValue = new SqlParameter();
                        returnValue.ParameterName = "@RETURN_VALUE";
                        returnValue.SqlDbType = SqlDbType.Int;
                        returnValue.Direction = ParameterDirection.ReturnValue;
                        cmd.Parameters.Add(returnValue);

                        // Thực thi thủ tục
                        cmd.ExecuteNonQuery();

                        // Lấy giá trị trả về
                        int returnCode = (int)cmd.Parameters["@RETURN_VALUE"].Value;

                        // Xác định kết quả dựa trên giá trị trả về
                        if (returnCode == 1)
                        {
                            result = "Đổi mật khẩu thành công";
                        }
                        else if (returnCode == -1)
                        {
                            result = "Email hoặc mật khẩu cũ không chính xác";
                        }
                        else if (returnCode == -2)
                        {
                            result = "Mật khẩu mới và nhập lại mật khẩu mới không khớp";
                        }
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return "Lỗi không xác định!";
            }
        }

        // Check Email có tồn tại không?
        public string CheckEmailDTO(string email)
        {
            string result = "";

            try
            {
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("KiemTraTonTaiEmail", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Email", email);

                        // Thêm tham số trả về
                        SqlParameter returnValue = new SqlParameter();
                        returnValue.ParameterName = "@RETURN_VALUE";
                        returnValue.SqlDbType = SqlDbType.Int;
                        returnValue.Direction = ParameterDirection.ReturnValue;
                        cmd.Parameters.Add(returnValue);

                        // Thực thi thủ tục
                        cmd.ExecuteNonQuery();

                        // Lấy giá trị trả về
                        int returnCode = (int)cmd.Parameters["@RETURN_VALUE"].Value;

                        // Xác định kết quả dựa trên giá trị trả về
                        if (returnCode == 1)
                        {
                            result = "Email tồn tại";
                        }
                        else if (returnCode == 0)
                        {
                            result = "Email không tồn tại";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }

            return result;
        }

        // Cập nhật MK sau khi gửi Mail
        public bool CapNhatMatKhauDTO(string email, string matKhauMoi)
        {
            try
            {
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("CapNhatMatKhau", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@MatKhauMoi", matKhauMoi);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }


        // Hiển thị Khách hàng lên datagridview
        public List<KhachHangDTO> HienThiKhachHangDTO()
        {
            List<KhachHangDTO> ListKHDTO = new List<KhachHangDTO>();

            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("HienThiKhachHang", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            KhachHangDTO KH = new KhachHangDTO()
                            {
                                DienThoai = reader.GetString(0),
                                TenKhachHang = reader.GetString(1),
                                DiaChi = reader.GetString(2),
                                Phai = reader.GetString(3),
                                MaNV = reader.GetString(4),
                                // MaNV = reader.GetString(4)  Nó đây nè thấy hk và trong thủ tục thì thêm mã nhân viên vào để hiể  n thị
                            };
                            ListKHDTO.Add(KH);
                        }
                    }
                }
            }

            return ListKHDTO;
        }

        // Tìm kiếm khách hàng
        public List<KhachHangDTO> TimKiemKHDTO(string timkiem)
        {
            List<KhachHangDTO> listKH = new List<KhachHangDTO>();
            try
            {
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("TimKiemKhachHang", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@thamsovao", timkiem);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                KhachHangDTO KH = new KhachHangDTO() 
                                {
                                    DienThoai = reader.GetString(0),
                                    TenKhachHang = reader.GetString(1),
                                    DiaChi = reader.GetString(2),
                                    Phai = reader.GetString(3),
                                    MaNV = reader.GetString(4),
                                };
                                listKH.Add(KH);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            return listKH;
        }

        // Thêm khách hàng
        public bool ThemKHDTO(KhachHangDTO khachhang, NhanVienDTO nhanvien)
        {
            try
            {
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("ThemKhachHang", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@DienThoai",khachhang.DienThoai);
                        cmd.Parameters.AddWithValue("@TenKhachHang", khachhang.TenKhachHang);
                        cmd.Parameters.AddWithValue("@DiaChi", khachhang.DiaChi);
                        cmd.Parameters.AddWithValue("@Phai", khachhang.Phai);
                        cmd.Parameters.AddWithValue("@Email", nhanvien.Email);

                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }

        // Xóa khách hàng
        public bool XoaKHDTO(KhachHangDTO khachhang)
        {
            try
            {
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("XoaKhachHang", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@DienThoai", khachhang.DienThoai);

                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }

        // Sửa khách hàng
        public bool SuaKHDTO(KhachHangDTO khachhang)
        {
            try
            {
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("CapNhatKhachHang", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@DienThoai", khachhang.DienThoai);
                        cmd.Parameters.AddWithValue("@TenKhachHang", khachhang.TenKhachHang);
                        cmd.Parameters.AddWithValue("@DiaChi", khachhang.DiaChi);
                        cmd.Parameters.AddWithValue("@Phai", khachhang.Phai);

                        int hagahhuong = cmd.ExecuteNonQuery();

                        return hagahhuong > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }

        // Hiển thị sản phẩm
        public List<HangDTO> HienThiSPDTO()
        {
            List<HangDTO> listSP = new List<HangDTO>();

            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("HienThiSanPham", conn))
                {
                    cmd.CommandType= CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            HangDTO SP = new HangDTO()
                            {
                                MaHang = reader.GetInt32(0),
                                TenHang = reader.GetString(1),
                                SoLuong = reader.GetInt32(2),
                                DonGiaBan = reader.GetDouble(3),
                                DonGiaNhap = reader.GetDouble(4),
                                HinhAnh = reader.GetString(5),
                                GhiChu = reader.GetString(6),
                                MaNV = reader.GetString(7),
                            };
                            listSP.Add(SP);
                        }
                    }
                }
            }
                return listSP;
        }

        // Tìm kiếm Sản phẩm
        public List<HangDTO> TimKiemSanPhamDTO(string sanpham)
        {
            List<HangDTO> listSP = new List<HangDTO>();

            try
            {
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("TimKiemSanPham", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@thamsovao", sanpham);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                HangDTO SP = new HangDTO()
                                {
                                    MaHang = reader.GetInt32(0),
                                    TenHang = reader.GetString(1),
                                    SoLuong = reader.GetInt32(2),
                                    DonGiaBan = reader.GetDouble(3),
                                    DonGiaNhap = reader.GetDouble(4),
                                    HinhAnh = reader.GetString(5),
                                    GhiChu = reader.GetString(6),
                                    MaNV = reader.GetString(7)
                                };
                                listSP.Add(SP);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }

            return listSP;
        }

        // Thêm sản phẩm
        public bool ThemHangDTO(HangDTO hang, NhanVienDTO nhanvien)
        {
            try
            {
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("ThemHang", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@TenHang", hang.TenHang);
                        cmd.Parameters.AddWithValue("@SoLuong", hang.SoLuong);
                        cmd.Parameters.AddWithValue("@DonGiaBan", hang.DonGiaBan);
                        cmd.Parameters.AddWithValue("@DonGiaNhap", hang.DonGiaNhap);
                        cmd.Parameters.AddWithValue("@HinhAnh", hang.HinhAnh);
                        cmd.Parameters.AddWithValue("@GhiChu", hang.GhiChu);
                        cmd.Parameters.AddWithValue("@Email", nhanvien.Email);

                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }

        // Sửa sản phẩm
        public bool SuaSPDTO(HangDTO hang)
        {
            try
            {
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("CapNhatSanPham", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MaHang", hang.MaHang);
                        cmd.Parameters.AddWithValue("@TenHang", hang.TenHang);
                        cmd.Parameters.AddWithValue("@SoLuong", hang.SoLuong);
                        cmd.Parameters.AddWithValue("@DonGiaBan", hang.DonGiaBan);
                        cmd.Parameters.AddWithValue("@DonGiaNhap", hang.DonGiaNhap);
                        cmd.Parameters.AddWithValue("@HinhAnh", hang.HinhAnh);
                        cmd.Parameters.AddWithValue("@GhiChu", hang.GhiChu);

                        int hanganhhuong = cmd.ExecuteNonQuery();

                        return hanganhhuong > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }

        // Xóa sản phẩm
        public bool XoaSPDTO(HangDTO hang)
        {
            try
            {
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("XoaSanPham", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MaHang", hang.MaHang);

                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }

        // Thống kê sản phẩm
        public DataTable ThongKeSPDTO()
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                using (SqlCommand cmd = new SqlCommand("ThongKeSanPham",conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    DataTable dt = new DataTable();

                    conn.Open();
                    dt.Load(cmd.ExecuteReader());
                    conn.Close();

                    return dt;
                }
            }
        }

        // Thống kê sản phẩm tồn kho
        public DataTable ThongKeTonKhoĐTO()
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                
                
                using (SqlCommand cmd = new SqlCommand("ThongKeTonKho", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    DataTable dt = new DataTable();

                    conn.Open();
                    dt.Load(cmd.ExecuteReader());
                    conn.Close();

                    return dt;
                }
            }
        }
    }
}