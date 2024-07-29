using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class TaikhoanBLL
    {
        TaiKhoanAccess tkaccess = new TaiKhoanAccess();
        public string CheckLogic(TaiKhoan taiKhoan)
        {
            if(taiKhoan.sTaiKhoan == "")
            {
                return "TK_Rong";
            }
            if (taiKhoan.sMatKhau == "")
            {
                return "MK_Rong";
            }

            string info = tkaccess.CheckLogic(taiKhoan);
            return info; // trí què
        }
    }
}
