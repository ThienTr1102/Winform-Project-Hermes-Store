namespace QuanLyBanDongHo
{
    partial class frmThanhToanMOMO
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
            this.components = new System.ComponentModel.Container();
            this.btTaoQR = new System.Windows.Forms.Button();
            this.Payment = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.picMomo = new System.Windows.Forms.PictureBox();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSL = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.picDongHo = new System.Windows.Forms.PictureBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMomo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDongHo)).BeginInit();
            this.SuspendLayout();
            // 
            // btTaoQR
            // 
            this.btTaoQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btTaoQR.FlatAppearance.BorderSize = 0;
            this.btTaoQR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btTaoQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaoQR.Location = new System.Drawing.Point(506, 208);
            this.btTaoQR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btTaoQR.Name = "btTaoQR";
            this.btTaoQR.Size = new System.Drawing.Size(132, 59);
            this.btTaoQR.TabIndex = 27;
            this.btTaoQR.Text = "Tạo mã";
            this.btTaoQR.UseVisualStyleBackColor = false;
            this.btTaoQR.Click += new System.EventHandler(this.btTaoQR_Click);
            // 
            // Payment
            // 
            this.Payment.AutoSize = true;
            this.Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment.ForeColor = System.Drawing.Color.Black;
            this.Payment.Location = new System.Drawing.Point(340, 320);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(437, 58);
            this.Payment.TabIndex = 33;
            this.Payment.Text = "Quét mã QR MoMo để thanh toán :\r\n\r\n";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // picMomo
            // 
            this.picMomo.BackColor = System.Drawing.Color.Transparent;
            this.picMomo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMomo.Image = global::QuanLyBanDongHo.Properties.Resources.momo;
            this.picMomo.Location = new System.Drawing.Point(395, 370);
            this.picMomo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMomo.Name = "picMomo";
            this.picMomo.Size = new System.Drawing.Size(299, 270);
            this.picMomo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMomo.TabIndex = 32;
            this.picMomo.TabStop = false;
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(911, 547);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(100, 23);
            this.txtTien.TabIndex = 34;
            this.txtTien.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(461, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 28);
            this.label6.TabIndex = 36;
            this.label6.Text = "Số Lượng :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(461, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 28);
            this.label5.TabIndex = 37;
            this.label5.Text = "Giá Tiền :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(461, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 28);
            this.label2.TabIndex = 38;
            this.label2.Text = "Tên Đồng Hồ :";
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSL.Location = new System.Drawing.Point(613, 98);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(43, 28);
            this.lblSL.TabIndex = 39;
            this.lblSL.Text = "SL";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.Location = new System.Drawing.Point(613, 145);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(53, 28);
            this.lblGia.TabIndex = 40;
            this.lblGia.Text = "Giá";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(658, 54);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(56, 28);
            this.lblTen.TabIndex = 41;
            this.lblTen.Text = "Tên";
            // 
            // picDongHo
            // 
            this.picDongHo.Location = new System.Drawing.Point(184, 54);
            this.picDongHo.Name = "picDongHo";
            this.picDongHo.Size = new System.Drawing.Size(227, 213);
            this.picDongHo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDongHo.TabIndex = 35;
            this.picDongHo.TabStop = false;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(911, 518);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(100, 23);
            this.txtMa.TabIndex = 42;
            this.txtMa.Visible = false;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(911, 489);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(100, 23);
            this.txtTK.TabIndex = 43;
            this.txtTK.Visible = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(713, 208);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(132, 59);
            this.btnHuy.TabIndex = 27;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmThanhToanMOMO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanDongHo.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(1044, 661);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSL);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.picDongHo);
            this.Controls.Add(this.txtTien);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btTaoQR);
            this.Controls.Add(this.picMomo);
            this.Controls.Add(this.Payment);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmThanhToanMOMO";
            this.Text = "Thanh Toán MOMO";
            this.Load += new System.EventHandler(this.frmThanhToanMOMO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMomo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDongHo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTaoQR;
        private System.Windows.Forms.PictureBox picMomo;
        private System.Windows.Forms.Label Payment;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.PictureBox picDongHo;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Button btnHuy;
    }
}