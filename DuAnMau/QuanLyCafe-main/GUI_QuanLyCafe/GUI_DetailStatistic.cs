using BUS_QuanLyCafe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLyCafe
{
    public partial class DetailStatistic_frm : Form
    {
        public DetailStatistic_frm()
        {
            InitializeComponent();
        }

        private void DetailStatistic_frm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = Method_lbl;
            try
            {
                CheckIn_lbl.Text = "Giờ vào : " + DateTime.Parse(BUS_Log.Instance.Statistic(Statistic_frm.IdStatistic).Rows[0][7].ToString()).ToString("ddd dd/MM/yyyy HH:mm:ss");
                Bill_lv.Items.Clear();
                float total = 0;
                for (int i = 0; i < BUS_Log.Instance.DetailStatistic(Statistic_frm.IdStatistic).Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem(BUS_Log.Instance.DetailStatistic(Statistic_frm.IdStatistic).Rows[i][2].ToString() + " - " + BUS_Log.Instance.DetailStatistic(Statistic_frm.IdStatistic).Rows[i][6].ToString());
                    item.SubItems.Add(BUS_Log.Instance.DetailStatistic(Statistic_frm.IdStatistic).Rows[i][3].ToString());
                    item.SubItems.Add(String.Format("{0:0,0}", (float)Convert.ToDouble(BUS_Log.Instance.DetailStatistic(Statistic_frm.IdStatistic).Rows[i][4].ToString())));
                    item.SubItems.Add(String.Format("{0:0,0}", (float)Convert.ToDouble(BUS_Log.Instance.DetailStatistic(Statistic_frm.IdStatistic).Rows[i][5].ToString())));
                    Bill_lv.Items.Add(item);
                    total = total + (float)Convert.ToDouble(BUS_Log.Instance.DetailStatistic(Statistic_frm.IdStatistic).Rows[i][5].ToString());
                }

                TotalOrder_lbl.Text = "Tổng hóa đơn: " + String.Format("{0:0,0}", total) + " VNĐ";

                float TotalSale = total - (total * (float)Convert.ToDouble(BUS_Log.Instance.Statistic(Statistic_frm.IdStatistic).Rows[0][2].ToString()) / 100);
                Voucher_lbl.Text = "Voucher (" + BUS_Log.Instance.Statistic(Statistic_frm.IdStatistic).Rows[0][2].ToString() + "%): " + String.Format("{0:0,0}", TotalSale) + " VNĐ";

                float TotalVAT = TotalSale + (TotalSale * 10 / 100);
                VAT_lbl.Text = "Thuế VAT (10%) : " + String.Format("{0:0,0}", TotalVAT) + " VNĐ";

                Total_lbl.Text = "Số tiền phải trả : " + String.Format("{0:0,0}", TotalVAT) + " VNĐ";

                Method_lbl.Text = "Phương thức thanh toán : " + BUS_Log.Instance.Statistic(Statistic_frm.IdStatistic).Rows[0][9].ToString();

                NameTable_lbl.Text = "Tên : " + BUS_Log.Instance.Statistic(Statistic_frm.IdStatistic).Rows[0][10].ToString();

                NameStafff_lbl.Text = "Thu ngân : " + BUS_Log.Instance.Statistic(Statistic_frm.IdStatistic).Rows[0][6].ToString();

                DateEnd_lbl.Text = "Giờ ra : " + DateTime.Parse(BUS_Log.Instance.Statistic(Statistic_frm.IdStatistic).Rows[0][8].ToString()).ToString("ddd dd/MM/yyyy HH:mm:ss");
            }
            catch (Exception) { }
        }

        private void Bill_lv_DoubleClick(object sender, EventArgs e)
        {
            Order_frm.NameFood = Bill_lv.SelectedItems[0].SubItems[0].Text;
            Order_frm.NameFood = Order_frm.NameFood.Substring(0, Order_frm.NameFood.IndexOf(" -"));
            Order_frm.Amount = Bill_lv.SelectedItems[0].SubItems[1].Text;
            Order_frm.Note = Bill_lv.SelectedItems[0].SubItems[0].Text;
            Order_frm.Note = Order_frm.Note.Substring(Order_frm.Note.LastIndexOf("- ")).Replace("-", " ");
            Note_frm note = new Note_frm();
            note.ShowDialog();
        }
    }
}
