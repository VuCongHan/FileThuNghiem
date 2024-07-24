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
    public class DAL_Bill : DBConnect
    {
        private static DAL_Bill instance;

        public static DAL_Bill Instance
        {
            get { if (instance == null) instance = new DAL_Bill(); return DAL_Bill.instance; }
            private set { DAL_Bill.instance = value; }
        }

        SqlConnection Connection;
        SqlDataAdapter SDA;
        DataTable data = new DataTable();
        public DataTable DetailBill(DTO_Bill bill)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_DetailBill @IdTable = " + bill.IdTable + "";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public DataTable DetailBill_DGV(DTO_Bill bill)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_DetailBill_DGV @IdTable = " + bill.IdTable + "";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public DataTable SumTotalBill(DTO_Bill bill)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_SumTotalBill @IdTable = " + bill.IdTable + "";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public DataTable Table(DTO_Bill bill)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_Table @IdTable = " + bill.IdTable + "";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public DataTable TagItem(DTO_Bill bill)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_TagItem @IdMenu = " + bill.IdMenu + "";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public bool DeleteBill(DTO_Bill bill)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_DeleteBill @IdTable = " + bill.IdTable + ", @IdBill = " + bill.IdBill + "";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return true;
            }
        }

        public bool AddBill(DTO_Bill bill)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_AddBill @IdTable = " + bill.IdTable + ", @CheckIn = '" + DateTime.Now + "', @IdVoucher = '#NULL', @IdPayment = '#NULL', @IdStaff = '" + bill.IdStaff + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return true;
            }
        }

        public DataTable BillTable_DGV(DTO_Bill bill)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_BillTable_DGV @IdTable = " + bill.IdTable + "";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public bool MergeBill(DTO_Bill bill, int amountNew)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_MergeBill @IdTable = " + bill.IdTable + ", @IdDetailBill = " + bill.IdDetailBill + ", @Amount = " + bill.Amount + ", @AmountNew = " + amountNew + ", @TotalPrice = " + bill.ToTal + "";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return true;
            }
        }

        public bool MergeBillMenu(DTO_Bill bill, int amountNew)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_MergeBillMenu  @IdDetailBill = " + bill.IdDetailBill + ", @Amount = " + bill.Amount + ", @AmountNew = " + amountNew + "";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return true;
            }
        }

        public bool Detach(DTO_Bill bill, int amountNew)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_Detach @IdTable = " + bill.IdTable + ", @IdDetailBill = " + bill.IdDetailBill + ", @Amount = " + bill.Amount + ", @AmountNew = " + amountNew + ", @Note = N'" + bill.Note + "', @Price = " + bill.Price + ", @TotalPrice = " + bill.ToTal + "";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return true;
            }
        }

        public bool Delete(DTO_Bill bill)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_Delete @IdTable = " + bill.IdTable + ", @IdDetailBill = " + bill.IdDetailBill + "";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return true;
            }
        }

        public bool Merge(int NewIdTable, int OldIdTable, int NewIdBill, int OldIdBill)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_Merge @NewIdTable = " + NewIdTable + ", @OldIdTable = " + OldIdTable + ", @NewIdBill = " + NewIdBill + ", @OldIdBill = " + OldIdBill + "";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return true;
            }

        }

        public bool Switch(int NewIdTable, int OldIdTable)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_Switch @NewIdTable = " + NewIdTable + ", @OldIdTable = " + OldIdTable + "";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return true;
            }
        }

        public bool AddDesertToBill(DTO_Bill bill)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_AddDesertToBill @IdTable = " + bill.IdTable + ", @IdMenu = " + bill.IdMenu + ", @Amount = " + bill.Amount + ", @Price = " + bill.Price + ", @TotalPrice = " + bill.ToTal + ", @Note = N'" + bill.Note + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return true;
            }
        }

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

        public DataTable ListPayMent()
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_ListPayMent";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public bool AddStatistic(DTO_Bill bill)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_AddStatistic @IdBill = " + bill.IdBill + ", @PercentVoucher = " + bill.PercentVoucher + ", @PercentVAT = " + bill.PercentVAT + ", @Total = " + bill.ToTal + ", @Shift = N'" + bill.Shift + "', @NameStaff = N'" + bill.NameStaff + "', @CheckIn = '" + bill.CheckIn + "', @CheckOut = '" + bill.CheckOut + "', @Method = N'" + bill.Method + "', @NameTable = N'" + bill.NameTable + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return true;
            }
        }

        public bool AddDetailStatistic(DTO_Bill bill)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_AddDetailStatistic @IdBill = " + bill.IdBill + ", @NameMenu = N'" + bill.NameMenu + "', @Amount = " + bill.Amount + ", @Price = " + bill.Price + ", @TotalPrice = " + bill.ToTal + ", @Note = N'" + bill.Note + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return true;
            }
        }
    }
}
