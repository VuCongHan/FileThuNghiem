using DTO_QuanLyCafe;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLyCafe
{
    public class DAL_Voucher : DBConnect
    {
        private static DAL_Voucher instance;

        public static DAL_Voucher Instance
        {
            get { if (instance == null) instance = new DAL_Voucher(); return DAL_Voucher.instance; }
            private set { DAL_Voucher.instance = value; }
        }

        SqlConnection Connection;
        SqlDataAdapter SDA;
        DataTable data = new DataTable();

        public DataTable ListVoucher()
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_ListVoucher";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }

        }

        public DataTable ListVoucher_DGV()
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_ListVoucher_DGV";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }

        }

        public bool ExistVoucher(DTO_Voucher voucher)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_SelectIdVoucher @IdVoucher = '" + voucher.IdVoucher + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                if (SDA.Fill(data) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool InsertVoucher(DTO_Voucher voucher)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_InsertVoucher @IdVoucher = '" + voucher.IdVoucher + "', @NameVoucher = N'" + voucher.NameVoucher + "', @Percent =" + voucher.Percent + "";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return true;
            }
        }

        public bool UpdateVoucher(DTO_Voucher voucher)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_UpdateVoucher @IdVoucher = '" + voucher.IdVoucher + "', @NameVoucher = N'" + voucher.NameVoucher + "', @Percent =" + voucher.Percent + "";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return true;
            }
        }

        public bool DeleteVoucher(DTO_Voucher voucher)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_DeleteVoucher @IdVoucher = '" + voucher.IdVoucher + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return true;
            }
        }

        public DataTable FindVoucher(string find)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_FindVoucher @Find = N'" + find + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }

        }
    }
}
