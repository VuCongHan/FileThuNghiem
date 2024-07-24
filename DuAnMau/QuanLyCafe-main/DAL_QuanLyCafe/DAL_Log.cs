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
    public class DAL_Log : DBConnect
    {
        private static DAL_Log instance;

        public static DAL_Log Instance
        {
            get { if (instance == null) instance = new DAL_Log(); return DAL_Log.instance; }
            private set { DAL_Log.instance = value; }
        }

        SqlConnection Connection;
        SqlDataAdapter SDA;
        DataTable data = new DataTable();

        public DataTable Log(DTO_Log log)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_Log @Object = N'" + log.Object1 + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public DataTable Logs(DTO_Log log)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_Logs @Object1 = N'" + log.Object1 + "',  @Object2 = N'" + log.Object2 + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public bool InsertLog(DTO_Log log)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_InsertLog @IdStaff = '" + log.IdStaff + "', @Action = N'" + log.Action + "', @Object = N'" + log.Object1 + "', @IdObject = N'" + log.IdObject + "', @DateStart = '" + log.DateStart + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return true;
            }
        }

        public DataTable Statistic_All(string value1, string value2)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_Statistic_All @Value1 = '" + value1 + "', @Value2 = '" + value2 + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public DataTable Statistic_Shift(string value1, string value2, string shift)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_Statistic_Shift  @Value1 = '" + value1 + "', @Value2 = '" + value2 + "', @Shift = N'" + shift + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public DataTable Statistic_Staff(string value1, string value2, string staff)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_Statistic_Staff  @Value1 = '" + value1 + "', @Value2 = '" + value2 + "', @NameStaff = N'" + staff + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public DataTable Statistic_Shift_Staff(string value1, string value2, string shift, string staff)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_Statistic_Shift_Staff  @Value1 = '" + value1 + "', @Value2 = '" + value2 + "', @Shift = N'" + shift + "', @NameStaff = N'" + staff + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public DataTable Statistic(int IdStatistic)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_Statistic @IdStatistic = " + IdStatistic + "";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public DataTable DetailStatistic(int IdStatistic)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_DetailStatistic @IdStatistic = " + IdStatistic + "";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public DataTable StatisticChoose(string value1, string value2)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_StatisticChoose @Value1 = '" + value1 + "', @Value2 = '" + value2 + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public DataTable StatisticChoose_MonthYear(int month, int year)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_StatisticChoose_MonthYear @Month = " + month + ", @Year = " + year;
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public DataTable StatisticChoose_YearStaff(int month, int year, string staff)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_StatisticChoose_YearStaff @Month = " + month + ", @Year = " + year + ", @NameStaff = N'" + staff + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public DataTable StatisticChoose_MonthStaff(string value1, string value2, string staff)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_StatisticChoose_MonthStaff @Value1 = '" + value1 + "', @Value2 = '" + value2 + "', @NameStaff = N'" + staff + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public DataTable ListStatistic_MonthYear(int month, int year)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_ListStatistic_MonthYear @Month = " + month + ", @Year = " + year;
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public DataTable ListStatistic_Year(int year)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_ListStatistic_Year @Year = " + year;
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public DataTable TopDay(string value1, string value2)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_TopDay @Value1 = '" + value1 + "', @Value2 = '" + value2 + "'";
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public DataTable TopMonth(int month, int year)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_TopMonth @Month = " + month + ", @Year = " + year;
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }

        public DataTable TopYear(int year)
        {
            using (Connection = new SqlConnection(_Connection))
            {
                string TruyVan = @"exec sp_TopYear @Year = " + year;
                SDA = new SqlDataAdapter(TruyVan, _Connection);
                data = new DataTable();
                SDA.Fill(data);
                return data;
            }
        }
    }
}
