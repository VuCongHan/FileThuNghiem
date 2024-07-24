using DAL_QuanLyCafe;
using DTO_QuanLyCafe;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLyCafe
{
    public class BUS_Voucher
    {
        private static BUS_Voucher instance;

        public static BUS_Voucher Instance
        {
            get { if (instance == null) instance = new BUS_Voucher(); return BUS_Voucher.instance; }
            private set { BUS_Voucher.instance = value; }
        }

        public DataTable ListVoucher()
        {
            return DAL_Voucher.Instance.ListVoucher();
        }

        public DataTable ListVoucher_DGV()
        {
            return DAL_Voucher.Instance.ListVoucher_DGV();
        }

        public bool ExistVoucher(DTO_Voucher voucher)
        {
            return DAL_Voucher.Instance.ExistVoucher(voucher);
        }

        public bool InsertVoucher(DTO_Voucher voucher)
        {
            return DAL_Voucher.Instance.InsertVoucher(voucher);
        }

        public bool UpdateVoucher(DTO_Voucher voucher)
        {
            return DAL_Voucher.Instance.UpdateVoucher(voucher);
        }

        public bool DeleteVoucher(DTO_Voucher voucher)
        {
            return DAL_Voucher.Instance.DeleteVoucher(voucher);
        }

        public DataTable FindVoucher(string find)
        {
            return DAL_Voucher.Instance.FindVoucher(find);
        }

    }
}
