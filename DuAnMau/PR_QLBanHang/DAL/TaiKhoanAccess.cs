using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class TaiKhoanAccess:DatabaseAccess
    {
        public string CheckLogic(TaiKhoan taiKhoan)
        {
            string info = CheckLogicDTO(taiKhoan);
            return info;
        }
    }
}
