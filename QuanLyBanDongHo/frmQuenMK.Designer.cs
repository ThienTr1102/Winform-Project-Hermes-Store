namespace QuanLyBanDongHo
{
    partial class frmQuenMK
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
            this.btnLayLaiMK = new System.Windows.Forms.Button();
            this.lblKQ = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grbDK = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grbDK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLayLaiMK
            // 
            this.btnLayLaiMK.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLayLaiMK.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLayLaiMK.Location = new System.Drawing.Point(410, 171);
            this.btnLayLaiMK.Name = "btnLayLaiMK";
            this.btnLayLaiMK.Size = new System.Drawing.Size(242, 65);
            this.btnLayLaiMK.TabIndex = 5;
            this.btnLayLaiMK.Text = "Lấy Lại Mật Khẩu";
            this.btnLayLaiMK.UseVisualStyleBackColor = false;
            this.btnLayLaiMK.Click += new System.EventHandler(this.btnLayLaiMK_Click);
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.Location = new System.Drawing.Point(215, 136);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(118, 29);
            this.lblKQ.TabIndex = 0;
            this.lblKQ.Text = "Kết Quả";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(365, 73);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(339, 36);
            this.txtEmail.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // grbDK
            // 
            this.grbDK.BackColor = System.Drawing.Color.Gainsboro;
            this.grbDK.Controls.Add(this.btnLayLaiMK);
            this.grbDK.Controls.Add(this.lblKQ);
            this.grbDK.Controls.Add(this.txtEmail);
            this.grbDK.Controls.Add(this.label4);
            this.grbDK.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDK.Location = new System.Drawing.Point(-1, 283);
            this.grbDK.Name = "grbDK";
            this.grbDK.Size = new System.Drawing.Size(1000, 331);
            this.grbDK.TabIndex = 9;
            this.grbDK.TabStop = false;
            this.grbDK.Text = "QUÊN MẬT KHẨU";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::QuanLyBanDongHo.Properties.Resources.Dky;
            this.pictureBox2.Location = new System.Drawing.Point(212, -11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(569, 293);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // frmQuenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 612);
            this.Controls.Add(this.grbDK);
            this.Controls.Add(this.pictureBox2);
            this.Name = "frmQuenMK";
            this.Text = "frmQuenMK";
            this.grbDK.ResumeLayout(false);
            this.grbDK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLayLaiMK;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbDK;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}