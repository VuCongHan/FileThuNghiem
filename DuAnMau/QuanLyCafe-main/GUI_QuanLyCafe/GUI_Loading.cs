using BUS_QuanLyCafe;
using KAutoHelper;
using System;
using System.Threading;
using System.Windows.Forms;

namespace GUI_QuanLyCafe
{
    public partial class Loading_frm : Form
    {
        public Loading_frm()
        {
            InitializeComponent();
        }
        public static int Status = 0;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Status == 1)
            {
                this.Hide();
                timer1.Stop();
                IntPtr hWnd = IntPtr.Zero;
                hWnd = AutoControl.FindWindowHandle(null, "Đăng nhập");
                AutoControl.BringToFront(hWnd);
            }
        }

        private void Loading_frm_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                BUS_Table.Instance.ListTable();
                Thread.Sleep(1000);
                Login_frm Login = new Login_frm();
                Login.ShowDialog();
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();           
        }

        private void Loading_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
