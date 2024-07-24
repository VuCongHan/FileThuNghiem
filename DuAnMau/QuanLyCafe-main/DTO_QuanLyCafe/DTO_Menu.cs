using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyCafe
{
    public class DTO_Menu
    {
        private string name;
        private int amount;
        private float price;
        private string categoryID;
        private string picture;
        private int idMenu;

        public string Name { get => name; set => name = value; }

        public int Amount { get => amount; set => amount = value; }

        public float Price { get => price; set => price = value; }

        public string CategoryID { get => categoryID; set => categoryID = value; }

        public string Picture { get => picture; set => picture = value; }

        public int IdMenu { get => idMenu; set => idMenu = value; }

        public DTO_Menu() { }
    }
}
