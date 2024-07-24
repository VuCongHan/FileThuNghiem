using BUS_QuanLyCafe;
using DTO_QuanLyCafe;
using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI_QuanLyCafe
{
    public partial class Menu_frm : Form
    {
        public Menu_frm()
        {
            InitializeComponent();
        }

        DTO_Menu menu = new DTO_Menu();
        DTO_Bill bill = new DTO_Bill();
        DTO_Staff staff = new DTO_Staff();
        DTO_Log log = new DTO_Log();

        public static int Count;
        public static string NameFood;
        public string CategoryID = "";
        public int Amount;
        public int IdDetailBill;
        public string Note;
        public int status;

        private void Menu_frm_Load(object sender, EventArgs e)
        {
            Name_lbl.Text = "Tên : " + Order_frm.NameTable;
            bill.IdTable = Order_frm.IdTable;
            LoadMenu("CF");
            ListOrder();

        }

        void ListOrder()
        {
            ListOrder_dgv.Rows.Clear();
            ListOrder_dgv.Columns.Clear();
            ListOrder_dgv.Columns.Add("Name", "Tên món");
            ListOrder_dgv.Columns.Add("Amount", "Số lượng");
            ListOrder_dgv.Columns.Add("Price", "Giá");
            ListOrder_dgv.Columns.Add("Note", "Ghi chú");
            ListOrder_dgv.Columns.Add("IdMenu", "Id Menu");
            ListOrder_dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListOrder_dgv.Columns[0].Width = 180;
            ListOrder_dgv.Columns[1].Width = 108;
            ListOrder_dgv.Columns[3].Width = 200;
            ListOrder_dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListOrder_dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListOrder_dgv.Columns[4].Visible = false;
        }

        private void SaveLog()
        {
            log.IdStaff = Login_frm.IdStaff;
            log.Object1 = "món";
            log.IdObject = Order_frm.NameTable.Trim();
            log.DateStart = DateTime.Now;
            BUS_Log.Instance.InsertLog(log);
        }

        private void LoadMenu(string CategoryID)
        {
            try
            {
                Cafe_flp.Controls.Clear();
                Freeze_flp.Controls.Clear();
                Tea_flp.Controls.Clear();
                Food_flp.Controls.Clear();
                Cake_flp.Controls.Clear();
                SoftDrink_flp.Controls.Clear();
                Other_flp.Controls.Clear();
                menu.CategoryID = CategoryID;
                for (int i = 0; i < BUS_Menu.Instance.ListMenu(menu).Rows.Count; i++)
                {
                    Guna2Button btn = new Guna2Button();
                    btn.Width = 270;
                    btn.Height = 80;
                    btn.Image = Image.FromFile(Application.StartupPath + BUS_Menu.Instance.ListMenu(menu).Rows[i][4].ToString());
                    btn.ImageSize = new Size(80, 80);
                    btn.ImageAlign = HorizontalAlignment.Left;
                    btn.TextAlign = HorizontalAlignment.Right;
                    float Price = (float)Convert.ToDouble(BUS_Menu.Instance.ListMenu(menu).Rows[i][2].ToString());
                    btn.Text = BUS_Menu.Instance.ListMenu(menu).Rows[i][1].ToString() + Environment.NewLine + String.Format("{0:0,0}", Price) + " VNĐ";
                    btn.Font = new Font("Time New Roman", 14);
                    btn.BorderColor = Color.Black;
                    btn.FillColor = Color.White;
                    btn.ForeColor = Color.Black;
                    btn.BorderThickness = 1;
                    btn.Tag = BUS_Menu.Instance.ListMenu(menu).Rows[i][0].ToString();
                    btn.Click += btn_Click;
                    if (CategoryID == "CF")
                    {
                        Cafe_flp.Controls.Add(btn);
                    }
                    else if (CategoryID == "FZ")
                    {
                        Freeze_flp.Controls.Add(btn);
                    }
                    else if (CategoryID == "TE")
                    {
                        Tea_flp.Controls.Add(btn);
                    }
                    else if (CategoryID == "CK")
                    {
                        Cake_flp.Controls.Add(btn);
                    }
                    else if (CategoryID == "FD")
                    {
                        Food_flp.Controls.Add(btn);
                    }
                    else if (CategoryID == "SD")
                    {
                        SoftDrink_flp.Controls.Add(btn);
                    }
                    else
                    {
                        Other_flp.Controls.Add(btn);
                    }
                }

                if (Confirm_frm.Result == 1)
                {
                    Guna2Button MenuManager_btn = new Guna2Button();
                    MenuManager_btn.Width = 270;
                    MenuManager_btn.Height = 80;
                    MenuManager_btn.Image = Image.FromFile(Application.StartupPath + @"\Image\Icon\plus.PNG");
                    MenuManager_btn.ImageSize = new Size(60, 60);
                    MenuManager_btn.ImageAlign = HorizontalAlignment.Center;
                    MenuManager_btn.BorderColor = Color.Black;
                    MenuManager_btn.FillColor = Color.White;
                    MenuManager_btn.ForeColor = Color.Black;
                    MenuManager_btn.BorderThickness = 1;
                    MenuManager_btn.Click += MenuManager_btn_Click;
                    if (CategoryID == "CF")
                    {
                        Cafe_flp.Controls.Add(MenuManager_btn);
                    }
                    else if (CategoryID == "FZ")
                    {
                        Freeze_flp.Controls.Add(MenuManager_btn);
                    }
                    else if (CategoryID == "TE")
                    {
                        Tea_flp.Controls.Add(MenuManager_btn);
                    }
                    else if (CategoryID == "FD")
                    {
                        Food_flp.Controls.Add(MenuManager_btn);
                    }
                    else if (CategoryID == "CK")
                    {
                        Cake_flp.Controls.Add(MenuManager_btn);
                    }
                    else if (CategoryID == "SD")
                    {
                        SoftDrink_flp.Controls.Add(MenuManager_btn);
                    }
                    else
                    {
                        Other_flp.Controls.Add(MenuManager_btn);
                    }
                }
            }
            catch (Exception) { }
        }

        private void MenuManager_btn_Click(object sender, EventArgs e)
        {
            Order_frm.Object = "menu";
            MenuManager_frm menuManager = new MenuManager_frm();
            menuManager.ShowDialog();
            if (CategoryID == "")
            {
                LoadMenu("CF");
            }
            else
            {
                LoadMenu(CategoryID);
            }
            ListOrder();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Detail_frm detail = new Detail_frm();
            Guna2Button btn = (Guna2Button)sender;
            bill.IdMenu = Convert.ToInt32(btn.Tag.ToString());
            NameFood = BUS_Bill.Instance.TagItem(bill).Rows[0][1].ToString();
            detail.ShowDialog();
            Note = Detail_frm.Note;
            if (Detail_frm.Status == 1)
            {
                for(int i = 0; i < ListOrder_dgv.Rows.Count; i++)
                {
                    if (ListOrder_dgv.Rows[i].Cells[0].Value ==  null)
                    {
                        Detail_frm.Status = 1;
                    }
                    else if (NameFood == ListOrder_dgv.Rows[i].Cells[0].Value.ToString() && Note == ListOrder_dgv.Rows[i].Cells[3].Value.ToString())
                    {
                        ListOrder_dgv.Rows[i].Cells[1].Value = Convert.ToInt32(ListOrder_dgv.Rows[i].Cells[1].Value.ToString()) + Detail_frm.Amount;
                        ListOrder_dgv.Rows[i].Cells[2].Value = (float)Convert.ToDouble(BUS_Bill.Instance.TagItem(bill).Rows[0][2].ToString()) * Convert.ToInt32(ListOrder_dgv.Rows[i].Cells[1].Value);
                        ListOrder_dgv.Update();
                        Detail_frm.Status = 0;
                        break;
                    }
                }

                if (Detail_frm.Status == 1)
                {
                    DataGridViewRow row = (DataGridViewRow)ListOrder_dgv.Rows[0].Clone();
                    row.Cells[0].Value = BUS_Bill.Instance.TagItem(bill).Rows[0][1].ToString();
                    row.Cells[1].Value = Detail_frm.Amount;
                    row.Cells[2].Value = (float)Convert.ToDouble(BUS_Bill.Instance.TagItem(bill).Rows[0][2].ToString()) * Detail_frm.Amount;
                    row.Cells[3].Value = Detail_frm.Note;
                    row.Cells[4].Value = bill.IdMenu;
                    ListOrder_dgv.Rows.Add(row);
                    Detail_frm.Status = 0;
                }
            }
        }

        private void Menu_tc_Selected(object sender, TabControlEventArgs e)
        {
            CategoryID = Menu_tc.SelectedTab.Name.ToString();
            LoadMenu(CategoryID);
        }

        private void Menu_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu_tc.SelectedIndex = 0;
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ListOrder_dgv.SelectedRows.Count > 0)
                {
                    ListOrder_dgv.Rows.RemoveAt(this.ListOrder_dgv.SelectedRows[0].Index);
                }
            }
            catch (Exception) { }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (BUS_Bill.Instance.Table(bill).Rows[0][2].ToString() == "Trống")
                {
                    staff.Email = Login_frm.Email;
                    bill.IdStaff = BUS_Staff.Instance.Check(staff).Rows[0][0].ToString();
                    BUS_Bill.Instance.AddBill(bill);
                    for (int i = 0; i < ListOrder_dgv.Rows.Count - 1; i++)
                    {
                        bill.IdTable = Order_frm.IdTable;
                        bill.Amount = Convert.ToInt32(ListOrder_dgv.Rows[i].Cells[1].Value.ToString());
                        bill.Price =  (float)Convert.ToDouble(ListOrder_dgv.Rows[i].Cells[2].Value.ToString()) / bill.Amount;
                        bill.ToTal = bill.Price * bill.Amount;
                        bill.Note = ListOrder_dgv.Rows[i].Cells[3].Value.ToString();
                        bill.IdMenu = Convert.ToInt32(ListOrder_dgv.Rows[i].Cells[4].Value.ToString());
                        BUS_Bill.Instance.AddDesertToBill(bill);
                        Count += bill.Amount;
                    }
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //save log
                    log.Action = "thêm " + Count;
                    SaveLog();
                    //

                    this.Close();
                }
                else if (ListOrder_dgv.Rows.Count == 1)
                {
                    MessageBox.Show("Bạn chưa chọn món", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    for (int i = 0; i < ListOrder_dgv.Rows.Count - 1; i++)
                    {
                        status = 0;
                        bill.IdTable = Order_frm.IdTable;
                        bill.Amount = Convert.ToInt32(ListOrder_dgv.Rows[i].Cells[1].Value.ToString());
                        bill.Price = (float)Convert.ToDouble(ListOrder_dgv.Rows[i].Cells[2].Value.ToString());
                        bill.ToTal = bill.Price * bill.Amount;
                        bill.Note = ListOrder_dgv.Rows[i].Cells[3].Value.ToString();
                        bill.IdMenu = Convert.ToInt32(ListOrder_dgv.Rows[i].Cells[4].Value.ToString());

                        NameFood = ListOrder_dgv.Rows[i].Cells[0].Value.ToString();
                        Amount = bill.Amount;
                        Count += Amount;
                        Note = bill.Note;

                        MergeBill();
                        if (status == 0)
                        {
                            BUS_Bill.Instance.AddDesertToBill(bill);
                        }
                        
                    }
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //save log
                    log.Action = "thêm " + Count;
                    SaveLog();
                    //
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MergeBill()
        {
            for (int i = 0; i < BUS_Bill.Instance.DetailBill(bill).Rows.Count; i++)
            {
                if (NameFood == BUS_Bill.Instance.DetailBill(bill).Rows[i][0].ToString() && Note == BUS_Bill.Instance.DetailBill(bill).Rows[i][6].ToString())
                {
                    status = 1;
                    bill.IdDetailBill = Convert.ToInt32(BUS_Bill.Instance.DetailBill(bill).Rows[i][10].ToString());
                    bill.Amount = Convert.ToInt32(BUS_Bill.Instance.DetailBill(bill).Rows[i][1].ToString());
                    BUS_Bill.Instance.MergeBillMenu(bill, Amount);
                }
            }

        }
    }
}
