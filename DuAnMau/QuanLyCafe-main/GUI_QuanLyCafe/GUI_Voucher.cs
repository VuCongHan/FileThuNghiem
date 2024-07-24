using BUS_QuanLyCafe;
using DTO_QuanLyCafe;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI_QuanLyCafe
{
    public partial class Voucher_frm : Form
    {
        public Voucher_frm()
        {
            InitializeComponent();
        }

        DTO_Voucher voucher = new DTO_Voucher();
        DTO_Log log = new DTO_Log();

        private void Voucher_frm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = IdVoucher_lbl;
            FomatDategridView();
            ListVoucher();
        }

        private void ListVoucher()
        {
            IdVoucher_txt.Text = BUS_Voucher.Instance.ListVoucher().Rows[0][0].ToString();
            NameVoucher_txt.Text = BUS_Voucher.Instance.ListVoucher().Rows[0][1].ToString();
            Percent_txt.Text = BUS_Voucher.Instance.ListVoucher().Rows[0][2].ToString();
        }

        private void Edit_ckb_CheckedChanged(object sender, EventArgs e)
        {
            if (Edit_ckb.Checked == true)
            {
                //text
                NameVoucher_txt.ReadOnly = false;
                Percent_txt.ReadOnly = false;

                //btn
                Delete_btn.Enabled = true;
                Edit_btn.Enabled = true;
                CreateID_btn.Enabled = true;

            }
            else
            {
                //text
                IdVoucher_txt.ReadOnly = true;
                NameVoucher_txt.ReadOnly = true;
                Percent_txt.ReadOnly = true;
                Find_txt.ReadOnly = false;

                //btn
                Add_btn.Enabled = false;
                Delete_btn.Enabled = false;
                Edit_btn.Enabled = false;
                CreateID_btn.Enabled = false;
                ResetFind_btn.Enabled = true;

                //datagridview
                ListVoucher_dgv.Enabled = true;

                //
                IdVoucher_lbl.ForeColor = Color.Black;
                NameVoucher_lbl.ForeColor = Color.Black;
                Percent_lbl.ForeColor = Color.Black;
            }
        }

        private void SaveLog()
        {
            log.IdStaff = Login_frm.IdStaff;
            log.Object1 = Order_frm.Object;
            log.IdObject = IdVoucher_txt.Text.Trim();
            log.DateStart = DateTime.Now;
            BUS_Log.Instance.InsertLog(log);
        }

        private void ResetText()
        {
            IdVoucher_txt.Text = "";
            NameVoucher_txt.Text = "";
            Percent_txt.Text = "";
        }

        private void FomatDategridView()
        {
            ListVoucher_dgv.DataSource = BUS_Voucher.Instance.ListVoucher_DGV();
            ListVoucher_dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListVoucher_dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 14, FontStyle.Regular);
            ListVoucher_dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ListVoucher_dgv.Columns[0].Width = 150;
            ListVoucher_dgv.Columns[2].Visible = false;
        }

        private void Voucher_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CreateID_btn.Enabled == false && Edit_ckb.Checked == true)
            {
                e.Cancel = true;
            }
            else
            {
                Edit_ckb.Checked = false;
                ResetFind_btn_Click(sender, e);
            }
        }

        private void GetText()
        {
            try
            {
                voucher.IdVoucher = IdVoucher_txt.Text.Trim();
                voucher.NameVoucher = NameVoucher_txt.Text.Trim();
                voucher.Percent = (float)double.Parse(Percent_txt.Text);
            }
            catch (Exception) { }
        }

        private void CreateID_btn_Click(object sender, EventArgs e)
        {
            var dlr = MessageBox.Show("Nhấn YES để tạo vùng lưu tự động ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlr == DialogResult.Yes)
            {
                Find_txt.Text = "";
                ResetText();
                IdVoucher_txt.ReadOnly = false;
                CreateID_btn.Enabled = false;
                Edit_ckb.Enabled = false;
                Edit_btn.Enabled = false;
                Find_txt.ReadOnly = true;
                ResetFind_btn.Enabled = false;
                ListVoucher_dgv.Enabled = false;
                //save log
                log.Action = "tạo vùng lưu";
                SaveLog();
                //
                VerificationText();
                this.ActiveControl = IdVoucher_txt;
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                GetText();
                if (BUS_Voucher.Instance.ExistVoucher(voucher) == true)
                {
                    MessageBox.Show("Khuyến mãi này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    InsertVoucher();
                    //save log
                    log.Action = "thêm";
                    SaveLog();
                    //

                    Edit_ckb.Enabled = true;
                    CreateID_btn.Enabled = true;
                    Add_btn.Enabled = false;
                    Edit_btn.Enabled = true;
                    IdVoucher_txt.ReadOnly = true;
                    Find_txt.ReadOnly = false;
                    ResetFind_btn.Enabled = true;
                    ListVoucher_dgv.Enabled = true;

                    MessageBox.Show("Thêm khuyến mãi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Thêm khuyến mãi thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertVoucher()
        {
            GetText();
            BUS_Voucher.Instance.InsertVoucher(voucher);
            FomatDategridView();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var dlr = MessageBox.Show("Bạn chắc muốn xóa khuyến mãi này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dlr == DialogResult.Yes)
                {
                    if (IdVoucher_txt.Text == "#NULL" && CreateID_btn.Enabled == true)
                    {
                        MessageBox.Show("Bạn không được xóa khuyến mãi này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        GetText();
                        BUS_Voucher.Instance.DeleteVoucher(voucher);
                        this.ActiveControl = label12;
                        if (CreateID_btn.Enabled == false)
                        {
                            ResetText();

                            //save log
                            log.Action = "xóa vùng lưu";
                            SaveLog();
                            //
                        }
                        else
                        {
                            //save log
                            log.Action = "xóa";
                            SaveLog();
                            //
                        }

                        ResetText();
                        Edit_ckb.Enabled = true;
                        Edit_ckb.Checked = false;
                        FomatDategridView();
                        MessageBox.Show("Xóa khuyến mãi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa khuyến mãi thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (IdVoucher_txt.Text == "#NULL" && CreateID_btn.Enabled == true)
                {
                    MessageBox.Show("Bạn không được sửa khuyến mãi này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    UpdateKM();
                    Edit_ckb.Checked = false;

                    //save log
                    log.Action = "sửa";
                    SaveLog();
                    //

                    MessageBox.Show("Sửa khuyển mãi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa khuyển mãi thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateKM()
        {
            GetText();
            BUS_Voucher.Instance.UpdateVoucher(voucher);
            FomatDategridView();
        }

        private void VerificationText()
        {
            if (Edit_ckb.Checked == true)
            {
                IsNumber(Percent_txt.Text, Percent_txt, Percent_lbl);

                if (IdVoucher_txt.Text == "")
                {
                    IdVoucher_lbl.ForeColor = Color.Red;
                }
                else
                {
                    IdVoucher_lbl.ForeColor = Color.Black;
                }

                if (NameVoucher_txt.Text == "")
                {
                    NameVoucher_lbl.ForeColor = Color.Red;
                }
                else
                {
                    NameVoucher_lbl.ForeColor = Color.Black;
                }

                if (IdVoucher_lbl.ForeColor == Color.Black && NameVoucher_lbl.ForeColor == Color.Black && Percent_lbl.ForeColor == Color.Black)
                {
                    if (CreateID_btn.Enabled == false)
                    {
                        Add_btn.Enabled = true;
                    }
                    else
                    {
                        Edit_btn.Enabled = true;
                    }

                }
                else
                {
                    Edit_btn.Enabled = false;
                    Add_btn.Enabled = false;
                }
            }
        }


        private void IsNumber(string txt, TextBox control, Control ctl)
        {
            if (Edit_ckb.Checked == true)
            {
                if (txt == "")
                {
                    ctl.ForeColor = Color.Red;
                }
                else
                {
                    foreach (char c in txt)
                    {
                        if (c == '.')
                        {
                            ctl.ForeColor = Color.Black;
                        }
                        else if (c < '0' || c > '9')
                        {
                            control.Text = txt.Substring(0, txt.Length - 1);
                            control.SelectionStart = txt.Length;
                        }
                        else
                        {
                            ctl.ForeColor = Color.Black;
                        }
                    }
                }
            }
        }

        private void DanhSachKM_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = ListVoucher_dgv.Rows[e.RowIndex];
                IdVoucher_txt.Text = row.Cells[0].Value.ToString();
                NameVoucher_txt.Text = row.Cells[1].Value.ToString();
                Percent_txt.Text = row.Cells[2].Value.ToString();
            }
            catch (Exception) { }
        }

        private void ResetFind_btn_Click(object sender, EventArgs e)
        {
            Find_txt.Text = "";
            ListVoucher();
            FomatDategridView();
        }

        private void Find_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ResetText();
                IdVoucher_lbl.ForeColor = Color.Black;
                NameVoucher_lbl.ForeColor = Color.Black;
                Percent_lbl.ForeColor = Color.Black;
                this.ActiveControl = Find_txt;
                ListVoucher_dgv.DataSource = BUS_Voucher.Instance.FindVoucher(Find_txt.Text);
            }
            catch (Exception) { }
        }

        private void IdVoucher_txt_TextChanged(object sender, EventArgs e)
        {
            VerificationText();
        }

        private void NameVoucher_txt_TextChanged(object sender, EventArgs e)
        {
            VerificationText();
        }

        private void Percent_txt_TextChanged(object sender, EventArgs e)
        {
            VerificationText();
        }

        private void Log_MenuItem_Click(object sender, EventArgs e)
        {
            Log_frm log = new Log_frm();
            log.ShowDialog();
        }
    }
}
