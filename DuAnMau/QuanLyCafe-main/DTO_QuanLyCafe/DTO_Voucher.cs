using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyCafe
{
    public class DTO_Voucher
    {
        private string idVoucher;
        private string nameVoucher;
        private float percent;

        public string IdVoucher { get => idVoucher; set => idVoucher = value; }

        public string NameVoucher { get => nameVoucher; set => nameVoucher = value; }

        public float Percent { get => percent; set => percent = value; }

        public DTO_Voucher() { }
    }
}
