using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyCafe
{
    public class DTO_Material
    {
        private string idMaterial;
        private string nameMaterial;
        private int amount;
        private string type;
        private string status;
        private string producer;
        private float importPrice;
        private DateTime importDate;
        private string picture;

        public string IdMaterial { get => idMaterial; set => idMaterial = value; }

        public string NameMaterial { get => nameMaterial; set => nameMaterial = value; }

        public int Amount { get => amount; set => amount = value; }

        public string Type { get => type; set => type = value; }

        public string Status { get => status; set => status = value; }

        public string Producer { get => producer; set => producer = value; }

        public float ImportPrice { get => importPrice; set => importPrice = value; }

        public DateTime ImportDate { get => importDate; set => importDate = value; }

        public string Picture { get => picture; set => picture = value; }
    }
}
