using BUS_QuanLyCafe;
using DTO_QuanLyCafe;
using System;
using System.Windows.Forms;

namespace GUI_QuanLyCafe
{
    public partial class Confirm_frm : Form
    {
        public Confirm_frm()
        {
            InitializeComponent();
        }
        DTO_Staff staff = new DTO_Staff();
        public static int Result = 0;
        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Email_txt.Text == "")
                {
                    MessageBox.Show("Xác nhận không thành công, email không được để trống ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.ActiveControl = Email_txt;
                }
                else if (Password_txt.Text == "")
                {
                    MessageBox.Show("Xác nhận không thành công, mật khẩu không được để trống ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.ActiveControl = Password_txt;
                }
                else
                {
                    staff.Email = Email_txt.Text;
                    staff.Password = BUS_Staff.Instance.Encryption(Password_txt.Text);
                    if (BUS_Staff.Instance.AcceptLogin(staff) == true && BUS_Staff.Instance.Check(staff).Rows[0][10].ToString() == "Hoạt động" && BUS_Staff.Instance.Check(staff).Rows[0][7].ToString() == "Quản lý")
                    {
                        Result = 1;
                        this.Close();
                    }
                    else if (BUS_Staff.Instance.AcceptLogin(staff) == true && BUS_Staff.Instance.Check(staff).Rows[0][10].ToString() == "Hoạt động" && BUS_Staff.Instance.Check(staff).Rows[0][7].ToString() != "Quản lý")
                    {
                        MessageBox.Show("Xác nhận không thành công, bạn không phải là quản lý", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (BUS_Staff.Instance.AcceptLogin(staff) == true && BUS_Staff.Instance.Check(staff).Rows[0][10].ToString() == "Không hoạt động")
                    {
                        MessageBox.Show("Xác nhận không thành công, tài khoản của bạn đã bị vô hiệu ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Xác nhận không thành công, kiểm tra lại email hoặc mật  khẩu ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không kết nối được với Server, xin vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
