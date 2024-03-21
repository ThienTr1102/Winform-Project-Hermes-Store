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
    public partial class frmLichSuDonHang : Form
    {
        public frmLichSuDonHang(string tk)
        {
            InitializeComponent();
            txtTK.Text = tk;
        }

        private void dgvLS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLS.SelectedRows.Count > 0)
            {
                string hd = dgvLS.SelectedRows[0].Cells[0].Value.ToString();
                if (e.RowIndex >= 0)
                {
                    this.Hide();
                    frmHoaDon fhd = new frmHoaDon(txtTK.Text, hd);
                    fhd.ShowDialog();
                    this.Close();
                }
            }

        }

        private void frmLichSuDonHang_Load(object sender, EventArgs e)
        {
            dgvLS.EnableHeadersVisualStyles = false;
            dgvLS.ColumnHeadersDefaultCellStyle.Font = new Font("century", 15, FontStyle.Bold);
            dgvLS.Columns["SoLuongMua"].DefaultCellStyle.Font = new Font("century", 13, FontStyle.Bold);
            dgvLS.Columns["TenDongHo"].DefaultCellStyle.Font = new Font("century", 13, FontStyle.Bold);
            dgvLS.Columns["ThanhTien"].DefaultCellStyle.Font = new Font("century", 13, FontStyle.Bold);
            dgvLS.Columns["DonGia"].DefaultCellStyle.Font = new Font("century", 13, FontStyle.Bold);
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLBanDongHo;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select MaHoaDon, TenDongHo, SoLuongMua, DonGia, ThanhTien " +
                                            "from HoaDon, DongHo " +
                                            "where TenTK = '" + txtTK.Text + "' and HoaDon.MaDongHo = DongHo.MaDongHo", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dgvLS.DataSource = dt;
            dgvLS.AllowUserToAddRows = false;
        }
    }
}
