namespace QuanLyBanDongHo
{
    partial class frmDSSP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAnhSP = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLoaiSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picSP = new System.Windows.Forms.PictureBox();
            this.txtTH = new System.Windows.Forms.TextBox();
            this.dgvDongHo = new System.Windows.Forms.DataGridView();
            this.Pic = new System.Windows.Forms.DataGridViewImageColumn();
            this.MaDongHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDongHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiDongHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HangDongHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPic = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDongHo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(655, 345);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(273, 34);
            this.txtGia.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(442, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 23);
            this.label7.TabIndex = 36;
            this.label7.Text = "Giá Tiền";
            // 
            // btnAnhSP
            // 
            this.btnAnhSP.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnhSP.Location = new System.Drawing.Point(999, 292);
            this.btnAnhSP.Name = "btnAnhSP";
            this.btnAnhSP.Size = new System.Drawing.Size(124, 74);
            this.btnAnhSP.TabIndex = 48;
            this.btnAnhSP.Text = "ẢNH";
            this.btnAnhSP.UseVisualStyleBackColor = true;
            this.btnAnhSP.Click += new System.EventHandler(this.btnAnhSP_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(196, 57);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(115, 74);
            this.btnCapNhat.TabIndex = 23;
            this.btnCapNhat.Text = "CẬP NHẬT";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 261);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(37, 165);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(116, 70);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(37, 56);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(116, 74);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(196, 165);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(115, 74);
            this.btnHuy.TabIndex = 26;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(655, 292);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(273, 34);
            this.txtSL.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(388, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(350, 35);
            this.label5.TabIndex = 49;
            this.label5.Text = "QUẢN LÝ HÀNG HÓA";
            // 
            // txtLoaiSP
            // 
            this.txtLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiSP.Location = new System.Drawing.Point(655, 183);
            this.txtLoaiSP.Name = "txtLoaiSP";
            this.txtLoaiSP.Size = new System.Drawing.Size(273, 34);
            this.txtLoaiSP.TabIndex = 47;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(655, 118);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(273, 34);
            this.txtTenSP.TabIndex = 43;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.Location = new System.Drawing.Point(655, 63);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(273, 34);
            this.txtMaSP.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 40;
            this.label4.Text = "Số Lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(442, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "Thương Hiệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 23);
            this.label2.TabIndex = 38;
            this.label2.Text = "Loại Sản Phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tên Sản Phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(442, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 23);
            this.label6.TabIndex = 41;
            this.label6.Text = "Mã Sản Phẩm";
            // 
            // picSP
            // 
            this.picSP.Location = new System.Drawing.Point(951, 64);
            this.picSP.Name = "picSP";
            this.picSP.Size = new System.Drawing.Size(208, 199);
            this.picSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSP.TabIndex = 35;
            this.picSP.TabStop = false;
            // 
            // txtTH
            // 
            this.txtTH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTH.Location = new System.Drawing.Point(655, 239);
            this.txtTH.Name = "txtTH";
            this.txtTH.Size = new System.Drawing.Size(273, 34);
            this.txtTH.TabIndex = 46;
            // 
            // dgvDongHo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDongHo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDongHo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDongHo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDongHo.BackgroundColor = System.Drawing.Color.White;
            this.dgvDongHo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDongHo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDongHo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDongHo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDongHo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pic,
            this.MaDongHo,
            this.TenDongHo,
            this.LoaiDongHo,
            this.HangDongHo,
            this.SoLuong,
            this.DonGia,
            this.HinhAnh});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDongHo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDongHo.GridColor = System.Drawing.Color.Black;
            this.dgvDongHo.Location = new System.Drawing.Point(-6, 395);
            this.dgvDongHo.Name = "dgvDongHo";
            this.dgvDongHo.ReadOnly = true;
            this.dgvDongHo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDongHo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDongHo.RowHeadersVisible = false;
            this.dgvDongHo.RowHeadersWidth = 51;
            this.dgvDongHo.RowTemplate.Height = 200;
            this.dgvDongHo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDongHo.Size = new System.Drawing.Size(1204, 363);
            this.dgvDongHo.TabIndex = 51;
            this.dgvDongHo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDongHo_CellClick);
            // 
            // Pic
            // 
            this.Pic.DataPropertyName = "Pic";
            this.Pic.FillWeight = 187.1657F;
            this.Pic.HeaderText = "Hình Ảnh";
            this.Pic.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Pic.MinimumWidth = 6;
            this.Pic.Name = "Pic";
            this.Pic.ReadOnly = true;
            this.Pic.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Pic.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MaDongHo
            // 
            this.MaDongHo.DataPropertyName = "MaDongHo";
            this.MaDongHo.FillWeight = 85.47234F;
            this.MaDongHo.HeaderText = "Mã Đồng Hồ";
            this.MaDongHo.MinimumWidth = 6;
            this.MaDongHo.Name = "MaDongHo";
            this.MaDongHo.ReadOnly = true;
            // 
            // TenDongHo
            // 
            this.TenDongHo.DataPropertyName = "TenDongHo";
            this.TenDongHo.FillWeight = 85.47234F;
            this.TenDongHo.HeaderText = "Tên Đồng Hồ";
            this.TenDongHo.MinimumWidth = 6;
            this.TenDongHo.Name = "TenDongHo";
            this.TenDongHo.ReadOnly = true;
            // 
            // LoaiDongHo
            // 
            this.LoaiDongHo.DataPropertyName = "LoaiDongHo";
            this.LoaiDongHo.FillWeight = 85.47234F;
            this.LoaiDongHo.HeaderText = "Loại Đồng Hồ";
            this.LoaiDongHo.MinimumWidth = 6;
            this.LoaiDongHo.Name = "LoaiDongHo";
            this.LoaiDongHo.ReadOnly = true;
            // 
            // HangDongHo
            // 
            this.HangDongHo.DataPropertyName = "HangDongHo";
            this.HangDongHo.FillWeight = 85.47234F;
            this.HangDongHo.HeaderText = "Hãng Đồng Hồ";
            this.HangDongHo.MinimumWidth = 6;
            this.HangDongHo.Name = "HangDongHo";
            this.HangDongHo.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.FillWeight = 85.47234F;
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.FillWeight = 85.47234F;
            this.DonGia.HeaderText = "Giá Tiền";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // HinhAnh
            // 
            this.HinhAnh.DataPropertyName = "HinhAnh";
            this.HinhAnh.HeaderText = "Link";
            this.HinhAnh.MinimumWidth = 6;
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.ReadOnly = true;
            this.HinhAnh.Visible = false;
            // 
            // txtPic
            // 
            this.txtPic.Location = new System.Drawing.Point(1152, 342);
            this.txtPic.Name = "txtPic";
            this.txtPic.Size = new System.Drawing.Size(100, 24);
            this.txtPic.TabIndex = 52;
            this.txtPic.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyBanDongHo.Properties.Resources.QL;
            this.pictureBox1.Location = new System.Drawing.Point(-6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmDSSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanDongHo.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(1195, 741);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPic);
            this.Controls.Add(this.dgvDongHo);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAnhSP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTH);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLoaiSP);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.picSP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDSSP";
            this.Text = "Danh Sách Sản Phẩm";
            this.Load += new System.EventHandler(this.frmDSSP_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDongHo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAnhSP;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLoaiSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picSP;
        private System.Windows.Forms.TextBox txtTH;
        private System.Windows.Forms.DataGridView dgvDongHo;
        private System.Windows.Forms.DataGridViewImageColumn Pic;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDongHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDongHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiDongHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HangDongHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhAnh;
        private System.Windows.Forms.TextBox txtPic;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}