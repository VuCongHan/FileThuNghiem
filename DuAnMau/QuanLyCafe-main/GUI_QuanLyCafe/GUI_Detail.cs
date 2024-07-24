using System;
using System.Windows.Forms;

namespace GUI_QuanLyCafe
{
    public partial class Detail_frm : Form
    {
        public Detail_frm()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }

        public static int Status;
        public static int Amount;
        public static string Note;
        private void Addd_btn_Click(object sender, EventArgs e)
        {
            if (Amount_nud.Value > ListTable_frm.Amount && ListTable_frm.Status == 1)
            {
                MessageBox.Show("Tối đa (" + ListTable_frm.Amount + ")", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Status = 1;
                Amount = Convert.ToInt32(Amount_nud.Value.ToString());
                Note = Note_txt.Text;
                this.Close();
            }
           
        }

        private void Detail_frm_Load(object sender, EventArgs e)
        {
            if (ListTable_frm.Status == 1)
            {
                Add_btn.Text = "Tách";
            }
            Name_txt.Text = Menu_frm.NameFood;
        }
    }
}
