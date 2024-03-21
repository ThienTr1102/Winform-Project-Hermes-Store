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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon(string tk, string hd)
        {
            InitializeComponent();
            lblTK.Text = tk;
            txtMaHD.Text = hd;
        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTrangChu tc = new frmTrangChu(lblTK.Text);
            tc.ShowDialog();
            this.Close();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLBanDongHo;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select HinhAnh, TenDongHo, SoLuongMua, DonGia, ThanhTien " +
                                            "from HoaDon, DongHo " +
                                            "where MaHoaDon = '" + txtMaHD.Text + "' and DongHo.MaDongHo = HoaDon.MaDongHo", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            picDongHo.Image = Image.FromFile(dt.Rows[0][0].ToString());
            lblTen.Text = dt.Rows[0][1].ToString();
            lblSL.Text = dt.Rows[0][2].ToString();
            lblDonGia.Text = dt.Rows[0][3].ToString();
            lblGia.Text = dt.Rows[0][4].ToString();
        }
    }
}
