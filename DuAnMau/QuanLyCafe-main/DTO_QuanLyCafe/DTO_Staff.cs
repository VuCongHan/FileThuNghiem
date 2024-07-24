using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyCafe
{
    public class DTO_Staff
    {
        private string iDStaff;
        private string nameStaff;
        private string address;
        private string phoneNumber;
        private string email;
        private string genedr;
        private DateTime birthday;
        private string role;
        private string password;
        private string picture;
        private string status;

        public string IDStaff { get => iDStaff; set => iDStaff = value; }

        public string NameStaff { get => nameStaff; set => nameStaff = value; }

        public string Address { get => address; set => address = value; }

        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public string Email { get => email; set => email = value; }

        public string Genedr { get => genedr; set => genedr = value; }

        public DateTime Birthday { get => birthday; set => birthday = value; }

        public string Role { get => role; set => role = value; }

        public string Password { get => password; set => password = value; }

        public string Picture { get => picture; set => picture = value; }

        public string Status { get => status; set => status = value; }

        public DTO_Staff() { }
    }
}
