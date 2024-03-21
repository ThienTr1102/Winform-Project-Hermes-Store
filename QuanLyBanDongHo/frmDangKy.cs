using QuanLyBanDongHo.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using QLBanDongHo;

namespace QuanLyBanDongHo
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        public bool checkaccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool checkEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        Modify mdf = new Modify();

        private void btnDangKyNgay_Click(object sender, EventArgs e)
        {
            {
                string TK = txtTK.Text;
                string MK = txtMK.Text;
                string XN = txtXacNhanMK.Text;
                string Email = txtEmail.Text;
                if (!checkaccount(TK))
                {
                    MessageBox.Show("Vui Lòng Nhập Tên Tài Khoản Dài 6 - 24 Kí Tự , Với Các Kí Tự Chữ Và Số , Kí Tự Hoa Và Kí Tự Thường", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!checkaccount(MK))
                {
                    MessageBox.Show("Vui Lòng Nhập Mật Khẩu Dài 6 - 24 Kí Tự , Với Các Kí Tự Chữ Và Số , Kí Tự Hoa Và Kí Tự Thường", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (XN != MK)
                {
                    MessageBox.Show("Vui Lòng Nhập Mật Chính Xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!checkEmail(Email))
                {
                    MessageBox.Show("Vui Lòng Nhập Đúng Định Dạng Email", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (mdf.Taikhoans("Select * from TaiKhoan where Email = '" + Email + "'").Count != 0)
                {
                    MessageBox.Show("Email Này Đã Được Đăng Ký , Vui Lòng Đăng Ký Email Khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                try
                {
                    string query = "Insert into TaiKhoan values ('" + TK + "','" + MK + "','" + Email + "', '3')";
                    mdf.Command(query);
                    if (MessageBox.Show("Đăng Ký Tài Khoản Thành Công ! Đăng Nhập Ngay ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Hide();
                        frmDangNhap dn = new frmDangNhap();
                        dn.ShowDialog();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tên Tài Khoản Này Đã Được Đăng Ký , Vui Lòng Đăng Ký Tài Khoản Khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTK.Focus();
                }
            }
        }
    }
}
