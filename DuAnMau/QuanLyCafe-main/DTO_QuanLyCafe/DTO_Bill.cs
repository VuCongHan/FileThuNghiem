using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyCafe
{
    public class DTO_Bill
    {
        private int idBill;
        private int idTable;
        private int idDetailBill;
        private int idMenu;
        private int amount;
        private float price;
        private string nameTable;
        private DateTime checkIn;
        private string idVoucher;
        private string idPayment;
        private string idStaff;
        private string note;
        private float percentVoucher;
        private float percentVAT;
        private float toTal;
        private string shift;
        private string nameStaff;
        private DateTime checkOut;
        private string nameMenu;
        private int idStatistic;
        private string method;

        public int IdBill { get => idBill; set => idBill = value; }

        public int IdTable { get => idTable; set => idTable = value; }

        public int IdDetailBill { get => idDetailBill; set => idDetailBill = value; }

        public int IdMenu { get => idMenu; set => idMenu = value; }

        public int Amount { get => amount; set => amount = value; }

        public float Price { get => price; set => price = value; }

        public DateTime CheckIn { get => checkIn; set => checkIn = value; }

        public string IdVoucher { get => idVoucher; set => idVoucher = value; }

        public string IdPayment { get => idPayment; set => idPayment = value; }

        public string IdStaff { get => idStaff; set => idStaff = value; }

        public string Note { get => note; set => note = value; }

        public float PercentVoucher { get => percentVoucher; set => percentVoucher = value; }

        public float PercentVAT { get => percentVAT; set => percentVAT = value; }

        public float ToTal { get => toTal; set => toTal = value; }

        public string Shift { get => shift; set => shift = value; }

        public string NameStaff { get => nameStaff; set => nameStaff = value; }

        public DateTime CheckOut { get => checkOut; set => checkOut = value; }

        public string NameMenu { get => nameMenu; set => nameMenu = value; }

        public int IdStatistic { get => idStatistic; set => idStatistic = value; }

        public string Method { get => method; set => method = value; }

        public string NameTable { get => nameTable; set => nameTable = value; }

        public DTO_Bill() { }
    }
}
