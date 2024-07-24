namespace GUI
{
    partial class THONGKE
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
            this.tabControlThogKe = new System.Windows.Forms.TabControl();
            this.tabTKSPNhapKho = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewSPNK = new System.Windows.Forms.DataGridView();
            this.tabTKSPTonKho = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewSPTK = new System.Windows.Forms.DataGridView();
            this.tabControlThogKe.SuspendLayout();
            this.tabTKSPNhapKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSPNK)).BeginInit();
            this.tabTKSPTonKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSPTK)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlThogKe
            // 
            this.tabControlThogKe.Controls.Add(this.tabTKSPNhapKho);
            this.tabControlThogKe.Controls.Add(this.tabTKSPTonKho);
            this.tabControlThogKe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControlThogKe.Location = new System.Drawing.Point(11, 12);
            this.tabControlThogKe.Name = "tabControlThogKe";
            this.tabControlThogKe.SelectedIndex = 0;
            this.tabControlThogKe.Size = new System.Drawing.Size(671, 324);
            this.tabControlThogKe.TabIndex = 0;
            // 
            // tabTKSPNhapKho
            // 
            this.tabTKSPNhapKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tabTKSPNhapKho.Controls.Add(this.label1);
            this.tabTKSPNhapKho.Controls.Add(this.dataGridViewSPNK);
            this.tabTKSPNhapKho.Location = new System.Drawing.Point(4, 28);
            this.tabTKSPNhapKho.Name = "tabTKSPNhapKho";
            this.tabTKSPNhapKho.Padding = new System.Windows.Forms.Padding(3);
            this.tabTKSPNhapKho.Size = new System.Drawing.Size(663, 292);
            this.tabTKSPNhapKho.TabIndex = 0;
            this.tabTKSPNhapKho.Text = "Sản phẩm nhập kho";
            this.tabTKSPNhapKho.Click += new System.EventHandler(this.tabTKSPNhapKho_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(85, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "THỐNG KÊ SẢN PHẨM NHẬP KHO";
            // 
            // dataGridViewSPNK
            // 
            this.dataGridViewSPNK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSPNK.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGridViewSPNK.Location = new System.Drawing.Point(5, 70);
            this.dataGridViewSPNK.Name = "dataGridViewSPNK";
            this.dataGridViewSPNK.RowHeadersWidth = 51;
            this.dataGridViewSPNK.RowTemplate.Height = 24;
            this.dataGridViewSPNK.Size = new System.Drawing.Size(654, 219);
            this.dataGridViewSPNK.TabIndex = 0;
            // 
            // tabTKSPTonKho
            // 
            this.tabTKSPTonKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tabTKSPTonKho.Controls.Add(this.label2);
            this.tabTKSPTonKho.Controls.Add(this.dataGridViewSPTK);
            this.tabTKSPTonKho.Location = new System.Drawing.Point(4, 28);
            this.tabTKSPTonKho.Name = "tabTKSPTonKho";
            this.tabTKSPTonKho.Padding = new System.Windows.Forms.Padding(3);
            this.tabTKSPTonKho.Size = new System.Drawing.Size(663, 292);
            this.tabTKSPTonKho.TabIndex = 1;
            this.tabTKSPTonKho.Text = "Tồn kho";
            this.tabTKSPTonKho.Click += new System.EventHandler(this.tabTKSPTonKho_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(88, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(543, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "THỐNG KÊ SẢN PHẨM TỒN KHO";
            // 
            // dataGridViewSPTK
            // 
            this.dataGridViewSPTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSPTK.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGridViewSPTK.Location = new System.Drawing.Point(6, 69);
            this.dataGridViewSPTK.Name = "dataGridViewSPTK";
            this.dataGridViewSPTK.RowHeadersWidth = 51;
            this.dataGridViewSPTK.RowTemplate.Height = 24;
            this.dataGridViewSPTK.Size = new System.Drawing.Size(653, 222);
            this.dataGridViewSPTK.TabIndex = 0;
            // 
            // THONGKE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(692, 334);
            this.Controls.Add(this.tabControlThogKe);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "THONGKE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THONGKE";
            this.Load += new System.EventHandler(this.THONGKE_Load);
            this.tabControlThogKe.ResumeLayout(false);
            this.tabTKSPNhapKho.ResumeLayout(false);
            this.tabTKSPNhapKho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSPNK)).EndInit();
            this.tabTKSPTonKho.ResumeLayout(false);
            this.tabTKSPTonKho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSPTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlThogKe;
        private System.Windows.Forms.TabPage tabTKSPNhapKho;
        private System.Windows.Forms.TabPage tabTKSPTonKho;
        private System.Windows.Forms.DataGridView dataGridViewSPNK;
        private System.Windows.Forms.DataGridView dataGridViewSPTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}