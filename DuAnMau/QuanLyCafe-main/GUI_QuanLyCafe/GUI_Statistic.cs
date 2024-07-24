using BUS_QuanLyCafe;
using DTO_QuanLyCafe;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Point = System.Drawing.Point;
using DataTable = System.Data.DataTable;
using CrystalDecisions.CrystalReports.Engine;
using System.Windows.Forms.DataVisualization.Charting;
using CrystalDecisions.Shared;

namespace GUI_QuanLyCafe
{
    public partial class Statistic_frm : Form
    {
        public Statistic_frm()
        {
            InitializeComponent();
        }

        DTO_Log log = new DTO_Log();
        public static int IdStatistic;
        public static string Month;
        public static string Year;
        public static string Top1;
        public static string Top2;
        public static string Top3;

        private void Statistic_frm_Load(object sender, EventArgs e)
        {
            Table_rdo.Checked = true;
            Find_btn.Location = new Point(500, 200);
            DGV();
            DGV_Day();

            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[] { new DataColumn("IdStaff", typeof(string)), new DataColumn("NameStaff", typeof(string)) });

            for (int i = 0; i < BUS_Staff.Instance.ListProfileStaff().Rows.Count; i++)
            {
                dt.Rows.Add(BUS_Staff.Instance.ListProfileStaff().Rows[i][0].ToString(), BUS_Staff.Instance.ListProfileStaff().Rows[i][1].ToString());
            }

            DataRow row = dt.NewRow();
            row[0] = "ALL";
            row[1] = "Tất cả";
            dt.Rows.InsertAt(row, 0);

            Staff_cbb.DataSource = dt;
            Staff_cbb.DisplayMember = "NameStaff";
            Staff_cbb.ValueMember = "IdStaff";
        }
        private void DGV()
        {
            Statistic_dgv.Rows.Clear();
            Statistic_dgv.Columns.Clear();
            Statistic_dgv.Columns.Add("CheckOut", "Thời gian");
            Statistic_dgv.Columns.Add("Shift", "Ca");
            Statistic_dgv.Columns.Add("NameStaff", "Nhân viên");
            Statistic_dgv.Columns.Add("Price", "Tống");
            Statistic_dgv.Columns.Add("IdStatistic", "Id Statistic");
            Statistic_dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Statistic_dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Statistic_dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Statistic_dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Statistic_dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Statistic_dgv.Columns[4].Visible = false;
        }

        private void Chart()
        {
            try
            {
                int i = 0;
                double tempH = 0;
                double tempL = 0;
                int Higher = 0;
                int Lower = 0;

                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }
                chart1.Titles.Clear();

                foreach (DataGridViewRow item in Statistic_dgv.Rows)
                {
                    var Total = item.Cells[1].Value.ToString().Replace(" VNĐ", "");
                    chart1.Series["Doanh thu"].Points.Add(Convert.ToDouble(Total));
                    chart1.Series["Doanh thu"].Points[i].AxisLabel = item.Cells[0].Value.ToString();
                    chart1.Series["Doanh thu"].Points[i].LegendText = item.Cells[0].Value.ToString();
                    chart1.Series["Doanh thu"].Points[i].ToolTip = item.Cells[1].Value.ToString();
                    if (Convert.ToDouble(Total) >= tempH)
                    {
                        tempH = Convert.ToDouble(Total);
                        Higher = i;
                    }

                    foreach (DataGridViewRow lower in Statistic_dgv.Rows)
                    {
                        if (tempL == 0)
                        {
                            tempL = Convert.ToDouble(Total);
                            Lower = i;
                        }
                        else if (Convert.ToDouble(Total) <= Convert.ToDouble(lower.Cells[1].Value.ToString().Replace(" VNĐ", "")) && Convert.ToDouble(Total) <= tempL)
                        {
                            tempL = Convert.ToDouble(Total);
                            Lower = i;
                        }
                    }
                    i++;
                }
                chart1.Series["Doanh thu"].Points[Higher].Color = Color.Chocolate;
                chart1.Series["Doanh thu"].Points[Lower].Color = Color.IndianRed;
                

                chart1.Series.Add("Doanh thu cao nhất");
                chart1.Series["Doanh thu cao nhất"].Color = Color.Chocolate;

                chart1.Series.Add("Doanh thu thấp nhất");
                chart1.Series["Doanh thu thấp nhất"].Color = Color.IndianRed;
            }
            catch (Exception) { }
        }

        private void ChartStaff()
        {
            try
            {
                int i = 0;
                double tempH = 0;
                double tempL = 0;
                int Higher = 0;
                int Lower = 0;
                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }
                chart1.Titles.Clear();
                Title title = chart1.Titles.Add(Staff_cbb.Text.ToUpper());
                title.Font = new System.Drawing.Font("Times New Roman", 22, FontStyle.Bold);

                foreach (DataGridViewRow item in Statistic_dgv.Rows)
                {
                    var Total = item.Cells[2].Value.ToString().Replace(" VNĐ", "");
                    chart1.Series["Doanh thu"].Points.Add(Convert.ToDouble(Total));
                    chart1.Series["Doanh thu"].Points[i].AxisLabel = item.Cells[0].Value.ToString();
                    chart1.Series["Doanh thu"].Points[i].LegendText = item.Cells[0].Value.ToString();
                    chart1.Series["Doanh thu"].Points[i].ToolTip = item.Cells[2].Value.ToString();
                    if (Convert.ToDouble(Total) >= tempH)
                    {
                        tempH = Convert.ToDouble(Total);
                        Higher = i;
                    }

                    foreach (DataGridViewRow lower in Statistic_dgv.Rows)
                    {
                        if (tempL == 0)
                        {
                            tempL = Convert.ToDouble(Total);
                            Lower = i;
                        }
                        else if (Convert.ToDouble(Total) <= Convert.ToDouble(lower.Cells[2].Value.ToString().Replace(" VNĐ", "")) && Convert.ToDouble(Total) <= tempL)
                        {
                            tempL = Convert.ToDouble(Total);
                            Lower = i;
                        }
                    }
                    i++;
                }

                chart1.Series["Doanh thu"].Points[Higher].Color = Color.Chocolate;
                chart1.Series["Doanh thu"].Points[Lower].Color = Color.IndianRed;


                chart1.Series.Add("Doanh thu cao nhất");
                chart1.Series["Doanh thu cao nhất"].Color = Color.Chocolate;

                chart1.Series.Add("Doanh thu thấp nhất");
                chart1.Series["Doanh thu thấp nhất"].Color = Color.IndianRed;


            }
            catch (Exception) { }
        }

        private void DGV_Day()
        {
            Statistic_dgv.AllowUserToAddRows = true;
            float Total = 0;
            for (int i = 0; i < BUS_Log.Instance.Statistic_All(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59")).Rows.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)Statistic_dgv.Rows[0].Clone();
                row.Cells[0].Value = DateTime.Parse(BUS_Log.Instance.Statistic_All(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59")).Rows[i][8].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
                row.Cells[1].Value = BUS_Log.Instance.Statistic_All(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59")).Rows[i][5].ToString();
                row.Cells[2].Value = BUS_Log.Instance.Statistic_All(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59")).Rows[i][6].ToString();
                float value = (float)double.Parse(BUS_Log.Instance.Statistic_All(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59")).Rows[i][4].ToString());
                Total += value;
                string price = String.Format("{0:0,0}", value);
                row.Cells[3].Value = price;
                row.Cells[3].Style.ForeColor = Color.Red;
                row.Cells[4].Value = BUS_Log.Instance.Statistic_All(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59")).Rows[i][0].ToString();
                Statistic_dgv.Rows.Add(row);
            }

            string PriceTotal = String.Format("{0:0,0}", Total);
            Total_txt.Text = PriceTotal + " VNĐ";
            foreach (DataGridViewColumn dgvc in Statistic_dgv.Columns)
            {
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            Statistic_dgv.AllowUserToAddRows = false;

            TopDay();
        }

        private void DGV_Day_Shift()
        {
            Statistic_dgv.AllowUserToAddRows = true;
            float Total = 0;
            for (int i = 0; i < BUS_Log.Instance.Statistic_Shift(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59"), Shift_cbb.Text).Rows.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)Statistic_dgv.Rows[0].Clone();
                row.Cells[0].Value = DateTime.Parse(BUS_Log.Instance.Statistic_Shift(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59"), Shift_cbb.Text).Rows[i][8].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
                row.Cells[1].Value = BUS_Log.Instance.Statistic_Shift(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59"), Shift_cbb.Text).Rows[i][5].ToString();
                row.Cells[2].Value = BUS_Log.Instance.Statistic_Shift(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59"), Shift_cbb.Text).Rows[i][6].ToString();
                float value = (float)double.Parse(BUS_Log.Instance.Statistic_Shift(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59"), Shift_cbb.Text).Rows[i][4].ToString());
                Total += value;
                string price = String.Format("{0:0,0}", value);
                row.Cells[3].Value = price;
                row.Cells[3].Style.ForeColor = Color.Red;
                row.Cells[4].Value = BUS_Log.Instance.Statistic_Shift(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59"), Shift_cbb.Text).Rows[i][0].ToString();
                Statistic_dgv.Rows.Add(row);
            }

            string PriceTotal = String.Format("{0:0,0}", Total);
            Total_txt.Text = PriceTotal + " VNĐ";
            foreach (DataGridViewColumn dgvc in Statistic_dgv.Columns)
            {
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            Statistic_dgv.AllowUserToAddRows = false;

            TopDay();
        }

        private void DGV_Day_Staff()
        {
            Statistic_dgv.AllowUserToAddRows = true;
            float Total = 0;
            for (int i = 0; i < BUS_Log.Instance.Statistic_Staff(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59"), Staff_cbb.Text).Rows.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)Statistic_dgv.Rows[0].Clone();
                row.Cells[0].Value = DateTime.Parse(BUS_Log.Instance.Statistic_Staff(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59"), Staff_cbb.Text).Rows[i][8].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
                row.Cells[1].Value = BUS_Log.Instance.Statistic_Staff(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59"), Staff_cbb.Text).Rows[i][5].ToString();
                row.Cells[2].Value = BUS_Log.Instance.Statistic_Staff(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59"), Staff_cbb.Text).Rows[i][6].ToString();
                float value = (float)double.Parse(BUS_Log.Instance.Statistic_Staff(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59"), Staff_cbb.Text).Rows[i][4].ToString());
                Total += value;
                string price = String.Format("{0:0,0}", value);
                row.Cells[3].Value = price;
                row.Cells[3].Style.ForeColor = Color.Red;
                row.Cells[4].Value = BUS_Log.Instance.Statistic_Staff(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59"), Staff_cbb.Text).Rows[i][0].ToString();
                Statistic_dgv.Rows.Add(row);
            }

            string PriceTotal = String.Format("{0:0,0}", Total);
            Total_txt.Text = PriceTotal + " VNĐ";
            foreach (DataGridViewColumn dgvc in Statistic_dgv.Columns)
            {
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            Statistic_dgv.AllowUserToAddRows = false;

            TopDay();
        }

        private void DGV_Day_Shift_Staff()
        {
            Statistic_dgv.AllowUserToAddRows = true;
            float Total = 0;
            for (int i = 0; i < BUS_Log.Instance.Statistic_Shift_Staff(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59"), Shift_cbb.Text, Staff_cbb.Text).Rows.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)Statistic_dgv.Rows[0].Clone();
                row.Cells[0].Value = DateTime.Parse(BUS_Log.Instance.Statistic_Shift_Staff(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59"), Shift_cbb.Text, Staff_cbb.Text).Rows[i][8].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
                row.Cells[1].Value = BUS_Log.Instance.Statistic_Shift_Staff(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59"), Shift_cbb.Text, Staff_cbb.Text).Rows[i][5].ToString();
                row.Cells[2].Value = BUS_Log.Instance.Statistic_Shift_Staff(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59"), Shift_cbb.Text, Staff_cbb.Text).Rows[i][6].ToString();
                float value = (float)double.Parse(BUS_Log.Instance.Statistic_Shift_Staff(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59"), Shift_cbb.Text, Staff_cbb.Text).Rows[i][4].ToString());
                Total += value;
                string price = String.Format("{0:0,0}", value);
                row.Cells[3].Value = price;
                row.Cells[3].Style.ForeColor = Color.Red;
                row.Cells[4].Value = BUS_Log.Instance.Statistic_Shift_Staff(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59"), Shift_cbb.Text, Staff_cbb.Text).Rows[i][0].ToString();
                Statistic_dgv.Rows.Add(row);
            }

            string PriceTotal = String.Format("{0:0,0}", Total);
            Total_txt.Text = PriceTotal + " VNĐ";
            foreach (DataGridViewColumn dgvc in Statistic_dgv.Columns)
            {
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            Statistic_dgv.AllowUserToAddRows = false;

            TopDay();
        }

        private void DGV_Month()
        {
            float Total = 0;
            Statistic_dgv.AllowUserToAddRows = true;
            Statistic_dgv.Columns.Clear();
            Statistic_dgv.Rows.Clear();
            Statistic_dgv.Columns.Add("CheckOut", "Thời gian");
            Statistic_dgv.Columns.Add("Total", "Tổng tiền");
            Statistic_dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Statistic_dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            string temp = "";
            int month = Convert.ToInt32(Value1_cbb.Text);
            int year = Convert.ToInt32(Value2_cbb.Text);
            for (int i = 0; i < BUS_Log.Instance.ListStatistic_MonthYear(month, year).Rows.Count; i++)
            {
                if (DateTime.Parse(BUS_Log.Instance.ListStatistic_MonthYear(month, year).Rows[i][8].ToString()).ToString("dd/MM/yyyy") != temp)
                {
                    string Value1 = DateTime.Parse(BUS_Log.Instance.ListStatistic_MonthYear(month, year).Rows[i][8].ToString()).ToString("yyyy/MM/dd 00:00:00");
                    string Value2 = DateTime.Parse(BUS_Log.Instance.ListStatistic_MonthYear(month, year).Rows[i][8].ToString()).ToString("yyyy/MM/dd 23:59:59");
                    temp = DateTime.Parse(BUS_Log.Instance.ListStatistic_MonthYear(month, year).Rows[i][8].ToString()).ToString("dd/MM/yyyy");
                    Month = Value1_cbb.Text;
                    DataGridViewRow row = (DataGridViewRow)Statistic_dgv.Rows[0].Clone();
                    row.Cells[0].Value = DateTime.Parse(BUS_Log.Instance.StatisticChoose(Value1, Value2).Rows[0][0].ToString()).ToString("ddd dd/MM/yyyy");
                    float value = (float)double.Parse(BUS_Log.Instance.StatisticChoose(Value1, Value2).Rows[0][1].ToString());
                    Total += value;
                    string price = String.Format("{0:0,0}", value);
                    row.Cells[1].Value = price;
                    row.Cells[1].Style.ForeColor = Color.Red;
                    Statistic_dgv.Rows.Add(row);
                }
            }

            string PriceTotal = String.Format("{0:0,0}", Total);
            Total_txt.Text = PriceTotal + " VNĐ";
            Statistic_dgv.AllowUserToAddRows = false;

            TopMonth(month, year);
        }

        private void DGV_MonthStaff()
        {
            float Total = 0;
            Statistic_dgv.AllowUserToAddRows = true;
            Statistic_dgv.Columns.Clear();
            Statistic_dgv.Rows.Clear();
            Statistic_dgv.Columns.Add("CheckOut", "Thời gian");
            Statistic_dgv.Columns.Add("NameStaff", "Tên nhân viên");
            Statistic_dgv.Columns.Add("Total", "Tổng tiền");
            Statistic_dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Statistic_dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Statistic_dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            string temp = "";
            int month = Convert.ToInt32(Value1_cbb.Text);
            int year = Convert.ToInt32(Value2_cbb.Text);
            string staff = Staff_cbb.Text;

            for (int i = 0; i < BUS_Log.Instance.ListStatistic_MonthYear(month, year).Rows.Count; i++)
            {
                if (DateTime.Parse(BUS_Log.Instance.ListStatistic_MonthYear(month, year).Rows[i][8].ToString()).ToString("dd/MM/yyyy") != temp)
                {
                    string Value1 = DateTime.Parse(BUS_Log.Instance.ListStatistic_MonthYear(month, year).Rows[i][8].ToString()).ToString("yyyy/MM/dd 00:00:00");
                    string Value2 = DateTime.Parse(BUS_Log.Instance.ListStatistic_MonthYear(month, year).Rows[i][8].ToString()).ToString("yyyy/MM/dd 23:59:59");
                    temp = DateTime.Parse(BUS_Log.Instance.ListStatistic_MonthYear(month, year).Rows[i][8].ToString()).ToString("dd/MM/yyyy");
                    Month = Value1_cbb.Text;

                    if (BUS_Log.Instance.StatisticChoose_MonthStaff(Value1, Value2, staff).Rows.Count > 0)
                    {
                        DataGridViewRow row = (DataGridViewRow)Statistic_dgv.Rows[0].Clone();
                        row.Cells[0].Value = DateTime.Parse(BUS_Log.Instance.StatisticChoose_MonthStaff(Value1, Value2, staff).Rows[0][0].ToString()).ToString("ddd dd/MM/yyyy");
                        row.Cells[1].Value = staff;
                        float value = (float)double.Parse(BUS_Log.Instance.StatisticChoose_MonthStaff(Value1, Value2, staff).Rows[0][1].ToString());
                        Total += value;
                        string price = String.Format("{0:0,0}", value);
                        row.Cells[2].Value = price;
                        row.Cells[2].Style.ForeColor = Color.Red;
                        Statistic_dgv.Rows.Add(row);
                    }
                }
            }
            string PriceTotal = String.Format("{0:0,0}", Total);
            Total_txt.Text = PriceTotal + " VNĐ";
            Statistic_dgv.AllowUserToAddRows = false;

            TopMonth(month, year);
        }

        private void DGV_Year()
        {
            float Total = 0;
            Statistic_dgv.AllowUserToAddRows = true;
            Statistic_dgv.Columns.Clear();
            Statistic_dgv.Rows.Clear();
            Statistic_dgv.Columns.Add("CheckOut", "Thời gian");
            Statistic_dgv.Columns.Add("Total", "Tổng tiền");
            Statistic_dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Statistic_dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            string temp = "";
            Year = Value1_cbb.Text;
            int year = Convert.ToInt32(Value1_cbb.Text);
            if (BUS_Log.Instance.ListStatistic_Year(Convert.ToInt32(Value1_cbb.Text)).Rows.Count > 0)
            {
                for (int j = 1; j <= 12; j++)
                {
                    int month = j;
                    if (DateTime.Parse(BUS_Log.Instance.ListStatistic_MonthYear(month, year).Rows[0][8].ToString()).ToString("MM/yyyy") != temp)
                    {
                        if (BUS_Log.Instance.StatisticChoose_MonthYear(month, year).Rows[0][0].ToString() != "")
                        {
                            temp = month + "/" + Year;
                            DataGridViewRow row = (DataGridViewRow)Statistic_dgv.Rows[0].Clone();
                            if (month <= 9)
                            {
                                row.Cells[0].Value = "0" + month + "/" + Year;
                            }
                            else
                            {
                                row.Cells[0].Value = month + "/" + Year;
                            }
                          
                            float value = (float)double.Parse(BUS_Log.Instance.StatisticChoose_MonthYear(month, year).Rows[0][0].ToString());
                            Total += value;
                            string price = String.Format("{0:0,0}", value);
                            row.Cells[1].Value = price;
                            row.Cells[1].Style.ForeColor = Color.Red;
                            Statistic_dgv.Rows.Add(row);
                        }
                    }
                }
            }
            string PriceTotal = String.Format("{0:0,0}", Total);
            Total_txt.Text = PriceTotal + " VNĐ";
            Statistic_dgv.AllowUserToAddRows = false;

            TopYear(year);
        }

        private void DGV_YearStaff()
        {
            float Total = 0;
            Statistic_dgv.AllowUserToAddRows = true;
            Statistic_dgv.Columns.Clear();
            Statistic_dgv.Rows.Clear();
            Statistic_dgv.Columns.Add("CheckOut", "Thời gian");
            Statistic_dgv.Columns.Add("NameStaff", "Tên nhân viên");
            Statistic_dgv.Columns.Add("Total", "Tổng tiền");
            Statistic_dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Statistic_dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Statistic_dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            string temp = "";
            Year = Value1_cbb.Text;
            int year = Convert.ToInt32(Value1_cbb.Text);
            if (BUS_Log.Instance.ListStatistic_Year(Convert.ToInt32(Value1_cbb.Text)).Rows.Count > 0)
            {
                for (int j = 1; j <= 12; j++)
                {
                    int month = j;
                    string staff = Staff_cbb.Text;
                    if (DateTime.Parse(BUS_Log.Instance.ListStatistic_MonthYear(month, year).Rows[0][8].ToString()).ToString("MM/yyyy") != temp)
                    {
                        if (BUS_Log.Instance.StatisticChoose_YearStaff(month, year, staff).Rows[0][0].ToString() != "")
                        {
                            temp = month + "/" + Year;
                            DataGridViewRow row = (DataGridViewRow)Statistic_dgv.Rows[0].Clone();
                            if (month <= 9)
                            {
                                row.Cells[0].Value = "0" + month + "/" + Year;
                            }
                            else
                            {
                                row.Cells[0].Value = month + "/" + Year;
                            }
                            row.Cells[1].Value = staff;
                            float value = (float)double.Parse(BUS_Log.Instance.StatisticChoose_YearStaff(month, year, staff).Rows[0][0].ToString());
                            Total += value;
                            string price = String.Format("{0:0,0}", value);
                            row.Cells[2].Value = price;
                            row.Cells[2].Style.ForeColor = Color.Red;
                            Statistic_dgv.Rows.Add(row);
                        }
                    }
                }
            }
            string PriceTotal = String.Format("{0:0,0}", Total);
            Total_txt.Text = PriceTotal + " VNĐ";
            Statistic_dgv.AllowUserToAddRows = false;

            TopYear(year);
        }

        private void Statistic_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = Statistic_dgv.Rows[e.RowIndex];
                IdStatistic = Convert.ToInt32(row.Cells[4].Value.ToString());
                DetailStatistic_frm detailStatistic = new DetailStatistic_frm();
                detailStatistic.ShowDialog();
            }
            catch (Exception) { }
        }

        private void Find_btn_Click(object sender, EventArgs e)
        {
            if (Shift_cbb.Text == "None" && Choose_cbb.Text == "Ngày" && Staff_cbb.Text == "Tất cả")
            {
                DGV();
                DGV_Day();
                Chart_rdo.Visible = false;
                Table_rdo.Visible = false;
                Table_rdo.Checked = true;
            }
            else if (Shift_cbb.Text != "None" && Choose_cbb.Text == "Ngày" && Staff_cbb.Text == "Tất cả")
            {
                DGV();
                DGV_Day_Shift();
                Chart_rdo.Visible = false;
                Table_rdo.Visible = false;
                Table_rdo.Checked = true;
            }
            else if (Shift_cbb.Text == "None" && Choose_cbb.Text == "Ngày" && Staff_cbb.Text != "Tất cả")
            {
                DGV();
                DGV_Day_Staff();
                Chart_rdo.Visible = false;
                Table_rdo.Visible = false;
                Table_rdo.Checked = true;
            }
            else if (Shift_cbb.Text != "None" && Choose_cbb.Text == "Ngày" && Staff_cbb.Text != "Tất cả")
            {
                DGV();
                DGV_Day_Shift_Staff();
                Chart_rdo.Visible = false;
                Table_rdo.Visible = false;
                Table_rdo.Checked = true;
            }
            else if (Shift_cbb.Text == "None" && Choose_cbb.Text == "Tháng" && Staff_cbb.Text == "Tất cả")
            {
                DGV();
                DGV_Month();
                Chart_rdo.Visible = true;
                Table_rdo.Visible = true;
                Chart();
            }
            else if (Shift_cbb.Text == "None" && Choose_cbb.Text == "Năm" && Staff_cbb.Text == "Tất cả")
            {
                DGV();
                DGV_Year();
                Chart_rdo.Visible = true;
                Table_rdo.Visible = true;
                Chart();
            }
            else if (Shift_cbb.Text == "None" && Choose_cbb.Text == "Tháng" && Staff_cbb.Text != "Tất cả")
            {
                DGV();
                DGV_MonthStaff();
                Chart_rdo.Visible = true;
                Table_rdo.Visible = true;
                ChartStaff();
            }
            else if (Shift_cbb.Text == "None" && Choose_cbb.Text == "Năm" && Staff_cbb.Text != "Tất cả")
            {
                DGV();
                DGV_YearStaff();
                Chart_rdo.Visible = true;
                Table_rdo.Visible = true;
                ChartStaff();
            }
        }

        private void ExportExcel(DataGridView e, string Path)
        {
            try
            {
                int count1 = 0;
                int count2 = 0;
                var Execl = new Microsoft.Office.Interop.Excel.Application();

                Microsoft.Office.Interop.Excel.Workbook Workbook;
                Workbook = Execl.Workbooks.Add(Type.Missing);

                Microsoft.Office.Interop.Excel.Worksheet Worksheet;
                Worksheet = (Worksheet)Workbook.Sheets["Sheet1"];
                Worksheet.Name = "Doanh thu";

                if (Choose_cbb.Text == "Tháng" && Staff_cbb.Text == "Tất cả")
                {
                    Worksheet.Cells[2, 2] = "DOANH THU THÁNG " + Month;

                    Execl.Columns.Style.Font.Size = 16;
                    Worksheet.Cells[2, 2].EntireRow.Font.Size = 18;
                    Worksheet.Cells[2, 2].EntireRow.Font.Bold = true;
                    Worksheet.Range["B2:C2"].Merge();
                    Worksheet.Range["B2:C2"].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    Execl.Columns.ColumnWidth = 30;
                    for (int i = 0; i < e.Columns.Count; i++)
                    {
                        Worksheet.Cells[4, i + 2] = e.Columns[i].HeaderText;
                        Worksheet.Cells[4, i + 2].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        Worksheet.Cells[4, i + 2].Cells.Interior.Color = Color.FromArgb(255, 224, 192);
                    }
                    if (e.Rows.Count != 0)
                    {
                        for (int i = 0; i < e.Rows.Count; i++)
                        {
                            for (int j = 0; j < e.Columns.Count; j++)
                            {
                                Worksheet.Cells[i + 5, j + 2] = e.Rows[i].Cells[j].Value.ToString();
                                count1 = i + 5;
                                count2 = j + 2;
                                Worksheet.Cells[i + 5, count2].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                                if (count2 == 3)
                                {
                                    Worksheet.Cells[i + 5, count2] = e.Rows[i].Cells[j].Value.ToString().Replace(" VNĐ", "");
                                    Worksheet.Cells[i + 5, count2].Cells.HorizontalAlignment = XlHAlign.xlHAlignRight;
                                }

                                if (count2 == 2)
                                {
                                    Worksheet.Cells[i + 5, count2].Cells.HorizontalAlignment = XlHAlign.xlHAlignRight;
                                }
                            }
                        }
                        var WorkSheet_range = Worksheet.get_Range("B4", "C" + count1);
                        WorkSheet_range.Borders.Color = Color.Black;
                        WorkSheet_range.Borders.LineStyle = XlLineStyle.xlContinuous;
                        WorkSheet_range.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin);

                        Worksheet.Cells[count1 + 2, count2] = "Tổng doanh thu : " + Total_txt.Text;
                        Worksheet.Cells[count1 + 2, count2].Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                        Worksheet.Cells[count1 + 2, count2].Cells.Font.Color = Color.Red;
                        Execl.ActiveWorkbook.SaveCopyAs(Path);
                        Execl.ActiveWorkbook.Saved = true;
                        
                        MessageBox.Show("Xuất dữ liệu ra Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Execl.Visible = true;
                        Execl.WindowState = XlWindowState.xlMinimized;
                        Execl.WindowState = XlWindowState.xlMaximized;
                    }
                    else
                    {
                        MessageBox.Show("Không có doanh thu để xuất ra Excel", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if(Choose_cbb.Text == "Năm" && Staff_cbb.Text == "Tất cả")
                {
                    Worksheet.Cells[2, 2] = "DOANH THU NĂM " + Year;

                    Execl.Columns.Style.Font.Size = 16;
                    Worksheet.Cells[2, 2].EntireRow.Font.Size = 18;
                    Worksheet.Cells[2, 2].EntireRow.Font.Bold = true;
                    Worksheet.Range["B2:C2"].Merge();
                    Worksheet.Range["B2:C2"].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    Execl.Columns.ColumnWidth = 30;
                    for (int i = 0; i < e.Columns.Count; i++)
                    {
                        Worksheet.Cells[4, i + 2] = e.Columns[i].HeaderText;
                        Worksheet.Cells[4, i + 2].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        Worksheet.Cells[4, i + 2].Cells.Interior.Color = Color.FromArgb(255, 224, 192);
                    }
                    if (e.Rows.Count != 0)
                    {
                        for (int i = 0; i < e.Rows.Count; i++)
                        {
                            for (int j = 0; j < e.Columns.Count; j++)
                            {
                                Worksheet.Cells[i + 5, j + 2] = e.Rows[i].Cells[j].Value.ToString();
                                count1 = i + 5;
                                count2 = j + 2;
                                if (count2 == 2)
                                {
                                    Worksheet.Cells[i + 5, count2].NumberFormat = "mm/yyy";
                                }

                                Worksheet.Cells[i + 5, count2].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                                if (count2 == 3)
                                {
                                    Worksheet.Cells[i + 5, count2].Cells.HorizontalAlignment = XlHAlign.xlHAlignRight;
                                    Worksheet.Cells[i + 5, count2] = e.Rows[i].Cells[j].Value.ToString().Replace(" VNĐ", "");
                                }
                            }
                        }
                        var WorkSheet_range = Worksheet.get_Range("B4", "C" + count1);

                        WorkSheet_range.Borders.Color = Color.Black;
                        WorkSheet_range.Borders.LineStyle = XlLineStyle.xlContinuous;
                        WorkSheet_range.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin);

                        Worksheet.Cells[count1 + 2, count2] = "Tổng doanh thu : " + Total_txt.Text;
                        Worksheet.Cells[count1 + 2, count2].Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                        Worksheet.Cells[count1 + 2, count2].Cells.Font.Color = Color.Red;
                        Execl.ActiveWorkbook.SaveCopyAs(Path);
                        Execl.ActiveWorkbook.Saved = true;
                        MessageBox.Show("Xuất dữ liệu ra Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Execl.Visible = true;
                        Execl.WindowState = XlWindowState.xlMinimized;
                        Execl.WindowState = XlWindowState.xlMaximized;
                    }
                    else
                    {
                        MessageBox.Show("Không có doanh thu để xuất ra Excel", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Choose_cbb.Text == "Năm" && Staff_cbb.Text != "Tất cả")
                {
                    Worksheet.Cells[2, 3] = "DOANH THU NĂM " + Year + " CỦA NHÂN VIÊN " + Staff_cbb.Text.ToUpper();

                    Execl.Columns.Style.Font.Size = 16;
                    Worksheet.Cells[2, 3].EntireRow.Font.Size = 18;
                    Worksheet.Cells[2, 3].EntireRow.Font.Bold = true;
                    Worksheet.Cells[2, 3].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    Execl.Columns.ColumnWidth = 30;
                    for (int i = 0; i < e.Columns.Count; i++)
                    {
                        Worksheet.Cells[4, i + 2] = e.Columns[i].HeaderText;
                        Worksheet.Cells[4, i + 2].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        Worksheet.Cells[4, i + 2].Cells.Interior.Color = Color.FromArgb(255, 224, 192);
                    }
                    if (e.Rows.Count != 0)
                    {
                        for (int i = 0; i < e.Rows.Count; i++)
                        {
                            for (int j = 0; j < e.Columns.Count; j++)
                            {
                                Worksheet.Cells[i + 5, j + 2] = e.Rows[i].Cells[j].Value.ToString();
                                count1 = i + 5;
                                count2 = j + 2;
                                if (count2 == 2)
                                {
                                    Worksheet.Cells[i + 5, count2].NumberFormat = "mm/yyy";
                                }
                                Worksheet.Cells[i + 5, count2].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                                if (count2 == 4)
                                {
                                    Worksheet.Cells[i + 5, count2].Cells.HorizontalAlignment = XlHAlign.xlHAlignRight;
                                    Worksheet.Cells[i + 5, count2] = e.Rows[i].Cells[j].Value.ToString().Replace(" VNĐ", "");
                                }
                            }
                        }
                        var WorkSheet_range = Worksheet.get_Range("B4", "D" + count1);

                        WorkSheet_range.Borders.Color = Color.Black;
                        WorkSheet_range.Borders.LineStyle = XlLineStyle.xlContinuous;
                        WorkSheet_range.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin);

                        Worksheet.Cells[count1 + 2, count2] = "Tổng doanh thu : " + Total_txt.Text;
                        Worksheet.Cells[count1 + 2, count2].Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                        Worksheet.Cells[count1 + 2, count2].Cells.Font.Color = Color.Red;
                        Execl.ActiveWorkbook.SaveCopyAs(Path);
                        Execl.ActiveWorkbook.Saved = true;
                        MessageBox.Show("Xuất dữ liệu ra Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Execl.Visible = true;
                        Execl.WindowState = XlWindowState.xlMinimized;
                        Execl.WindowState = XlWindowState.xlMaximized;
                    }
                    else
                    {
                        MessageBox.Show("Không có doanh thu để xuất ra Excel", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Choose_cbb.Text == "Tháng" && Staff_cbb.Text != "Tất cả")
                {
                    Worksheet.Cells[2, 3] = "DOANH THU THÁNG " + Month + " CỦA NHÂN VIÊN " + Staff_cbb.Text.ToUpper();

                    Execl.Columns.Style.Font.Size = 16;
                    Worksheet.Cells[2, 3].EntireRow.Font.Size = 18;
                    Worksheet.Cells[2, 3].EntireRow.Font.Bold = true;
                    Worksheet.Cells[2, 3].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    Execl.Columns.ColumnWidth = 30;
                    for (int i = 0; i < e.Columns.Count; i++)
                    {
                        Worksheet.Cells[4, i + 2] = e.Columns[i].HeaderText;
                        Worksheet.Cells[4, i + 2].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        Worksheet.Cells[4, i + 2].Cells.Interior.Color = Color.FromArgb(255, 224, 192);
                    }
                    if (e.Rows.Count != 0)
                    {
                        for (int i = 0; i < e.Rows.Count; i++)
                        {
                            for (int j = 0; j < e.Columns.Count; j++)
                            {
                                Worksheet.Cells[i + 5, j + 2] = e.Rows[i].Cells[j].Value.ToString();
                                count1 = i + 5;
                                count2 = j + 2;
                                Worksheet.Cells[i + 5, count2].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                                if (count2 == 4)
                                {
                                    Worksheet.Cells[i + 5, count2].Cells.HorizontalAlignment = XlHAlign.xlHAlignRight;
                                    Worksheet.Cells[i + 5, count2] = e.Rows[i].Cells[j].Value.ToString().Replace(" VNĐ", "");
                                }
                                if (count2 == 2)
                                {
                                    Worksheet.Cells[i + 5, count2].Cells.HorizontalAlignment = XlHAlign.xlHAlignRight;
                                }
                            }
                        }
                        var WorkSheet_range = Worksheet.get_Range("B4", "D" + count1);

                        WorkSheet_range.Borders.Color = Color.Black;
                        WorkSheet_range.Borders.LineStyle = XlLineStyle.xlContinuous;
                        WorkSheet_range.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin);

                        Worksheet.Cells[count1 + 2, count2] = "Tổng doanh thu : " + Total_txt.Text;
                        Worksheet.Cells[count1 + 2, count2].Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                        Worksheet.Cells[count1 + 2, count2].Cells.Font.Color = Color.Red;
                        Execl.ActiveWorkbook.SaveCopyAs(Path);
                        Execl.ActiveWorkbook.Saved = true;
                        MessageBox.Show("Xuất dữ liệu ra Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Execl.Visible = true;
                        Execl.WindowState = XlWindowState.xlMinimized;
                        Execl.WindowState = XlWindowState.xlMaximized;
                    }
                    else
                    {
                        MessageBox.Show("Không có doanh thu để xuất ra Excel", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Worksheet.Cells[2, 3] = "DOANH THU" + Value1_date.Value.ToString(" dd/MM/yyyy 00:00:00") + " ĐẾN " + Value2_date.Value.ToString("dd/MM/yyyy 23:59:59");
                    Execl.Columns.Style.Font.Size = 16;
                    Worksheet.Cells[2, 3].EntireRow.Font.Size = 18;
                    Worksheet.Cells[2, 3].EntireRow.Font.Bold = true;
                    Worksheet.Range["C2:D2"].Merge();
                    Worksheet.Range["C2:D2"].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    Execl.Columns.ColumnWidth = 30;
                    for (int i = 0; i < e.Columns.Count - 1; i++)
                    {
                        Worksheet.Cells[4, i + 2] = e.Columns[i].HeaderText;
                        Worksheet.Cells[4, i + 2].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        Worksheet.Cells[4, i + 2].Cells.Interior.Color = Color.FromArgb(255, 224, 192);
                    }
                    if (e.Rows.Count != 0)
                    {
                        for (int i = 0; i < e.Rows.Count; i++)
                        {
                            for (int j = 0; j < e.Columns.Count - 1; j++)
                            {
                                Worksheet.Cells[i + 5, j + 2] = e.Rows[i].Cells[j].Value.ToString();
                                count1 = i + 5;
                                count2 = j + 2;
                                Worksheet.Cells[i + 5, count2].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                                if (count2 == 5)
                                {
                                    Worksheet.Cells[i + 5, count2].Cells.HorizontalAlignment = XlHAlign.xlHAlignRight;
                                    Worksheet.Cells[i + 5, count2] = e.Rows[i].Cells[j].Value.ToString().Replace(" VNĐ", "");
                                }
                            }
                        }
                        var WorkSheet_range = Worksheet.get_Range("B4", "E" + count1);

                        WorkSheet_range.Borders.Color = Color.Black;
                        WorkSheet_range.Borders.LineStyle = XlLineStyle.xlContinuous;
                        WorkSheet_range.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin);

                        Worksheet.Cells[count1 + 2, count2] = "Tổng doanh thu : " + Total_txt.Text;
                        Worksheet.Cells[count1 + 2, count2].Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                        Worksheet.Cells[count1 + 2, count2].Cells.Font.Color = Color.Red;
                        Execl.ActiveWorkbook.SaveCopyAs(Path);
                        Execl.ActiveWorkbook.Saved = true;
                        MessageBox.Show("Xuất dữ liệu ra Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Execl.Visible = true;
                        Execl.WindowState = XlWindowState.xlMinimized;
                        Execl.WindowState = XlWindowState.xlMaximized;
                    }
                    else
                    {
                        MessageBox.Show("Không có doanh thu để xuất ra Excel", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } 
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Excel_btn_Click(object sender, EventArgs e)
        {
            if (Statistic_dgv.Rows.Count < 1)
            {
                MessageBox.Show("Không có dữ liệu để xuất Excel", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SaveFileDialog FD = new SaveFileDialog();
                FD.Title = "Chọn nơi để lưu";
                FD.Filter = "Excel XLSX (*.xlsx)|*.xlsx";
                FD.FileName = "ThongKe";
                if (FD.ShowDialog() == DialogResult.OK)
                {
                    var filePath = FD.FileName;
                    ExportExcel(Statistic_dgv, filePath);
                }
            }
        }

        private void Value1_date_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void Value2_date_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void Shift_cbb_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void Choose_cbb_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void Staff_cbb_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void Shift_cbb_SelectedValueChanged(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void Choose_cbb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Choose_cbb.Text != "Ngày")
            {
                Shift_cbb.SelectedIndex = 0;
                Shift_cbb.Enabled = false;
                Value1_date.Enabled = false;
                Value2_date.Enabled = false;
                Value1_cbb.Visible = true;
               
                if (Choose_cbb.Text == "Tháng")
                {
                    Value1_cbb.Items.Clear();
                    Value2_cbb.Items.Clear();
                    Find_btn.Location = new Point(715, 200);
                    Value1_cbb.Width = 65;
                    Value2_cbb.Visible = true;
                    for (int i = 01; i <= 12; i++)
                    {
                        Value1_cbb.Text = DateTime.Now.Month.ToString();
                        Value1_cbb.Items.Add(i);
                    }
                    for (int i = 1950; i <= DateTime.Now.Year; i++)
                    {
                        Value2_cbb.Text = DateTime.Now.Year.ToString();
                        Value2_cbb.Items.Add(i);
                    }

                }
                else
                {
                    Value1_cbb.Items.Clear();
                    Find_btn.Location = new Point(640, 200);
                    Value1_cbb.Width = 151;
                    Value2_cbb.Visible = false;
                    for (int i = 1950; i <= DateTime.Now.Year; i++)
                    {
                        Value1_cbb.Text = DateTime.Now.Year.ToString();
                        Value1_cbb.Items.Add(i);
                    }
                }
            }
            else
            {
                Find_btn.Location = new Point(500, 200);
                Shift_cbb.Enabled = true;
                Value1_date.Enabled = true;
                Value2_date.Enabled = true;
                Value1_cbb.Visible = false;
                Value2_cbb.Visible = false; 
            }
            this.ActiveControl = label1;
        }

        private void Staff_cbb_SelectedValueChanged(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void Value1_date_Leave(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void Value_cbb_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void Value_cbb_SelectedValueChanged(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void Value2_cbb_SelectedValueChanged(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void Value2_cbb_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void Pdf_btn_Click(object sender, EventArgs e)
        {
            if (Statistic_dgv.Rows.Count < 1)
            {
                MessageBox.Show("Không có dữ liệu để xuất PDF", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataSet set = new DataSet();
                DataTable table = new DataTable();
                if (Choose_cbb.Text == "Ngày")
                {
                    table.Rows.Clear();
                    table.Columns.Clear();
                    table.Columns.Add("Giờ ra", typeof(string));
                    table.Columns.Add("Ca", typeof(string));
                    table.Columns.Add("Nhân viên", typeof(string));
                    table.Columns.Add("Tống", typeof(string));

                    foreach (DataGridViewRow item in Statistic_dgv.Rows)
                    {
                        table.Rows.Add(item.Cells[0].Value, item.Cells[1].Value, item.Cells[2].Value, item.Cells[3].Value.ToString().Replace(" VNĐ", ""));
                    }
                    set.Tables.Add(table);
                    set.WriteXmlSchema("Statictis.xml");
                    Report_frm report = new Report_frm();
                    Statistic statistic = new Statistic();
                    statistic.SetDataSource(set);
                    report.crystalReportViewer1.ReportSource = statistic;
                    TextObject txtheader = (TextObject)statistic.ReportDefinition.ReportObjects["Text6"];
                    txtheader.Text = "DOANH THU" + Value1_date.Value.ToString(" dd/MM/yyyy 00:00:00") + " ĐẾN " + Value2_date.Value.ToString("dd/MM/yyyy 23:59:59");
                    TextObject txtheader3 = (TextObject)statistic.ReportDefinition.ReportObjects["Text1"];
                    txtheader3.Text = "Thời gian";
                    TextObject txtheader2 = (TextObject)statistic.ReportDefinition.ReportObjects["Text7"];
                    txtheader2.Text = "Tổng doanh thu : " + Total_txt.Text;

                    LineObject Line = (LineObject)statistic.ReportDefinition.ReportObjects["Line11"];
                    Line.LineStyle = LineStyle.NoLine;

                    LineObject Line2 = (LineObject)statistic.ReportDefinition.ReportObjects["Line12"];
                    Line2.LineStyle = LineStyle.NoLine;

                    report.crystalReportViewer1.Refresh();
                    report.ShowDialog();
                }
                else if (Choose_cbb.Text == "Tháng" && Staff_cbb.Text == "Tất cả")
                {
                    table.Rows.Clear();
                    table.Columns.Clear();
                    table.Columns.Add("Ca", typeof(string));
                    table.Columns.Add("Nhân viên", typeof(string));
                    foreach (DataGridViewRow item in Statistic_dgv.Rows)
                    {
                        table.Rows.Add(item.Cells[0].Value, item.Cells[1].Value.ToString().Replace(" VNĐ", ""));
                    }
                    set.Tables.Add(table);
                    set.WriteXmlSchema("Statictis.xml");
                    Report_frm report = new Report_frm();
                    Statistic statistic = new Statistic();
                    statistic.SetDataSource(set);
                    report.crystalReportViewer1.ReportSource = statistic;
                    TextObject txtheader1 = (TextObject)statistic.ReportDefinition.ReportObjects["Text8"];
                    txtheader1.Text = "DOANH THU THÁNG " + Month;
                    TextObject txtheader2 = (TextObject)statistic.ReportDefinition.ReportObjects["Text2"];
                    txtheader2.Text = "Thời gian ";
                    txtheader2.ObjectFormat.HorizontalAlignment = Alignment.RightAlign;

                    TextObject txtheader3 = (TextObject)statistic.ReportDefinition.ReportObjects["Text3"];
                    txtheader3.Text = "Tổng";
                    txtheader3.ObjectFormat.HorizontalAlignment = Alignment.RightAlign;

                    TextObject txtheader4 = (TextObject)statistic.ReportDefinition.ReportObjects["Text9"];
                    txtheader4.Text = "Tổng doanh thu : " + Total_txt.Text;

                    FieldObject field1 = statistic.ReportDefinition.ReportObjects["Nhânviên1"] as FieldObject;
                    field1.ObjectFormat.HorizontalAlignment = Alignment.RightAlign;
                    field1.Color = Color.Red;

                    FieldObject field2 = statistic.ReportDefinition.ReportObjects["Ca1"] as FieldObject;
                    field2.ObjectFormat.HorizontalAlignment = Alignment.RightAlign;

                    BoxObject Box = (BoxObject)statistic.ReportDefinition.ReportObjects["Box1"];
                    Box.LineStyle = LineStyle.NoLine;
                    Box.FillColor = Color.White;

                    BoxObject Box2 = (BoxObject)statistic.ReportDefinition.ReportObjects["Box2"];
                    Box2.LineStyle = LineStyle.NoLine;
                    Box2.FillColor = Color.White;

                    LineObject Line = (LineObject)statistic.ReportDefinition.ReportObjects["Line10"];
                    Line.LineStyle = LineStyle.NoLine;

                    LineObject Line2 = (LineObject)statistic.ReportDefinition.ReportObjects["Line8"];
                    Line2.LineStyle = LineStyle.NoLine;

                    LineObject Line3 = (LineObject)statistic.ReportDefinition.ReportObjects["Line9"];
                    Line3.LineStyle = LineStyle.NoLine;

                    LineObject Line4 = (LineObject)statistic.ReportDefinition.ReportObjects["Line11"];
                    Line4.LineStyle = LineStyle.NoLine;

                    report.crystalReportViewer1.Refresh();
                    report.ShowDialog();
                }
                else if (Choose_cbb.Text == "Năm" && Staff_cbb.Text == "Tất cả")
                {
                    table.Rows.Clear();
                    table.Columns.Clear();
                    table.Columns.Add("Ca", typeof(string));
                    table.Columns.Add("Nhân viên", typeof(string));
                    foreach (DataGridViewRow item in Statistic_dgv.Rows)
                    {
                        table.Rows.Add(item.Cells[0].Value, item.Cells[1].Value.ToString().Replace(" VNĐ", ""));
                    }
                    set.Tables.Add(table);
                    set.WriteXmlSchema("Statictis.xml");
                    Report_frm report = new Report_frm();
                    Statistic statistic = new Statistic();
                    statistic.SetDataSource(set);
                    report.crystalReportViewer1.ReportSource = statistic;
                    TextObject txtheader1 = (TextObject)statistic.ReportDefinition.ReportObjects["Text8"];
                    txtheader1.Text = "DOANH THU NĂM " + Year;
                    TextObject txtheader2 = (TextObject)statistic.ReportDefinition.ReportObjects["Text2"];
                    txtheader2.Text = "Thời gian";

                    TextObject txtheader3 = (TextObject)statistic.ReportDefinition.ReportObjects["Text3"];
                    txtheader3.Text = "Tổng";
                    txtheader3.ObjectFormat.HorizontalAlignment = Alignment.RightAlign;

                    TextObject txtheader4 = (TextObject)statistic.ReportDefinition.ReportObjects["Text9"];
                    txtheader4.Text = "Tổng doanh thu : " + Total_txt.Text;

                    FieldObject field1 = statistic.ReportDefinition.ReportObjects["Nhânviên1"] as FieldObject;
                    field1.ObjectFormat.HorizontalAlignment = Alignment.RightAlign;
                    field1.Color = Color.Red;

                    BoxObject Box = (BoxObject)statistic.ReportDefinition.ReportObjects["Box1"];
                    Box.LineStyle = LineStyle.NoLine;
                    Box.FillColor = Color.White;

                    BoxObject Box2 = (BoxObject)statistic.ReportDefinition.ReportObjects["Box2"];
                    Box2.LineStyle = LineStyle.NoLine;
                    Box2.FillColor = Color.White;

                    LineObject Line = (LineObject)statistic.ReportDefinition.ReportObjects["Line10"];
                    Line.LineStyle = LineStyle.NoLine;

                    LineObject Line2 = (LineObject)statistic.ReportDefinition.ReportObjects["Line8"];
                    Line2.LineStyle = LineStyle.NoLine;

                    LineObject Line3 = (LineObject)statistic.ReportDefinition.ReportObjects["Line9"];
                    Line3.LineStyle = LineStyle.NoLine;

                    LineObject Line4 = (LineObject)statistic.ReportDefinition.ReportObjects["Line11"];
                    Line4.LineStyle = LineStyle.NoLine;

                    report.crystalReportViewer1.Refresh();
                    report.ShowDialog();
                }
                else if (Choose_cbb.Text == "Tháng" && Staff_cbb.Text != "Tất cả")
                {
                    table.Rows.Clear();
                    table.Columns.Clear();
                    table.Columns.Add("Ca", typeof(string));
                    table.Columns.Add("Nhân viên", typeof(string));
                    table.Columns.Add("Tống", typeof(string));
                    foreach (DataGridViewRow item in Statistic_dgv.Rows)
                    {
                        table.Rows.Add(item.Cells[0].Value, item.Cells[1].Value, item.Cells[2].Value.ToString().Replace(" VNĐ", ""));
                    }
                    set.Tables.Add(table);
                    set.WriteXmlSchema("Statictis.xml");
                    Report_frm report = new Report_frm();
                    Statistic statistic = new Statistic();
                    statistic.SetDataSource(set);
                    report.crystalReportViewer1.ReportSource = statistic;
                    TextObject txtheader1 = (TextObject)statistic.ReportDefinition.ReportObjects["Text6"];
                    txtheader1.Text = "DOANH THU THÁNG " + Month + " CỦA NHÂN VIÊN " + Staff_cbb.Text.ToUpper();

                    TextObject txtheader2 = (TextObject)statistic.ReportDefinition.ReportObjects["Text2"];
                    txtheader2.Text = "Thời gian";
                    txtheader2.ObjectFormat.HorizontalAlignment = Alignment.RightAlign;

                    TextObject txtheader4 = (TextObject)statistic.ReportDefinition.ReportObjects["Text7"];
                    txtheader4.Text = "Tổng doanh thu : " + Total_txt.Text;

                    FieldObject field = statistic.ReportDefinition.ReportObjects["Ca1"] as FieldObject;
                    field.ObjectFormat.HorizontalAlignment = Alignment.RightAlign;

                    BoxObject Box = (BoxObject)statistic.ReportDefinition.ReportObjects["Box1"];
                    Box.LineStyle = LineStyle.NoLine;
                    Box.FillColor = Color.White;

                    LineObject Line = (LineObject)statistic.ReportDefinition.ReportObjects["Line9"];
                    Line.LineStyle = LineStyle.NoLine;

                    LineObject Line2 = (LineObject)statistic.ReportDefinition.ReportObjects["Line12"];
                    Line2.LineStyle = LineStyle.NoLine;

                    LineObject Line3 = (LineObject)statistic.ReportDefinition.ReportObjects["Line8"];
                    Line3.LineStyle = LineStyle.NoLine;

                    report.crystalReportViewer1.Refresh();
                    report.ShowDialog();
                }
                else if (Choose_cbb.Text == "Năm" && Staff_cbb.Text != "Tất cả")
                {
                    table.Rows.Clear();
                    table.Columns.Clear();
                    table.Columns.Add("Ca", typeof(string));
                    table.Columns.Add("Nhân viên", typeof(string));
                    table.Columns.Add("Tống", typeof(string));
                    foreach (DataGridViewRow item in Statistic_dgv.Rows)
                    {
                        table.Rows.Add(item.Cells[0].Value, item.Cells[1].Value, item.Cells[2].Value.ToString().Replace(" VNĐ", ""));
                    }
                    set.Tables.Add(table);
                    set.WriteXmlSchema("Statictis.xml");
                    Report_frm report = new Report_frm();
                    Statistic statistic = new Statistic();
                    statistic.SetDataSource(set);
                    report.crystalReportViewer1.ReportSource = statistic;
                    TextObject txtheader1 = (TextObject)statistic.ReportDefinition.ReportObjects["Text6"];
                    txtheader1.Text = "DOANH THU NĂM " + Year + " CỦA NHÂN VIÊN " + Staff_cbb.Text.ToUpper();
                    TextObject txtheader2 = (TextObject)statistic.ReportDefinition.ReportObjects["Text2"];
                    txtheader2.Text = "Thời gian";
                    TextObject txtheader4 = (TextObject)statistic.ReportDefinition.ReportObjects["Text7"];
                    txtheader4.Text = "Tổng doanh thu : " + Total_txt.Text;

                    BoxObject Box = (BoxObject)statistic.ReportDefinition.ReportObjects["Box1"];
                    Box.LineStyle = LineStyle.NoLine;
                    Box.FillColor = Color.White;

                    LineObject Line = (LineObject)statistic.ReportDefinition.ReportObjects["Line9"];
                    Line.LineStyle = LineStyle.NoLine;

                    LineObject Line2 = (LineObject)statistic.ReportDefinition.ReportObjects["Line12"];
                    Line2.LineStyle = LineStyle.NoLine;

                    LineObject Line3 = (LineObject)statistic.ReportDefinition.ReportObjects["Line8"];
                    Line3.LineStyle = LineStyle.NoLine;

                    report.crystalReportViewer1.Refresh();
                    report.ShowDialog();
                }
            }
        }

        private void Table_rdo_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Statistic_dgv.Visible = true;
        }

        private void Chart_rdo_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Statistic_dgv.Visible = false;
            if (Staff_cbb.Text != "Tất cả")
            {
                ChartStaff();
            }
            else
            {
                Chart();
            }
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Pdf_btn.ForeColor == Color.Black)
            {
                Pdf_btn.ForeColor = Color.Red;
                Pdf_btn.BorderColor = Color.Red;
            }
            else if (Pdf_btn.ForeColor == Color.Red)
            {
                Pdf_btn.ForeColor = Color.Blue;
                Pdf_btn.BorderColor = Color.Blue;
            }
            else if (Pdf_btn.ForeColor == Color.Blue)
            {
                Pdf_btn.ForeColor = Color.Green;
                Pdf_btn.BorderColor = Color.Green;
            }
            else
            {
                Pdf_btn.ForeColor = Color.Black;
                Pdf_btn.BorderColor = Color.Black;
            }

            if (Excel_btn.ForeColor == Color.Black)
            {
                Excel_btn.ForeColor = Color.Red;
                Excel_btn.BorderColor = Color.Red;
            }
            else if (Excel_btn.ForeColor == Color.Red)
            {
                Excel_btn.ForeColor = Color.Blue;
                Excel_btn.BorderColor = Color.Blue;
            }
            else if (Excel_btn.ForeColor == Color.Blue)
            {
                Excel_btn.ForeColor = Color.Green;
                Excel_btn.BorderColor = Color.Green;
            }
            else
            {
                Excel_btn.ForeColor = Color.Black;
                Excel_btn.BorderColor = Color.Black;
            } 
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int x1 = First_lbl.Location.X;
            int x2 = Last_lbl.Location.X;
            x1--;
            First_lbl.Location = new Point(x1, First_lbl.Location.Y);

            x2--;
            Last_lbl.Location = new Point(x2, Last_lbl.Location.Y);

            if (x1 == 0)
            {
                Last_lbl.Visible = true;
                x2 = panel2.Size.Width;
                Last_lbl.Location = new Point(x2, Last_lbl.Location.Y);
            }

            if (x2 == 0)
            {
                x1 = panel2.Size.Width;
                First_lbl.Location = new Point(x1, First_lbl.Location.Y);
            }
        }

        private void TopDay()
        {
            if (Statistic_dgv.Rows.Count > 0)
            {
                //
                panel2.Visible = true;
                if (BUS_Log.Instance.TopDay(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59")).Rows.Count <= 1)
                {
                    Top1 = BUS_Log.Instance.TopDay(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59")).Rows[0][1].ToString();
                    First_lbl.Text = "Món bán chạy nhất trong ngày " + Value1_date.Value.ToString("dd/MM/yyyy") + " đến ngày " + Value2_date.Value.ToString("dd/MM/yyyy") + " :      Top 1: " + Top1;
                    Last_lbl.Text = "Món bán chạy nhất trong ngày " + Value1_date.Value.ToString("dd/MM/yyyy") + " đến ngày " + Value2_date.Value.ToString("dd/MM/yyyy") + " :      Top 1: " + Top1;
                }
                else if (BUS_Log.Instance.TopDay(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59")).Rows.Count <= 2)
                {
                    Top1 = BUS_Log.Instance.TopDay(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59")).Rows[0][1].ToString();
                    Top2 = BUS_Log.Instance.TopDay(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59")).Rows[1][1].ToString();
                    First_lbl.Text = "Món bán chạy nhất trong ngày " + Value1_date.Value.ToString("dd/MM/yyyy") + " đến ngày " + Value2_date.Value.ToString("dd/MM/yyyy") + " :      Top 1: " + Top1 + "      Top 2: " + Top2;
                    Last_lbl.Text = "Món bán chạy nhất trong ngày " + Value1_date.Value.ToString("dd/MM/yyyy") + " đến ngày " + Value2_date.Value.ToString("dd/MM/yyyy") + " :      Top 1: " + Top1 + "      Top 2: " + Top2;
                }
                else
                {
                    Top1 = BUS_Log.Instance.TopDay(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59")).Rows[0][1].ToString();
                    Top2 = BUS_Log.Instance.TopDay(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59")).Rows[1][1].ToString();
                    Top3 = BUS_Log.Instance.TopDay(Value1_date.Value.ToString("yyyy/MM/dd 00:00:00"), Value2_date.Value.ToString("yyyy/MM/dd 23:59:59")).Rows[2][1].ToString();
                    First_lbl.Text = "Món bán chạy nhất trong ngày " + Value1_date.Value.ToString("dd/MM/yyyy") + " đến ngày " + Value2_date.Value.ToString("dd/MM/yyyy") + " :      Top 1: " + Top1 + "      Top 2: " + Top2 + "        Top 3: " + Top3;
                    Last_lbl.Text = "Món bán chạy nhất trong ngày " + Value1_date.Value.ToString("dd/MM/yyyy") + " đến ngày " + Value2_date.Value.ToString("dd/MM/yyyy") + " :      Top 1: " + Top1 + "      Top 2: " + Top2 + "        Top 3: " + Top3;
                }
            }
            else
            {
                panel2.Visible = false;
            }
        }

        private void TopMonth(int month, int year)
        {
            if (Statistic_dgv.Rows.Count > 0)
            {
                //
                panel2.Visible = true;
                if (BUS_Log.Instance.TopMonth(month, year).Rows.Count <= 1)
                {
                    Top1 = BUS_Log.Instance.TopMonth(month, year).Rows[0][1].ToString();
                    First_lbl.Text = "Món bán chạy nhất trong tháng " + month + " :      Top 1: " + Top1;
                    Last_lbl.Text = "Món bán chạy nhất trong tháng " + month + " :      Top 1: " + Top1;
                }
                else if (BUS_Log.Instance.TopMonth(month, year).Rows.Count <= 2)
                {
                    Top1 = BUS_Log.Instance.TopMonth(month, year).Rows[0][1].ToString();
                    Top2 = BUS_Log.Instance.TopMonth(month, year).Rows[1][1].ToString();
                    First_lbl.Text = "Món bán chạy nhất trong tháng " + month + " :      Top 1: " + Top1 + "      Top 2: " + Top2;
                    Last_lbl.Text = "Món bán chạy nhất trong tháng " + month + " :      Top 1: " + Top1 + "      Top 2: " + Top2;
                }
                else
                {
                    Top1 = BUS_Log.Instance.TopMonth(month, year).Rows[0][1].ToString();
                    Top2 = BUS_Log.Instance.TopMonth(month, year).Rows[1][1].ToString();
                    Top3 = BUS_Log.Instance.TopMonth(month, year).Rows[2][1].ToString();
                    First_lbl.Text = "Món bán chạy nhất trong tháng " + month + " :      Top 1: " + Top1 + "      Top 2: " + Top2 + "        Top 3: " + Top3;
                    Last_lbl.Text = "Món bán chạy nhất trong tháng " + month + " :      Top 1: " + Top1 + "      Top 2: " + Top2 + "        Top 3: " + Top3;
                }
            }
            else
            {
                panel2.Visible = false;
            }
        }

        private void TopYear(int year)
        {
            if (Statistic_dgv.Rows.Count > 0)
            {
                //
                panel2.Visible = true;
                if (BUS_Log.Instance.TopYear(year).Rows.Count <= 1)
                {
                    Top1 = BUS_Log.Instance.TopYear(year).Rows[0][1].ToString();
                    First_lbl.Text = "Món bán chạy nhất trong năm " + year + " :      Top 1: " + Top1;
                    Last_lbl.Text = "Món bán chạy nhất trong năm " + year + " :      Top 1: " + Top1;
                }
                else if (BUS_Log.Instance.TopYear(year).Rows.Count <= 2)
                {
                    Top1 = BUS_Log.Instance.TopYear(year).Rows[0][1].ToString();
                    Top2 = BUS_Log.Instance.TopYear(year).Rows[1][1].ToString();
                    First_lbl.Text = "Món bán chạy nhất trong năm " + year + " :      Top 1: " + Top1 + "      Top 2: " + Top2;
                    Last_lbl.Text = "Món bán chạy nhất trong năm " + year + " :      Top 1: " + Top1 + "      Top 2: " + Top2;
                }
                else
                {
                    Top1 = BUS_Log.Instance.TopYear(year).Rows[0][1].ToString();
                    Top2 = BUS_Log.Instance.TopYear(year).Rows[1][1].ToString();
                    Top3 = BUS_Log.Instance.TopYear(year).Rows[2][1].ToString();
                    First_lbl.Text = "Món bán chạy nhất trong năm " + year + " :      Top 1: " + Top1 + "      Top 2: " + Top2 + "        Top 3: " + Top3;
                    Last_lbl.Text = "Món bán chạy nhất trong năm " + year + " :      Top 1: " + Top1 + "      Top 2: " + Top2 + "        Top 3: " + Top3;
                }
            }
            else
            {
                panel2.Visible = false;
            }
        }
    }
}
