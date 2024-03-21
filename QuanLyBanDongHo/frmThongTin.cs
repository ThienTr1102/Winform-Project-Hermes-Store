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

namespace QuanLyBanDongHo
{
    public partial class frmThongTin : Form
    {
        public frmThongTin(string tk)
        {
            InitializeComponent();
            lblTen.Text = tk;
            txtTenTK.Text = tk;
        }

        private void frmThongTin_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLBanDongHo;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select TenTK, MatKhau, Email from Taikhoan where TenTK = '" + txtTenTK.Text + "'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            txtMK.Text = dt.Rows[0][1].ToString();
            txtEmail.Text = dt.Rows[0][2].ToString();
        }

        private void btnSuaLuu_Click(object sender, EventArgs e)
        {
            QLBanDongHoContextDB context = new QLBanDongHoContextDB();
            try
            {
                QuanLyBanDongHo.Modules.TaiKhoan dbUpdate = context.TaiKhoans.FirstOrDefault(p=>p.TenTK== txtTenTK.Text);
                if (dbUpdate != null)
                {
                    dbUpdate.MatKhau = txtMK.Text;
                    dbUpdate.Email = txtEmail.Text;
                    context.SaveChanges();
                    MessageBox.Show("Cập Nhật Thông TinThành Công!", "Thông báo");
                }
                else
                    MessageBox.Show("Không Thể Đồi Thông Tin!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Không Đủ Hoặc Sai Thông Tin", "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTrangChu tc = new frmTrangChu(txtTenTK.Text);
            tc.ShowDialog();
            this.Close();
        }
    }
}
