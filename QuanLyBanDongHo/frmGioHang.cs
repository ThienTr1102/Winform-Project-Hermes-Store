using QuanLyBanDongHo.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyBanDongHo
{
    public partial class frmGioHang : Form
    {
        public frmGioHang(string tk)
        {
            InitializeComponent();
            txtTK.Text = tk;
        }

        private void frmGioHang_Load(object sender, EventArgs e)
        {
            dgvGioHang.EnableHeadersVisualStyles = false;
            dgvGioHang.ColumnHeadersDefaultCellStyle.Font = new Font("century", 15, FontStyle.Bold);
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLBanDongHo;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("select MaGioHang, TenDongHo, DonGia, SoLuongMua, TongTien, GioHang.MaDongHo " +
                                            "from DongHo, GioHang " +
                                            "where TenTK = '" + txtTK.Text + "' and DongHo.MaDongHo = GioHang.MaDongHo", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dgvGioHang.DataSource = dt;
            dgvGioHang.AllowUserToAddRows = false;
        }
        private void btnXoaGioHang_Click(object sender, EventArgs e)
        {
            QLBanDongHoContextDB context = new QLBanDongHoContextDB();
            try
            {
                int masp = int.Parse(txtMaGH.Text);
                GioHang dbDelete = context.GioHangs.FirstOrDefault(p => p.MaGioHang == masp);
                if (dbDelete != null)
                {
                    context.GioHangs.Remove(dbDelete);
                    context.SaveChanges();
                    MessageBox.Show("Xóa Sản Phẩm Thành Công!", "Thông báo");
                    dgvLoad();
                }
                else
                    MessageBox.Show("Không Tìm Thấy Sản Phẩm", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Không Thể Xóa Sản Phẩm", "Thông báo");
            }
        }
        string MaDH;
        string Tien;
        string SL;
        private void dgvGioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGioHang.SelectedRows.Count > 0)
            {
                txtMaGH.Text = dgvGioHang.SelectedRows[0].Cells[0].Value.ToString();
                MaDH = dgvGioHang.SelectedRows[0].Cells[5].Value.ToString();
                Tien = dgvGioHang.SelectedRows[0].Cells[4].Value.ToString();
                SL = dgvGioHang.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            
            frmThanhToanMOMO tt = new frmThanhToanMOMO(txtTK.Text, MaDH, Tien, SL);
            tt.ShowDialog();
            this.Close();
        }
        private void dgvLoad()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLBanDongHo;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("select MaGioHang, TenDongHo, DonGia, SoLuongMua, TongTien, GioHang.MaDongHo " +
                                            "from DongHo, GioHang " +
                                            "where TenTK = '" + txtTK.Text + "' and DongHo.MaDongHo = GioHang.MaDongHo", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dgvGioHang.DataSource = dt;
            dgvGioHang.AllowUserToAddRows = false;
        }
    }
}
