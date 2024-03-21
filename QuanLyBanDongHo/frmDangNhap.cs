using QLBanDongHo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanDongHo
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        Modify mdf = new Modify();
        private void btnDN_Click_1(object sender, EventArgs e)
        {
            string TK = txtTaiKhoan.Text;
            string MK = txtMatKhau.Text;
            if (TK.Trim() == "")
            {
                MessageBox.Show("Vui Lòng Nhập Tên Tài Khoản", "Thông báo");
                return;
            }
            else if (MK.Trim() == "")
            {
                MessageBox.Show("Vui Lòng Nhập Mật Khẩu", "Thông báo");
                return;
            }
            else
            {
                string query = "Select * from TaiKhoan where TenTK = '" + TK + "' and MatKhau = '" + MK + "'";
                if (mdf.Taikhoans(query).Count != 0)
                {
                    MessageBox.Show("Đăng Nhập Thành Công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frmTrangChu tc = new frmTrangChu(TK);
                    tc.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thất Bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lblDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmDangKy dk = new frmDangKy();
            dk.ShowDialog();
        }

        private void lblQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmQuenMK mk = new frmQuenMK();
            mk.ShowDialog();
            this.Close();
        }
    }
}
