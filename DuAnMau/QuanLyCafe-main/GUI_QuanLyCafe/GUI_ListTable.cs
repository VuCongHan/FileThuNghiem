using BUS_QuanLyCafe;
using DTO_QuanLyCafe;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI_QuanLyCafe
{
    public partial class ListTable_frm : Form
    {
        public ListTable_frm()
        {
            InitializeComponent();
        }
        DTO_Bill bill = new DTO_Bill();
        DTO_Log log = new DTO_Log();
        DTO_Staff staff = new DTO_Staff();
        public int OldIdTable;
        public int OldIdBill;
        public int NewIdTable;
        public int NewIdBill;
        public string NameFood;
        public static int Amount;
        public static int Status;
        public int IdMenu;
        public string Note;

        private void DetachTable_frm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            Status = 1;
            LoadTable();
            LoadBill();

            OldIdTable = Order_frm.IdTable;
            bill.IdTable = OldIdTable;
            if (BUS_Bill.Instance.DetailBill(bill).Rows.Count > 0)
            {
                OldIdBill = Convert.ToInt32(BUS_Bill.Instance.DetailBill(bill).Rows[0][8].ToString());
            } 
        }

        void LoadTable()
        {
            Table_flp.Controls.Clear();
            for (int i = 0; i < BUS_Table.Instance.ListTable().Rows.Count; i++)
            {
                Button btn = new Button();
                btn.Width = 100;
                btn.Height = 90;
                btn.Text = BUS_Table.Instance.ListTable().Rows[i][1].ToString() + Environment.NewLine + BUS_Table.Instance.ListTable().Rows[i][2].ToString();
                btn.Click += btn_Click;
                btn.Tag = BUS_Table.Instance.ListTable().Rows[i][0].ToString();
                if (BUS_Table.Instance.ListTable().Rows[i][2].ToString() == "Trống")
                {
                    btn.BackColor = Color.White;
                }
                else
                {
                    btn.BackColor = Color.AntiqueWhite;
                }
                Table_flp.Controls.Add(btn);
            }
        }

        private void SaveLog()
        {
            log.IdStaff = Login_frm.IdStaff;
            log.DateStart = DateTime.Now;
            BUS_Log.Instance.InsertLog(log);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            NewIdTable = Convert.ToInt32(btn.Tag.ToString());
            bill.IdTable = NewIdTable;
            NameTable2_lbl.Text = "Tên : " + BUS_Bill.Instance.Table(bill).Rows[0][1].ToString();
            ListOrder2_dgv.DataSource = BUS_Bill.Instance.BillTable_DGV(bill);
            ListOrder2_dgv.Columns[0].Visible = false;
            ListOrder2_dgv.Columns[4].Visible = false;
            ListOrder2_dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListOrder2_dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListOrder2_dgv.Columns[2].Width = 108;
            Switch_btn.Enabled = true;
            Merge_btn.Enabled = true;
            Detach_btn.Enabled = true;
        }

        void LoadBill()
        {
            NameTable1_lbl.Text = "Tên : " + Order_frm.NameTable;
            bill.IdTable = Order_frm.IdTable;
            ListOrder1_dgv.DataSource = BUS_Bill.Instance.BillTable_DGV(bill);
            ListOrder1_dgv.Columns[0].Visible = false;
            ListOrder1_dgv.Columns[4].Visible = false;
            ListOrder1_dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListOrder1_dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListOrder1_dgv.Columns[2].Width = 108;  
        }

        private void Switch_btn_Click(object sender, EventArgs e)
        {
            if (BUS_Bill.Instance.Table(bill).Rows[0][0].ToString() == Order_frm.IdTable.ToString())
            {
                MessageBox.Show("Bạn đang ở bàn này (" + Order_frm.NameTable + ")", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (BUS_Bill.Instance.Table(bill).Rows[0][2].ToString() == "Trống")
            {
                try
                {
                    var dlr = MessageBox.Show("Bạn có muốn chuyển từ " + Order_frm.NameTable.ToLower() + " sang " + BUS_Bill.Instance.Table(bill).Rows[0][1].ToString().ToLower() + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dlr == DialogResult.Yes)
                    {
                        BUS_Bill.Instance.Switch(NewIdTable, OldIdTable);

                        //save log
                        log.Object1 = "hóa đơn";
                        log.IdObject = Order_frm.NameTable.Trim() + " sang " + NameTable2_lbl.Text.Substring(6);
                        log.Action = "chuyển";
                        SaveLog();
                        //

                        
                        MessageBox.Show("Chuyển bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Chuyển bàn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bàn này đã có người, không thể chuyển bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Merge_btn_Click(object sender, EventArgs e)
        {
            if (BUS_Bill.Instance.Table(bill).Rows[0][0].ToString() == Order_frm.IdTable.ToString())
            {
                MessageBox.Show("Bạn đang ở bàn này (" + Order_frm.NameTable + ")", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(BUS_Bill.Instance.Table(bill).Rows[0][2].ToString() == "Có người")
            {
                try
                {
                    var dlr = MessageBox.Show(BUS_Bill.Instance.Table(bill).Rows[0][1].ToString() + " này đã có người, bạn có muốn gộp bàn không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dlr == DialogResult.Yes)
                    {
                        NewIdBill = Convert.ToInt32(BUS_Bill.Instance.DetailBill(bill).Rows[0][8].ToString());
                        BUS_Bill.Instance.Merge(NewIdTable, OldIdTable, NewIdBill, OldIdBill);

                        if (ListOrder2_dgv.Rows.Count > ListOrder1_dgv.Rows.Count)
                        {
                            for (int i = 0; i < ListOrder1_dgv.Rows.Count - 1; i++)
                            {
                                for (int j = 0; j < ListOrder2_dgv.Rows.Count - 1; j++)
                                {
                                    IdMenu = Convert.ToInt32(ListOrder2_dgv.Rows[j].Cells[4].Value.ToString());
                                    bill.IdMenu = IdMenu;
                                    Note = ListOrder2_dgv.Rows[j].Cells[3].Value.ToString().Trim();
                                    if (IdMenu == Convert.ToInt32(ListOrder1_dgv.Rows[i].Cells[4].Value.ToString()) && Note == ListOrder1_dgv.Rows[i].Cells[3].Value.ToString().Trim())
                                    {
                                        bill.IdDetailBill = Convert.ToInt32(ListOrder2_dgv.Rows[j].Cells[0].Value.ToString());
                                        bill.Amount = Convert.ToInt32(ListOrder1_dgv.Rows[i].Cells[2].Value.ToString());
                                        bill.Price = (float)Convert.ToDouble(BUS_Bill.Instance.TagItem(bill).Rows[0][2].ToString());
                                        bill.ToTal = bill.Price * (Convert.ToInt32(ListOrder1_dgv.Rows[i].Cells[2].Value.ToString()) + Convert.ToInt32(ListOrder2_dgv.Rows[j].Cells[2].Value.ToString()));
                                        BUS_Bill.Instance.MergeBill(bill, Convert.ToInt32(ListOrder2_dgv.Rows[j].Cells[2].Value.ToString()));
                                    }
                                }
                            }
                        }
                        else
                        {
                            for (int i = 0; i < ListOrder2_dgv.Rows.Count - 1; i++)
                            {
                                for (int j = 0; j < ListOrder1_dgv.Rows.Count - 1; j++)
                                {
                                    IdMenu = Convert.ToInt32(ListOrder1_dgv.Rows[j].Cells[4].Value.ToString());
                                    bill.IdMenu = IdMenu;
                                    Note = ListOrder1_dgv.Rows[j].Cells[3].Value.ToString().Trim();
                                    if (IdMenu == Convert.ToInt32(ListOrder2_dgv.Rows[i].Cells[4].Value.ToString()) && Note == ListOrder2_dgv.Rows[i].Cells[3].Value.ToString().Trim())
                                    {
                                        bill.IdDetailBill = Convert.ToInt32(ListOrder1_dgv.Rows[j].Cells[0].Value.ToString());
                                        bill.Amount = Convert.ToInt32(ListOrder2_dgv.Rows[i].Cells[2].Value.ToString());
                                        bill.Price = (float)Convert.ToDouble(BUS_Bill.Instance.TagItem(bill).Rows[0][2].ToString());
                                        bill.ToTal = bill.Price * (Convert.ToInt32(ListOrder1_dgv.Rows[j].Cells[2].Value.ToString()) + Convert.ToInt32(ListOrder2_dgv.Rows[i].Cells[2].Value.ToString()));
                                        BUS_Bill.Instance.MergeBill(bill, Convert.ToInt32(ListOrder1_dgv.Rows[j].Cells[2].Value.ToString()));
                                    }
                                }
                            }      
                        }

                        //save log
                        log.Object1 = "hóa đơn";
                        log.IdObject = Order_frm.NameTable.Trim() + " và " + NameTable2_lbl.Text.Substring(6);
                        log.Action = "gộp";
                        SaveLog();
                        //

                        MessageBox.Show("Gộp bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Gộp bàn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bàn này chưa có người, không thể gộp bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Detach_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (bill.IdDetailBill == 0)
                {
                    MessageBox.Show("Bạn chưa chọn món cần tách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ListOrder1_dgv.Rows.Count == 2 && Amount < 2)
                {
                    MessageBox.Show("Số món không đủ để tách bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(BUS_Bill.Instance.Table(bill).Rows[0][0].ToString() == Order_frm.IdTable.ToString())
                {
                    MessageBox.Show("Bạn đang ở bàn này (" + Order_frm.NameTable + ")", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var dlr = MessageBox.Show("Bạn có muốn tách " + NameFood + " từ " + Order_frm.NameTable.ToLower() + " sang " + BUS_Bill.Instance.Table(bill).Rows[0][1].ToString().ToLower() + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dlr == DialogResult.Yes)
                    {
                        if (BUS_Bill.Instance.Table(bill).Rows[0][2].ToString() == "Trống")
                        {
                            staff.Email = Login_frm.Email;
                            bill.IdStaff = BUS_Staff.Instance.Check(staff).Rows[0][0].ToString();
                            BUS_Bill.Instance.AddBill(bill);
                            Detach();
                            if (ListOrder2_dgv.Rows.Count == 1)
                            {
                                bill.IdTable = Convert.ToInt32(NameTable2_lbl.Text.Substring(10));
                                bill.IdDetailBill = 0;
                                BUS_Bill.Instance.Delete(bill);
                            }
                        }
                        else
                        {
                            Detach();
                        }
                    }
                }
            }
            catch (Exception) 
            {
                MessageBox.Show("Tách bàn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Detach()
        {
            bill.Amount = Amount;
            bill.IdMenu = IdMenu;
            if (Amount > 1)
            {
                Menu_frm.NameFood = NameFood;
                Detail_frm detail = new Detail_frm();
                detail.ShowDialog();
                if (Detail_frm.Status == 1)
                {
                    if (ListOrder1_dgv.Rows.Count == 2 && Amount == Detail_frm.Amount)
                    {
                        Detail_frm.Status = 0;
                        MessageBox.Show("Tách bàn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        bill.Note = Detail_frm.Note;
                        Note = Detail_frm.Note;
                        bill.Price = (float)Convert.ToDouble(BUS_Bill.Instance.TagItem(bill).Rows[0][2].ToString());
                        bill.ToTal = bill.Price * Detail_frm.Amount;
                        BUS_Bill.Instance.AddDesertToBill(bill);
                        BUS_Bill.Instance.Detach(bill, Detail_frm.Amount);

                        //save log
                        log.Object1 = "món";
                        log.IdObject = Order_frm.NameTable.Trim() + " sang " + NameTable2_lbl.Text.Substring(6);
                        log.Action = "tách " + Detail_frm.Amount;
                        SaveLog();
                        //

                        MessageBox.Show("Tách bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
               
            }
            else
            {
                Detail_frm.Status = 1;
                bill.Price = (float)Convert.ToDouble(BUS_Bill.Instance.TagItem(bill).Rows[0][2].ToString());
                bill.ToTal = bill.Price * Detail_frm.Amount;
                BUS_Bill.Instance.Detach(bill, Detail_frm.Amount);
                //save log
                log.Object1 = "món";
                log.IdObject = Order_frm.NameTable.Trim() + " sang " + NameTable2_lbl.Text.Substring(6);
                log.Action = "tách 1";
                SaveLog();
                //

                MessageBox.Show("Tách bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Detail_frm.Status == 1)
            {
                for (int i = 0; i < ListOrder2_dgv.Rows.Count - 1; i++)
                {
                    if (IdMenu == Convert.ToInt32(ListOrder2_dgv.Rows[i].Cells[4].Value.ToString()) && Note == ListOrder2_dgv.Rows[i].Cells[3].Value.ToString().Trim())
                    {
                        bill.IdDetailBill = Convert.ToInt32(ListOrder2_dgv.Rows[i].Cells[0].Value.ToString());
                        bill.Amount = Convert.ToInt32(ListOrder2_dgv.Rows[i].Cells[2].Value.ToString());
                        bill.ToTal = bill.Price * (bill.Amount + Detail_frm.Amount);
                        BUS_Bill.Instance.MergeBill(bill, Detail_frm.Amount);
                    }
                }
                LoadTable();
                LoadBill();
                bill.IdTable = Convert.ToInt32(NameTable2_lbl.Text.Substring(10));
                ListOrder2_dgv.DataSource = BUS_Bill.Instance.BillTable_DGV(bill);
                ListOrder2_dgv.Columns[0].Visible = false;
                ListOrder2_dgv.Columns[4].Visible = false;
                bill.IdDetailBill = 0;
                Detail_frm.Status = 0;
            }
        }

        private void ListOrder1_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = ListOrder1_dgv.Rows[e.RowIndex];
                bill.IdDetailBill = Convert.ToInt32(row.Cells[0].Value.ToString());
                NameFood = row.Cells[1].Value.ToString();
                Amount = Convert.ToInt32(row.Cells[2].Value.ToString());
                Note = row.Cells[3].Value.ToString();
                IdMenu = Convert.ToInt32(row.Cells[4].Value.ToString());
            }
            catch (Exception) { }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (bill.IdDetailBill == 0)
                {
                    MessageBox.Show("Bạn chưa chọn món cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {  
                    if (Confirm_frm.Result == 1)
                    {
                        var dlr = MessageBox.Show("Bạn có muốn xóa " + NameFood + " của " + Order_frm.NameTable.ToLower() + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dlr == DialogResult.Yes)
                        {
                            bill.IdTable = Order_frm.IdTable;
                            BUS_Bill.Instance.Delete(bill);
                            LoadTable();
                            LoadBill();
                            bill.IdTable = Convert.ToInt32(NameTable1_lbl.Text.Substring(10));
                            ListOrder1_dgv.DataSource = BUS_Bill.Instance.BillTable_DGV(bill);
                            ListOrder1_dgv.Columns[0].Visible = false;
                            ListOrder1_dgv.Columns[4].Visible = false;
                            bill.IdDetailBill = 0;

                            //save log
                            log.Object1 = "món";
                            log.IdObject = Order_frm.NameTable.Trim();
                            log.Action = "xóa " + Amount;
                            SaveLog();
                            //

                            MessageBox.Show("Xóa " + NameFood + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        Confirm_frm confirm = new Confirm_frm();
                        confirm.ShowDialog();
                        if (Confirm_frm.Result == 1)
                        {
                            var dlr = MessageBox.Show("Bạn có muốn xóa " + NameFood + " của " + Order_frm.NameTable.ToLower() + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (dlr == DialogResult.Yes)
                            {
                                bill.IdTable = Order_frm.IdTable;
                                BUS_Bill.Instance.Delete(bill);
                                bill.IdTable = Convert.ToInt32(NameTable1_lbl.Text.Substring(10));
                                ListOrder1_dgv.DataSource = BUS_Bill.Instance.BillTable_DGV(bill);
                                ListOrder1_dgv.Columns[0].Visible = false;
                                ListOrder1_dgv.Columns[4].Visible = false;
                                bill.IdDetailBill = 0;

                                //save log
                                log.Object1 = "món";
                                log.IdObject = Order_frm.NameTable.Trim();
                                log.Action = "xóa " + Amount;
                                SaveLog();
                                //

                                MessageBox.Show("Xóa " + NameFood + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        Confirm_frm.Result = 0;
                    } 
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa " + NameFood + " thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListTable_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Status = 0;
        }

        private void Log_MenuItem_Click(object sender, EventArgs e)
        {
            Log_frm log = new Log_frm();
            log.ShowDialog();
        }
    }
}
