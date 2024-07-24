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
    public class BUS_Bill
    {
        private static BUS_Bill instance;

        public static BUS_Bill Instance
        {
            get { if (instance == null) instance = new BUS_Bill(); return BUS_Bill.instance; }
            private set { BUS_Bill.instance = value; }
        }

        public DataTable DetailBill(DTO_Bill bill)
        {
            return DAL_Bill.Instance.DetailBill(bill);
        }

        public DataTable DetailBill_DGV(DTO_Bill bill)
        {
            return DAL_Bill.Instance.DetailBill_DGV(bill);
        }

        public DataTable SumTotalBill(DTO_Bill bill)
        {
            return DAL_Bill.Instance.SumTotalBill(bill);
        }

        public DataTable Table(DTO_Bill bill)
        {
            return DAL_Bill.Instance.Table(bill);
        }

        public DataTable TagItem(DTO_Bill bill)
        {
            return DAL_Bill.Instance.TagItem(bill);
        }

        public bool DeleteBill(DTO_Bill bill)
        {
            return DAL_Bill.Instance.DeleteBill(bill);
        }

        public bool AddBill(DTO_Bill bill)
        {
            return DAL_Bill.Instance.AddBill(bill);
        }

        public DataTable BillTable_DGV(DTO_Bill bill)
        {
            return DAL_Bill.Instance.BillTable_DGV(bill);
        }

        public bool MergeBill(DTO_Bill bill, int amountNew)
        {
            return DAL_Bill.Instance.MergeBill(bill, amountNew);
        }

        public bool MergeBillMenu(DTO_Bill bill, int amountNew)
        {
            return DAL_Bill.Instance.MergeBillMenu(bill, amountNew);
        }

        public bool Detach(DTO_Bill bill, int amountNew)
        {
            return DAL_Bill.Instance.Detach(bill, amountNew);
        }

        public bool Delete(DTO_Bill bill)
        {
            return DAL_Bill.Instance.Delete(bill);
        }

        public bool Merge(int NewIdTable, int OldIdTable, int NewIdBill, int OldIdBill)
        {
            return DAL_Bill.Instance.Merge(NewIdTable, OldIdTable, NewIdBill, OldIdBill);
        }

        public bool Switch(int NewIdTable, int OldIdTable)
        {
            return DAL_Bill.Instance.Switch(NewIdTable, OldIdTable);
        }

        public bool AddDesertToBill(DTO_Bill bill)
        {
            return DAL_Bill.Instance.AddDesertToBill(bill);
        }

        public DataTable ListVoucher()
        {
            return DAL_Bill.Instance.ListVoucher();
        }

        public DataTable ListPayMent()
        {
            return DAL_Bill.Instance.ListPayMent();
        }

        public bool AddStatistic(DTO_Bill bill)
        {
            return DAL_Bill.Instance.AddStatistic(bill);
        }

        public bool AddDetailStatistic(DTO_Bill bill)
        {
            return DAL_Bill.Instance.AddDetailStatistic(bill);
        }
    }
}
