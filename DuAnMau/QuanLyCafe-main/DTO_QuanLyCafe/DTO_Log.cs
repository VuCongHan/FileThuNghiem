using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyCafe
{
    public class DTO_Log
    {
        private string idStaff;
        private string action;
        private string object1;
        private string object2;
        private string idObject;
        private DateTime dateStart;

        public string IdStaff { get => idStaff; set => idStaff = value; }

        public string Action { get => action; set => action = value; }

        public string Object1 { get => object1; set => object1 = value; }

        public string Object2 { get => object2; set => object2 = value; }

        public string IdObject { get => idObject; set => idObject = value; }

        public DateTime DateStart { get => dateStart; set => dateStart = value; }
        
    }
}
