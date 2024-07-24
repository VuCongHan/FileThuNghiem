using DAL_QuanLyCafe;
using DTO_QuanLyCafe;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLyCafe
{
    public class BUS_Log
    {
        private static BUS_Log instance;

        public static BUS_Log Instance
        {
            get { if (instance == null) instance = new BUS_Log(); return BUS_Log.instance; }
            private set { BUS_Log.instance = value; }
        }

        public DataTable Log(DTO_Log log)
        {
            return DAL_Log.Instance.Log(log);
        }
        public DataTable Logs(DTO_Log log)
        {
            return DAL_Log.Instance.Logs(log);
        }

        public bool InsertLog(DTO_Log log)
        {
            return DAL_Log.Instance.InsertLog(log);
        }

        public DataTable Statistic_All(string value1, string value2)
        {
            return DAL_Log.Instance.Statistic_All(value1, value2);
        }

        public DataTable Statistic_Shift(string value1, string value2, string shift)
        {
            return DAL_Log.Instance.Statistic_Shift(value1, value2, shift);
        }

        public DataTable Statistic_Staff(string value1, string value2, string staff)
        {
            return DAL_Log.Instance.Statistic_Staff(value1, value2, staff);
        }

        public DataTable Statistic_Shift_Staff(string value1, string value2, string shift, string staff)
        {
            return DAL_Log.Instance.Statistic_Shift_Staff(value1, value2, shift, staff);
        }

        public DataTable Statistic(int IdStatistic)
        {
            return DAL_Log.Instance.Statistic(IdStatistic);
        }

        public DataTable DetailStatistic(int IdStatistic)
        {
            return DAL_Log.Instance.DetailStatistic(IdStatistic);
        }

        public DataTable StatisticChoose(string value1, string value2)
        {
            return DAL_Log.Instance.StatisticChoose(value1, value2);
        }

        public DataTable StatisticChoose_MonthYear(int month, int year)
        {
            return DAL_Log.Instance.StatisticChoose_MonthYear(month, year);
        }

        public DataTable StatisticChoose_YearStaff(int month, int year, string staff)
        {
            return DAL_Log.Instance.StatisticChoose_YearStaff(month, year, staff);
        }

        public DataTable StatisticChoose_MonthStaff(string value1, string value2, string staff)
        {
            return DAL_Log.Instance.StatisticChoose_MonthStaff(value1, value2, staff);
        }

        public DataTable ListStatistic_MonthYear(int month, int year)
        {
            return DAL_Log.Instance.ListStatistic_MonthYear(month, year);
        }

        public DataTable ListStatistic_Year(int year)
        {
            return DAL_Log.Instance.ListStatistic_Year(year);
        }

        public DataTable TopDay(string value1, string value2)
        {
            return DAL_Log.Instance.TopDay(value1, value2);
        }

        public DataTable TopMonth(int month, int year)
        {
            return DAL_Log.Instance.TopMonth(month, year);
        }
        public DataTable TopYear(int year)
        {
            return DAL_Log.Instance.TopYear(year);
        }
    }
}
