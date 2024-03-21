namespace QuanLyBanDongHo
{
    partial class frmGioHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDongHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnXoaGioHang = new System.Windows.Forms.Button();
            this.txtMaGH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.AllowUserToAddRows = false;
            this.dgvGioHang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvGioHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGioHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvGioHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.TenDH,
            this.SLM,
            this.DonGia,
            this.TongTien,
            this.MaDongHo});
            this.dgvGioHang.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGioHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGioHang.Location = new System.Drawing.Point(0, -1);
            this.dgvGioHang.MultiSelect = false;
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.ReadOnly = true;
            this.dgvGioHang.RowHeadersVisible = false;
            this.dgvGioHang.RowHeadersWidth = 51;
            this.dgvGioHang.RowTemplate.Height = 24;
            this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGioHang.Size = new System.Drawing.Size(1205, 484);
            this.dgvGioHang.TabIndex = 0;
            this.dgvGioHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGioHang_CellClick);
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "MaGioHang";
            this.Ma.HeaderText = "Mã Giỏ Hàng";
            this.Ma.MinimumWidth = 6;
            this.Ma.Name = "Ma";
            this.Ma.ReadOnly = true;
            this.Ma.Visible = false;
            // 
            // TenDH
            // 
            this.TenDH.DataPropertyName = "TenDongHo";
            this.TenDH.HeaderText = "Tên Đồng Hồ";
            this.TenDH.MinimumWidth = 6;
            this.TenDH.Name = "TenDH";
            this.TenDH.ReadOnly = true;
            // 
            // SLM
            // 
            this.SLM.DataPropertyName = "SoLuongMua";
            this.SLM.HeaderText = "Số Lượng Mua";
            this.SLM.MinimumWidth = 6;
            this.SLM.Name = "SLM";
            this.SLM.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // MaDongHo
            // 
            this.MaDongHo.DataPropertyName = "MaDongHo";
            this.MaDongHo.HeaderText = "Mã Đồng Hồ";
            this.MaDongHo.MinimumWidth = 6;
            this.MaDongHo.Name = "MaDongHo";
            this.MaDongHo.ReadOnly = true;
            this.MaDongHo.Visible = false;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(1180, 701);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(100, 22);
            this.txtTK.TabIndex = 1;
            this.txtTK.Visible = false;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThanhToan.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(754, 511);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(250, 87);
            this.btnThanhToan.TabIndex = 4;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnXoaGioHang
            // 
            this.btnXoaGioHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoaGioHang.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaGioHang.Location = new System.Drawing.Point(248, 511);
            this.btnXoaGioHang.Name = "btnXoaGioHang";
            this.btnXoaGioHang.Size = new System.Drawing.Size(248, 87);
            this.btnXoaGioHang.TabIndex = 4;
            this.btnXoaGioHang.Text = "Xóa Giỏ Hàng";
            this.btnXoaGioHang.UseVisualStyleBackColor = false;
            this.btnXoaGioHang.Click += new System.EventHandler(this.btnXoaGioHang_Click);
            // 
            // txtMaGH
            // 
            this.txtMaGH.Location = new System.Drawing.Point(-77, 616);
            this.txtMaGH.Name = "txtMaGH";
            this.txtMaGH.Size = new System.Drawing.Size(100, 22);
            this.txtMaGH.TabIndex = 5;
            this.txtMaGH.Visible = false;
            // 
            // frmGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanDongHo.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(1205, 662);
            this.Controls.Add(this.txtMaGH);
            this.Controls.Add(this.btnXoaGioHang);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.dgvGioHang);
            this.Name = "frmGioHang";
            this.Text = "Giỏ Hàng";
            this.Load += new System.EventHandler(this.frmGioHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnXoaGioHang;
        private System.Windows.Forms.TextBox txtMaGH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDongHo;
    }
}