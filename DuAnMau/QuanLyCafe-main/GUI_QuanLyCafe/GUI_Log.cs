using BUS_QuanLyCafe;
using DTO_QuanLyCafe;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI_QuanLyCafe
{
    public partial class Log_frm : Form
    {
        public Log_frm()
        {
            InitializeComponent();
        }

        DTO_Log log = new DTO_Log();

        private void Log_frm_Load(object sender, EventArgs e)
        {
            log.Object1 = Order_frm.Object;
            log.Object2 = Order_frm.Object2;
            this.ActiveControl = label1;
            if (Order_frm.Object2 == "hóa đơn")
            {
                foreach (DataRow row in BUS_Log.Instance.Logs(log).Rows)
                {
                    Log_rtxt.SelectionColor = Color.Black;
                    Log_rtxt.AppendText("[" + DateTime.Parse(row[5].ToString()).ToString("dd/MM/yyyy HH:mm:ss") + "] ");

                    Log_rtxt.SelectionColor = Color.Red;
                    Log_rtxt.AppendText(row[1].ToString() + " ");

                    Log_rtxt.SelectionColor = Color.Black;
                    Log_rtxt.AppendText("đã ");

                    Log_rtxt.SelectionColor = Color.Green;
                    Log_rtxt.AppendText(row[2].ToString() + " ");

                    Log_rtxt.SelectionColor = Color.Black;
                    Log_rtxt.AppendText(row[3].ToString() + " ");

                    Log_rtxt.SelectionColor = Color.Red;
                    Log_rtxt.AppendText(row[4].ToString());

                    Log_rtxt.AppendText(Environment.NewLine);
                }
            }
            else
            {
                foreach (DataRow row in BUS_Log.Instance.Log(log).Rows)
                {
                    Log_rtxt.SelectionColor = Color.Black;
                    Log_rtxt.AppendText("[" + DateTime.Parse(row[5].ToString()).ToString("dd/MM/yyyy HH:mm:ss") + "] ");

                    Log_rtxt.SelectionColor = Color.Red;
                    Log_rtxt.AppendText(row[1].ToString() + " ");

                    Log_rtxt.SelectionColor = Color.Black;
                    Log_rtxt.AppendText("đã ");

                    Log_rtxt.SelectionColor = Color.Green;
                    Log_rtxt.AppendText(row[2].ToString() + " ");

                    Log_rtxt.SelectionColor = Color.Black;
                    Log_rtxt.AppendText(row[3].ToString() + " ");

                    Log_rtxt.SelectionColor = Color.Red;
                    Log_rtxt.AppendText(row[4].ToString());

                    Log_rtxt.AppendText(Environment.NewLine);
                }
            }

            string dot = ". . . . . ";
            for (int i = 0; i < 4; i++)
            {
                dot += dot;
            }
            Log_rtxt.AppendText(dot);
        }
    }
}
