using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using QLBanDongHo;

namespace QuanLyBanDongHo
{
    public partial class frmQuenMK : Form
    {
        public frmQuenMK()
        {
            InitializeComponent();
            lblKQ.Text = "";
        }
        public bool checkEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        Modify mdf = new Modify();
        private void btnLayLaiMK_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text;
            if (Email.Trim() == "")
            {
                MessageBox.Show("Vui Lòng Nhập Email Đăng Ký !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!checkEmail(Email))
            {
                MessageBox.Show("Vui Lòng Nhập Đúng Định Dạng Email", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string query = "Select * from TaiKhoan where Email = '" + Email + "'";
                if (mdf.Taikhoans(query).Count != 0)
                {
                    lblKQ.ForeColor = Color.Blue;
                    lblKQ.Text = "Mật Khẩu : " + mdf.Taikhoans(query)[0].Matkhau;
                    if (MessageBox.Show("Lấy Lại Mật Khẩu Thành Công ! Đăng Nhập Ngay ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Hide();
                        frmDangNhap dn = new frmDangNhap();
                        dn.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    lblKQ.ForeColor = Color.Red;
                    lblKQ.Text = "Email Này Chưa Được Đăng Ký";
                }
            }
        }
    }
}
