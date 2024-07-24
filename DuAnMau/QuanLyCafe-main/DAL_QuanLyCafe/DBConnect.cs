using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLyCafe
{
    public class DBConnect
    {
        protected string _Connection = ConfigurationManager.ConnectionStrings["Data"].ConnectionString;
    }
}
