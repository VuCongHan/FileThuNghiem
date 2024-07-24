using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_DangNhap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        public static int session = 0;//kiểm tra tình trạng login
        public static int profile = 0;
        public static string email;//truyền email từ frmmain thông qua các form khác thông qua biến static
        Thread th;
        frm_DangNhap dn =new frm_DangNhap();
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dn = new frm_DangNhap();
            if (!CheckExistForm("frm_DangNhap"))
            {
                dn.MdiParent = this;
                dn.Show();
                dn.FormClosed += new FormClosedEventHandler(frm_DangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("frm_DangNhap");
            }

            // Kiểm tra nếu đăng nhập thành công
            if (Form1.session == 1)
            {
                // Cập nhật giao diện người dùng
                Resetvalue();
            }
        }
        //CheckExistForm để kiểm tra xem 1 form với tên nào đó đã hiển thị trong Form cha(frmMain) chưa? => trả về true đã hiển thị hoặc false
        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach(Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        //ActiveChildForm dùng để "kích hoạt" - hiển thị lên trên cùng các trong số các form con nếu nó đã hiện mà không phải tạo thể hiện
        private void ActiveChildForm(string name)
        {
            foreach(Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var p = Path.Combine(Directory.GetCurrentDirectory(), "SOF205_Slide 1");
                System.Diagnostics.Process.Start(p);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Không tìm thấy file");
            }
        }
        private void frm_DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            Form1_Load(sender, e);
        }
        private void frm_ThongTinNV_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            Form1_Load(sender, e);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Resetvalue();
            if (profile == 1)
            {
                lbl_thongtinNV.Text = null;
                profile = 0;
            }
        }
        private void Resetvalue()
        {
            if(session == 1)
            {
                lbl_thongtinNV.Text = "Chào" + Form1.email;
                nhânViênToolStripMenuItem.Visible = true;
                danhmuctoolstripmenu.Visible = true;
                đăngXuấtToolStripMenuItem.Enabled = true;
                thốngKeToolStripMenuItem.Visible = true;
                thốngKêSảnPhẩmToolStripMenuItem.Visible = true;
                hồSơNhânViênToolStripMenuItem.Visible = true;
                đăngNhậpToolStripMenuItem.Enabled = false;
                if (int.Parse(dn.vaitro) == 0)
                {
                    VaiTroNV(); //chức năng cho nv bình thường
                }
            }
            else
            {
                nhânViênToolStripMenuItem.Visible = false;
                danhmuctoolstripmenu.Visible = false;
                đăngXuấtToolStripMenuItem.Enabled = false;
                thốngKeToolStripMenuItem.Visible = false;
                thốngKêSảnPhẩmToolStripMenuItem.Visible = false;
                hồSơNhânViênToolStripMenuItem.Visible = false;
                đăngNhậpToolStripMenuItem.Enabled = true;
            }
        }
        private void VaiTroNV()
        {
            nhânViênToolStripMenuItem.Visible = false;
            thốngKeToolStripMenuItem.Visible = false;
        }

        private void hồSơNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ThongTinNV profilenv = new frm_ThongTinNV(Form1.email);
            if (!CheckExistForm("frm_ThongTinNV"))
            {
                profilenv.MdiParent = this;
                profilenv.FormClosed += new FormClosedEventHandler(frm_ThongTinNV_FormClosed);
            }
            else
            {
                ActiveChildForm("frm_ThongTinNV");
            }
        }
    }
}
