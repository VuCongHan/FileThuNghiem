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
    public class DAL_Menu : DBConnect
    {
        private static DAL_Menu instance;

        public static DAL_Menu Instance
        {
            get { if (instance == null) instance = new DAL_Menu(); return DAL_Menu.instance; }
            private set { DAL_Menu.instance = value; }
        }

        private DAL_Menu() { }

        SqlConnection Connection;
        SqlDataAdapter SDA;
        DataTable data = new DataTable();

        public DataTable ListMenu(DTO_Menu menu)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_ListMenu @CategoryID = '" + menu.CategoryID + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public DataTable ListCategory()
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_ListCategory";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public DataTable ListMenu_DGV()
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_ListMenu_DGV";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public bool AddMenu(DTO_Menu menu)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_AddMenu @Name = N'" + menu.Name + "', @Price = " + menu.Price + ", @CategoryID = '" + menu.CategoryID + "', @Picture = '" + menu.Picture + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return true;
            }
        }

        public bool UpdateMenu(DTO_Menu menu)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_UpdateMenu @Name = N'" + menu.Name + "', @Price = " + menu.Price + ", @CategoryID = '" + menu.CategoryID + "', @Picture = '" + menu.Picture + "', @IdMenu = " + menu.IdMenu + "";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return true;
            }
        }

        public bool DeleteMenu(DTO_Menu menu)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_DeleteMenu @IdMenu = " + menu.IdMenu + "";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return true;
            }
        }

        public DataTable FindMenu_All(string find)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_FindMenu_All @Find = N'" + find + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public DataTable FindMenu_Category(string find, DTO_Menu menu)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_FindMenu_Category @Find = N'" + find + "', @IdCategory = '" + menu.CategoryID + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }
    }
}
