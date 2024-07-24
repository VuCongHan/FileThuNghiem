
namespace GUI_QuanLyCafe
{
    partial class DetailStatistic_frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailStatistic_frm));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.Voucher_lbl = new System.Windows.Forms.Label();
            this.TotalOrder_lbl = new System.Windows.Forms.Label();
            this.VAT_lbl = new System.Windows.Forms.Label();
            this.Total_lbl = new System.Windows.Forms.Label();
            this.Method_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Bill_lv = new System.Windows.Forms.ListView();
            this.NameTable_lbl = new System.Windows.Forms.Label();
            this.DateEnd_lbl = new System.Windows.Forms.Label();
            this.NameStafff_lbl = new System.Windows.Forms.Label();
            this.CheckIn_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 250;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Voucher_lbl);
            this.panel2.Controls.Add(this.TotalOrder_lbl);
            this.panel2.Controls.Add(this.VAT_lbl);
            this.panel2.Controls.Add(this.Total_lbl);
            this.panel2.Controls.Add(this.Method_lbl);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(11, 760);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 192);
            this.panel2.TabIndex = 177;
            // 
            // Voucher_lbl
            // 
            this.Voucher_lbl.AutoSize = true;
            this.Voucher_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voucher_lbl.Location = new System.Drawing.Point(0, 49);
            this.Voucher_lbl.Name = "Voucher_lbl";
            this.Voucher_lbl.Size = new System.Drawing.Size(115, 23);
            this.Voucher_lbl.TabIndex = 19;
            this.Voucher_lbl.Text = "Giảm (0%) :";
            // 
            // TotalOrder_lbl
            // 
            this.TotalOrder_lbl.AutoSize = true;
            this.TotalOrder_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalOrder_lbl.ForeColor = System.Drawing.Color.Black;
            this.TotalOrder_lbl.Location = new System.Drawing.Point(0, 13);
            this.TotalOrder_lbl.Name = "TotalOrder_lbl";
            this.TotalOrder_lbl.Size = new System.Drawing.Size(141, 23);
            this.TotalOrder_lbl.TabIndex = 16;
            this.TotalOrder_lbl.Text = "Tổng hóa đơn : ";
            // 
            // VAT_lbl
            // 
            this.VAT_lbl.AutoSize = true;
            this.VAT_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VAT_lbl.ForeColor = System.Drawing.Color.Black;
            this.VAT_lbl.Location = new System.Drawing.Point(1, 84);
            this.VAT_lbl.Name = "VAT_lbl";
            this.VAT_lbl.Size = new System.Drawing.Size(163, 23);
            this.VAT_lbl.TabIndex = 15;
            this.VAT_lbl.Text = "Thuế VAT (10%) :";
            // 
            // Total_lbl
            // 
            this.Total_lbl.AutoSize = true;
            this.Total_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_lbl.ForeColor = System.Drawing.Color.Red;
            this.Total_lbl.Location = new System.Drawing.Point(1, 157);
            this.Total_lbl.Name = "Total_lbl";
            this.Total_lbl.Size = new System.Drawing.Size(146, 23);
            this.Total_lbl.TabIndex = 14;
            this.Total_lbl.Text = "Số tiền phải trả :";
            // 
            // Method_lbl
            // 
            this.Method_lbl.AutoSize = true;
            this.Method_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Method_lbl.Location = new System.Drawing.Point(0, 121);
            this.Method_lbl.Name = "Method_lbl";
            this.Method_lbl.Size = new System.Drawing.Size(217, 23);
            this.Method_lbl.TabIndex = 1;
            this.Method_lbl.Text = "Phương thức thanh toán :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 32);
            this.label1.TabIndex = 174;
            this.label1.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // Bill_lv
            // 
            this.Bill_lv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bill_lv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bill_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.Bill_lv.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_lv.FullRowSelect = true;
            this.Bill_lv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Bill_lv.HideSelection = false;
            this.Bill_lv.Location = new System.Drawing.Point(11, 202);
            this.Bill_lv.MultiSelect = false;
            this.Bill_lv.Name = "Bill_lv";
            this.Bill_lv.Size = new System.Drawing.Size(642, 559);
            this.Bill_lv.TabIndex = 175;
            this.Bill_lv.UseCompatibleStateImageBehavior = false;
            this.Bill_lv.View = System.Windows.Forms.View.Details;
            this.Bill_lv.DoubleClick += new System.EventHandler(this.Bill_lv_DoubleClick);
            // 
            // NameTable_lbl
            // 
            this.NameTable_lbl.AutoSize = true;
            this.NameTable_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTable_lbl.Location = new System.Drawing.Point(1, 15);
            this.NameTable_lbl.Name = "NameTable_lbl";
            this.NameTable_lbl.Size = new System.Drawing.Size(52, 23);
            this.NameTable_lbl.TabIndex = 0;
            this.NameTable_lbl.Text = "Tên :";
            // 
            // DateEnd_lbl
            // 
            this.DateEnd_lbl.AutoSize = true;
            this.DateEnd_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateEnd_lbl.Location = new System.Drawing.Point(1, 80);
            this.DateEnd_lbl.Name = "DateEnd_lbl";
            this.DateEnd_lbl.Size = new System.Drawing.Size(74, 23);
            this.DateEnd_lbl.TabIndex = 152;
            this.DateEnd_lbl.Text = "Giờ ra :";
            // 
            // NameStafff_lbl
            // 
            this.NameStafff_lbl.AutoSize = true;
            this.NameStafff_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameStafff_lbl.Location = new System.Drawing.Point(1, 113);
            this.NameStafff_lbl.Name = "NameStafff_lbl";
            this.NameStafff_lbl.Size = new System.Drawing.Size(98, 23);
            this.NameStafff_lbl.TabIndex = 2;
            this.NameStafff_lbl.Text = "Thu ngân :";
            // 
            // CheckIn_lbl
            // 
            this.CheckIn_lbl.AutoSize = true;
            this.CheckIn_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckIn_lbl.Location = new System.Drawing.Point(1, 47);
            this.CheckIn_lbl.Name = "CheckIn_lbl";
            this.CheckIn_lbl.Size = new System.Drawing.Size(88, 23);
            this.CheckIn_lbl.TabIndex = 1;
            this.CheckIn_lbl.Text = "Giờ vào :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.DateEnd_lbl);
            this.panel1.Controls.Add(this.NameStafff_lbl);
            this.panel1.Controls.Add(this.CheckIn_lbl);
            this.panel1.Controls.Add(this.NameTable_lbl);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(11, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 153);
            this.panel1.TabIndex = 176;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::GUI_QuanLyCafe.Properties.Resources._1200px_Highlands_Coffee_logo_svg;
            this.pictureBox2.Location = new System.Drawing.Point(465, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 153;
            this.pictureBox2.TabStop = false;
            // 
            // DetailStatistic_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(665, 961);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bill_lv);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetailStatistic_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết hóa đơn";
            this.Load += new System.EventHandler(this.DetailStatistic_frm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Voucher_lbl;
        private System.Windows.Forms.Label TotalOrder_lbl;
        private System.Windows.Forms.Label VAT_lbl;
        private System.Windows.Forms.Label Total_lbl;
        private System.Windows.Forms.Label Method_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView Bill_lv;
        private System.Windows.Forms.Label NameTable_lbl;
        private System.Windows.Forms.Label DateEnd_lbl;
        private System.Windows.Forms.Label NameStafff_lbl;
        private System.Windows.Forms.Label CheckIn_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}