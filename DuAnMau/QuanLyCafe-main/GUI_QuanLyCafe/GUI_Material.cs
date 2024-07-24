using BUS_QuanLyCafe;
using DTO_QuanLyCafe;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace GUI_QuanLyCafe
{
    public partial class Material_frm : Form
    {
        public Material_frm()
        {
            InitializeComponent();
        }

        DTO_Material material = new DTO_Material();
        DTO_Log log = new DTO_Log();

        private void Material_frm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label12;
            ListMaterial();
            FomatDatagridView();
        }

        private void FomatDatagridView()
        {
            ListMaterial_dgv.DataSource = BUS_Material.Instance.ListMaterial_DGV();
            ListMaterial_dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListMaterial_dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListMaterial_dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListMaterial_dgv.Columns[2].Width = 120;
            ListMaterial_dgv.Columns[3].Width = 150;  
        }

        private void ListMaterial()
        {
            try
            {
                IdMaterial_txt.Text = BUS_Material.Instance.ListMaterial().Rows[0][0].ToString();
                NameMaterial_txt.Text = BUS_Material.Instance.ListMaterial().Rows[0][1].ToString();
                Amount_txt.Text = BUS_Material.Instance.ListMaterial().Rows[0][2].ToString();
                Type_cbb.Text = BUS_Material.Instance.ListMaterial().Rows[0][3].ToString();
                Status_txt.Text = BUS_Material.Instance.ListMaterial().Rows[0][4].ToString();
                Producer_txt.Text = BUS_Material.Instance.ListMaterial().Rows[0][5].ToString();
                float value = (float)double.Parse(BUS_Material.Instance.ListMaterial().Rows[0][6].ToString());
                Price_txt.Text = String.Format("{0:0,0}", value);
                Date_date.Text = BUS_Material.Instance.ListMaterial().Rows[0][7].ToString();
                PathPicture_txt.Text = BUS_Material.Instance.ListMaterial().Rows[0][8].ToString();
                Picture_ptb.Image = Image.FromFile(Application.StartupPath + BUS_Material.Instance.ListMaterial().Rows[0][8].ToString());   
            }
            catch (Exception) { }
        }

        private void Edit_ckb_CheckedChanged(object sender, EventArgs e)
        {
            if (Edit_ckb.Checked == true)
            {
                //text
                NameMaterial_txt.ReadOnly = false;
                Amount_txt.ReadOnly = false;
                Price_txt.ReadOnly = false;
                Producer_txt.ReadOnly = false;


                //compoBox
                Type_cbb.Enabled = true;

                //Date
                Date_date.Enabled = true;

                //btn
                Delete_btn.Enabled = true;
                Edit_btn.Enabled = true;
                OpenFilePicture_btn.Enabled = true;
                CreateID_btn.Enabled = true;
                OpenFilePicture_btn.Visible = true;

            }
            else
            {
                //text
                IdMaterial_txt.ReadOnly = true;
                NameMaterial_txt.ReadOnly = true;
                Producer_txt.ReadOnly = true;
                Amount_txt.ReadOnly = true;
                Price_txt.ReadOnly = true;
                Find_txt.ReadOnly = false;

                //comboBox
                Type_cbb.Enabled = false;

                //Date
                Date_date.Enabled = false;

                //btn
                Add_btn.Enabled = false;
                Delete_btn.Enabled = false;
                Edit_btn.Enabled = false;
                CreateID_btn.Enabled = false;
                OpenFilePicture_btn.Visible = false;
                ResetFind_btn.Enabled = true;

                //datagridview
                ListMaterial_dgv.Enabled = true;

                //
                IdMaterial_lbl.ForeColor = Color.Black;
                NameMaterial__lbl.ForeColor = Color.Black;
                Amount_lbl.ForeColor = Color.Black;
                Type_lbl.ForeColor = Color.Black;
                Producer_lbl.ForeColor = Color.Black;
                Price_lbl.ForeColor = Color.Black;

            }
        }

        private void SaveLog()
        {
            log.IdStaff = Login_frm.IdStaff;
            log.Object1 = Order_frm.Object;
            log.IdObject = IdMaterial_txt.Text.Trim();
            log.DateStart = DateTime.Now;
            BUS_Log.Instance.InsertLog(log);
        }

        private void ResetText()
        {
            IdMaterial_txt.Text = "";
            NameMaterial_txt.Text = "";
            Amount_txt.Text = "0";
            Type_cbb.SelectedIndex = -1;
            Price_txt.Text = "0";
            Producer_txt.Text = "";
            Date_date.Value = DateTime.Now;
            Picture_ptb.Image = Image.FromFile(Application.StartupPath + @"\Image\Icon\unknown.PNG");
            PathPicture_txt.Text = @"\Image\Icon\unknown.PNG";
        }

        private void ResetFind_btn_Click(object sender, EventArgs e)
        {
            Find_txt.Text = "";
            ListMaterial();
        }

        private void Material_frm_FormClosing(object sender, FormClosingEventArgs e)
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
                material.IdMaterial = IdMaterial_txt.Text.Trim();
                material.NameMaterial = NameMaterial_txt.Text.Trim();
                material.ImportPrice = (float)double.Parse(Price_txt.Text);
                material.Amount = Convert.ToInt32(Amount_txt.Text);
                material.Type = Type_cbb.Text.Trim();
                material.Producer = Producer_txt.Text.Trim();
                material.ImportDate = DateTime.ParseExact(Date_date.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                material.Picture = PathPicture_txt.Text.Trim();
                material.Status = Status_txt.Text.Trim();
            }
            catch (Exception) { }
        }

        private void OpenFilePicture_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog FD = new OpenFileDialog();
            FD.Title = "Chọn file hình";
            FD.Filter = "Image files | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (FD.ShowDialog() == DialogResult.OK)
            {
                PathPicture_txt.Text = @"\" + FD.FileName.ToString().Substring(FD.FileName.ToString().LastIndexOf("Image"));
                Picture_ptb.Image = Image.FromFile(Application.StartupPath + PathPicture_txt.Text);
            }
        }

        private void CreateID_btn_Click(object sender, EventArgs e)
        {
            var dlr = MessageBox.Show("Nhấn YES để tạo vùng lưu tự động", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlr == DialogResult.Yes)
            {
                Find_txt.Text = "";
                ResetText();
                FomatDatagridView();

                //save log
                log.Action = "tạo vùng lưu";
                SaveLog();
                //

                CreateID_btn.Enabled = false;
                IdMaterial_txt.ReadOnly = false;
                Edit_ckb.Enabled = false;
                Edit_btn.Enabled = false;
                Delete_btn.Enabled = true;
                Find_txt.ReadOnly = true;
                ResetFind_btn.Enabled = false;
                ListMaterial_dgv.Enabled = false;
                VerificationText();

                this.ActiveControl = IdMaterial_txt;
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                GetText();
                if (BUS_Material.Instance.ExistMaterial(material) == true)
                {
                    MessageBox.Show("Sản phẩm này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GetText();
                    BUS_Material.Instance.InsertMaterial(material);

                    //save log
                    log.Action = "thêm";
                    SaveLog();
                    //

                    Find_txt.ReadOnly = false;
                    ResetFind_btn.Enabled = true;
                    Edit_ckb.Enabled = true;
                    IdMaterial_txt.ReadOnly = true;
                    ListMaterial_dgv.Enabled = true;
                    CreateID_btn.Enabled = true;
                    Add_btn.Enabled = false;
                    Edit_btn.Enabled = true;
                    FomatDatagridView();

                    MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                GetText();
                BUS_Material.Instance.UpdateMaterial(material);

                //save log
                log.Action = "sửa";
                SaveLog();
                //

                Edit_ckb.Checked = false;
                FomatDatagridView();

                MessageBox.Show("Sửa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var dlr = MessageBox.Show("Bạn chắc muốn xóa sản phẩm này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dlr == DialogResult.Yes)
                {
                    GetText();
                    BUS_Material.Instance.DeleteMaterial(material);

                    this.ActiveControl = label12;
                    if (CreateID_btn.Enabled == false)
                    {
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

                    FomatDatagridView();
                    MessageBox.Show("Xóa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerificationText()
        {
            IsNumber(Amount_txt.Text, Amount_txt, Amount_lbl);
            IsNumber(Price_txt.Text, Price_txt, Price_lbl);

            if (IdMaterial_txt.Text == "")
            {
                IdMaterial_lbl.ForeColor = Color.Red;
            }
            else
            {
                IdMaterial_lbl.ForeColor = Color.Black;
            }

            if (NameMaterial_txt.Text == "")
            {
                NameMaterial__lbl.ForeColor = Color.Red;
            }
            else
            {
                NameMaterial__lbl.ForeColor = Color.Black;
            }

            if (Producer_txt.Text == "")
            {
                Producer_lbl.ForeColor = Color.Red;
            }
            else
            {
                Producer_lbl.ForeColor = Color.Black;
            }

            if (Type_cbb.SelectedIndex == -1)
            {
                Type_lbl.ForeColor = Color.Red;
            }
            else
            {
                Type_lbl.ForeColor = Color.Black;
            }


            if (Edit_ckb.Checked == true)
            {
                if (IdMaterial_lbl.ForeColor == Color.Black && NameMaterial__lbl.ForeColor == Color.Black && Amount_lbl.ForeColor == Color.Black && Type_lbl.ForeColor == Color.Black && Producer_lbl.ForeColor == Color.Black && Price_lbl.ForeColor == Color.Black)
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
                if (txt == "0" || txt == "")
                {
                    ctl.ForeColor = Color.Red;
                }
                else
                {
                    foreach (char c in txt)
                    {
                        if (c == ',' && ctl.Text == "Số lượng")
                        {
                            control.Text = txt.Substring(0, txt.Length - 1);
                            control.SelectionStart = txt.Length;
                        }
                        else if ((c < '0' || c > '9') && c != ',')
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

        private void ListMaterial_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = ListMaterial_dgv.Rows[e.RowIndex];
                material.IdMaterial = row.Cells[0].Value.ToString();
                IdMaterial_txt.Text = BUS_Material.Instance.SelectMaterial(material).Rows[0][0].ToString();
                NameMaterial_txt.Text = BUS_Material.Instance.SelectMaterial(material).Rows[0][1].ToString();
                Amount_txt.Text = BUS_Material.Instance.SelectMaterial(material).Rows[0][2].ToString();
                Type_cbb.Text = BUS_Material.Instance.SelectMaterial(material).Rows[0][3].ToString();
                Status_txt.Text = BUS_Material.Instance.SelectMaterial(material).Rows[0][4].ToString();
                Producer_txt.Text = BUS_Material.Instance.SelectMaterial(material).Rows[0][5].ToString();
                float value = (float)double.Parse(BUS_Material.Instance.SelectMaterial(material).Rows[0][6].ToString());
                Price_txt.Text = String.Format("{0:0,0}", value);
                Date_date.Text = BUS_Material.Instance.SelectMaterial(material).Rows[0][7].ToString();
                PathPicture_txt.Text = BUS_Material.Instance.SelectMaterial(material).Rows[0][8].ToString();
                Picture_ptb.Image = Image.FromFile(Application.StartupPath + BUS_Material.Instance.SelectMaterial(material).Rows[0][8].ToString());
                
            }
            catch (Exception) { }
        }

        private void Find_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ResetText();
                IdMaterial_lbl.ForeColor = Color.Black;
                NameMaterial__lbl.ForeColor = Color.Black;
                Amount_lbl.ForeColor = Color.Black;
                Type_lbl.ForeColor = Color.Black;
                Producer_lbl.ForeColor = Color.Black;
                Price_lbl.ForeColor = Color.Black;
                ListMaterial_dgv.DataSource = BUS_Material.Instance.FindMaterial(Find_txt.Text);
                this.ActiveControl = Find_txt;
            }
            catch (Exception) { }
        }

        private void Type_cbb_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void Date_date_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void Date_date_CloseUp(object sender, EventArgs e)
        {
            this.ActiveControl = label12;
        }

        private void Type_cbb_SelectedValueChanged(object sender, EventArgs e)
        {
            VerificationText();
            this.ActiveControl = label12;
        }

        private void PathPicture_txt_TextChanged(object sender, EventArgs e)
        {
            VerificationText();
        }

        private void Price_txt_TextChanged(object sender, EventArgs e)
        {
            VerificationText();
        }

        private void IdMaterial_txt_TextChanged(object sender, EventArgs e)
        {
            if (IdMaterial_txt.TextLength > 50)
            {
                MessageBox.Show("Bạn nhập dài quá !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                VerificationText();
            }
            
        }

        private void NameMaterial_txt_TextChanged(object sender, EventArgs e)
        {
            if (NameMaterial_txt.TextLength > 100)
            {
                MessageBox.Show("Bạn nhập dài quá !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                VerificationText();
            }
        }

        private void Amount_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                VerificationText();
                if (Convert.ToInt32(Amount_txt.Text) > 0)
                {
                    Status_txt.Text = "Còn hàng";
                }
                else
                {
                    Status_txt.Text = "Hết hàng";
                }
            }
            catch (Exception) { }
        }

        private void Producer_txt_TextChanged(object sender, EventArgs e)
        {
            if (Producer_txt.TextLength > 50)
            {
                MessageBox.Show("Bạn nhập dài quá !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                VerificationText();
            }
        }

        private void Price_txt_Leave(object sender, EventArgs e)
        {
            float value = (float)double.Parse(Price_txt.Text);
            Price_txt.Text = String.Format("{0:0,0}", value);
        }

        private void Log_MenuItem_Click(object sender, EventArgs e)
        {
            log.Object1 = Order_frm.Object;
            Log_frm logg = new Log_frm();
            logg.ShowDialog();
        }
    }
}
