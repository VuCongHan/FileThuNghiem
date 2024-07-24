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
    public partial class Note_frm : Form
    {
        public Note_frm()
        {
            InitializeComponent();
        }

        private void Note_frm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            Name_txt.Text = Order_frm.NameFood;
            Amount_txt.Text = Order_frm.Amount;
            Note_txt.Text = Order_frm.Note.Trim();
        }
    }
}
