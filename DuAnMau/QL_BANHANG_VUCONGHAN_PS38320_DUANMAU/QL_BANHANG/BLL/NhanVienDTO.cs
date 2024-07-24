using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public int ID { get; set; }
        public string MaNV { get; set; }
        public string Email { get; set; }
        public string TenNV { get; set; }
        public string DiaChi { get; set; }
        public byte VaiTro { get; set; }
        public byte TinhTrang { get; set; }
        public string MatKhau { get; set; }
        //public bool DangNhapLanDau { get; set; }
    }
}
