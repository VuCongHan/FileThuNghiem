using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new QL_NHANVIEN());
            //Application.Run(new QL_KHACHHANG());
            //Application.Run(new QL_SANPHAM());
            //Application.Run(new THONGKE());
            Application.Run(new TrangChu1());
            //Application.Run(new TrangChu());
        }
    }
}
