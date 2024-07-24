using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class SqlConnectionData
    {
        // Tạo chuỗi kết nối cơ sở dữ liệu
        public static SqlConnection Connect()
        {
            string strcon = @"server=LAPTOP-G3S4NM5H;database=QLBanHang;uid=sa;pwd=vuhan1401;";
            SqlConnection conn = new SqlConnection(strcon); // Khởi tạo connect
            return conn;
        }
    }
    public class DatabaseAccess
    {
        public static string CheckLogicDTO(TaiKhoan taiKhoan)
        {
            string user = null;
            // Hàm Connect tới cơ sở dữ liệu
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("proc_logic", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user", taiKhoan.sTaiKhoan);
            command.Parameters.AddWithValue("@pass", taiKhoan.sMatKhau);
            // Kiểm tra quyền ta thêm một cái Paramerters...S
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetString(0);
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Tài khoản mật khẩu không chính xác";
            }
            return user;
        }
    }
}
