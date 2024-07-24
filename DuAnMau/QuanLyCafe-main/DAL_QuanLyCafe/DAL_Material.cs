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
    public class DAL_Material : DBConnect
    {
        private static DAL_Material instance;

        public static DAL_Material Instance
        {
            get { if (instance == null) instance = new DAL_Material(); return DAL_Material.instance; }
            private set { DAL_Material.instance = value; }
        }

        private DAL_Material() { }

        SqlConnection Connection;
        SqlDataAdapter SDA;
        DataTable data = new DataTable();

        public DataTable ListMaterial()
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_ListMaterial";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public DataTable ListMaterial_DGV()
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_ListMaterial_DGV";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public bool ExistMaterial(DTO_Material material)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_ListMaterial_Id @IdMaterial = '" + material.IdMaterial + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                if (SDA.Fill(data) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public DataTable SelectMaterial(DTO_Material material)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_ListMaterial_Id @IdMaterial = '" + material.IdMaterial + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public bool InsertMaterial(DTO_Material material)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_InsertMaterial @IdMaterial = '" + material.IdMaterial + "', @NameMaterial = N'" + material.NameMaterial + "', @Amount = " + material.Amount + ", @Type = N'" + material.Type + "', @Status = N'" + material.Status + "', @Producer = N'" + material.Producer + "', @ImportPrice = '" + material.ImportPrice + "', @ImportDate = '" + material.ImportDate + "', @Picture = '" + material.Picture + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return true;
            }
        }

        public bool UpdateMaterial(DTO_Material material)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_UpdateMaterial @IdMaterial = '" + material.IdMaterial + "', @NameMaterial = N'" + material.NameMaterial + "', @Amount = " + material.Amount + ", @Type = N'" + material.Type + "', @Status = N'" + material.Status + "', @Producer = N'" + material.Producer + "', @ImportPrice = '" + material.ImportPrice + "', @ImportDate = '" + material.ImportDate + "', @Picture = '" + material.Picture + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return true;
            }
        }

        public bool DeleteMaterial(DTO_Material material)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_DeleteMaterial @IdMaterial = '" + material.IdMaterial + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return true;
            }
        }

        public DataTable FindMaterial(string find)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_FindMaterial @Find = '" + find + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }
    }
}
