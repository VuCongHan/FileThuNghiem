using DTO_QuanLyCafe;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace DAL_QuanLyCafe
{
    public class DAL_Staff : DBConnect
    {
        private static DAL_Staff instance;

        public static DAL_Staff Instance
        {
            get { if (instance == null) instance = new DAL_Staff(); return instance; }
            private set { instance = value; }
        }

        private DAL_Staff() { }

        SqlConnection Connection;
        SqlDataAdapter SDA;

        DataTable data = new DataTable();

        public bool ExcuteScript()
        {
            Process.Start(Application.StartupPath + @"\data\Data.bat");
            return true;
        }

        public bool AcceptLogin(DTO_Staff staff)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_AcceptLogin @Email = '" + staff.Email + "', @Password = '" + staff.Password + "'";
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

        public bool ForgotPassword(DTO_Staff staff)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_ForgotPassword @Email = '" + staff.Email + "'";
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

        public DataTable Check(DTO_Staff staff)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_ForgotPassword @Email = '" + staff.Email + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public bool UpdatePassword(DTO_Staff staff)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_UpdatePassword @Email = '" + staff.Email + "', @Password = '" + staff.Password + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return true;
            }
        }

        public DataTable ListProfileStaff()
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_ListProfileStaff";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public DataTable ListProfileStaff_DGV()
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_ListProfileStaff_DGV";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public DataTable SelectIdStaff()
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_SelectIdStaff";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public bool InsertProfileStaff(DTO_Staff staff)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_InsertProfileStaff  @NameStaff = N'" + staff.NameStaff + "', @Address = N'" + staff.Address + "', @PhoneNumber = '" + staff.PhoneNumber + "', @Email = '" + staff.Email + "', @Gender = N'" + staff.Genedr + "', @BirthDay = '" + staff.Birthday + "', @Role = N'" + staff.Role + "', @Picture = '" + staff.Picture + "', @Password = '" + staff.Password + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return true;
            }
        }

        public bool UpdateProfileStaff(DTO_Staff staff)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_UpdateProfileStaff  @NameStaff = N'" + staff.NameStaff + "', @Address = N'" + staff.Address + "', @PhoneNumber = '" + staff.PhoneNumber + "', @IdStaff = '" + staff.IDStaff + "', @Gender = N'" + staff.Genedr + "', @BirthDay = '" + staff.Birthday + "', @Role = N'" + staff.Role + "', @Picture = '" + staff.Picture + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return true;
            }
        }

        public bool DeleteProfileStaff(DTO_Staff staff)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_DeleteProfileStaff @IdStaff = '" + staff.IDStaff + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return true;
            }
        }

        public DataTable SelectIdStaff_DGV(DTO_Staff staff)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_SelectIdStaff_DGV @IdStaff = '" + staff.IDStaff + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public DataTable FindProfileStaff_All(string find)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_FindProfileStaff_All @Find = N'" + find + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public DataTable FindProfileStaff_FindBy(string find, string findBy)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_FindProfileStaff_FindBy @FindBy = '" + findBy + "',  @Find = N'" + find + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }
    }
}
