using QuanLyBanDongHo.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace QuanLyBanDongHo
{
    public partial class frmDSSP : Form
    {
        public frmDSSP()
        {
            InitializeComponent();
        }

        private void frmDSSP_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLBanDongHo;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select HinhAnh, MaDongHo, TenDongHo, LoaiDongHo, HangDongHo, SoLuong, DonGia from DongHo", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dt.Columns.Add("Pic", Type.GetType("System.Byte[]"));
            foreach (DataRow drow in dt.Rows)
            {

                drow["Pic"] = File.ReadAllBytes(drow["HinhAnh"].ToString());
            }
            dgvDongHo.DataSource = dt;
            dgvDongHo.AllowUserToAddRows = false;
        }

        private void btnAnhSP_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "PNG File| *.png|JPG File| *.jpg";
            if (op.ShowDialog() == DialogResult.OK)
            {
                picSP.Image = Image.FromFile(op.FileName);
                txtPic.Text = op.FileName.ToString();
            }
        }
        private void dgvLoad()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLBanDongHo;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select HinhAnh, MaDongHo, TenDongHo, LoaiDongHo, HangDongHo, SoLuong, DonGia from DongHo", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dt.Columns.Add("Pic", Type.GetType("System.Byte[]"));
            foreach (DataRow drow in dt.Rows)
            {

                drow["Pic"] = File.ReadAllBytes(drow["HinhAnh"].ToString());
            }
            dgvDongHo.DataSource = dt;
            dgvDongHo.AllowUserToAddRows = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            QLBanDongHoContextDB context = new QLBanDongHoContextDB();
            try{
                DongHo dh = new DongHo()
                {
                    MaDongHo = int.Parse(txtMaSP.Text),
                    TenDongHo = txtTenSP.Text,
                    LoaiDongHo = txtLoaiSP.Text,
                    HangDongHo = txtTH.Text,
                    SoLuong = int.Parse(txtSL.Text),
                    DonGia = double.Parse(txtGia.Text),
                    HinhAnh = txtPic.Text
                };
                context.DongHoes.Add(dh);
                context.SaveChanges();
                MessageBox.Show("Thêm Sản Phẩm Thành Công!", "Thông báo");
                dgvLoad();
            }
            catch 
            {
                MessageBox.Show("Sản Phẩm Đã Tồn Tại!", "Thông báo");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            QLBanDongHoContextDB context = new QLBanDongHoContextDB();
            try
            {
                int masp = int.Parse(txtMaSP.Text);
                DongHo dbUpdate = context.DongHoes.FirstOrDefault(p => p.MaDongHo == masp);
                if (dbUpdate != null)
                {
                    dbUpdate.TenDongHo = txtTenSP.Text;
                    dbUpdate.LoaiDongHo = txtLoaiSP.Text;
                    dbUpdate.HangDongHo = txtTH.Text;
                    dbUpdate.SoLuong = int.Parse(txtSL.Text);
                    dbUpdate.DonGia = double.Parse(txtGia.Text);
                    dbUpdate.HinhAnh = txtPic.Text;
                    context.SaveChanges();
                    MessageBox.Show("Cập Nhật Sản Phẩm Thành Công!", "Thông báo");
                    dgvLoad();
                }
                else
                    MessageBox.Show("Không Tìm Thấy Sản Phẩm", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Không Đủ Hoặc Sai Thông Tin", "Thông báo");
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtLoaiSP.Text = "";
            txtTH.Text = "";
            txtSL.Text = "";
            txtGia.Text = "";
            picSP.Image = null;
            txtPic.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            QLBanDongHoContextDB context = new QLBanDongHoContextDB();
            try
            {
                int masp = int.Parse(txtMaSP.Text);
                DongHo dbDelete = context.DongHoes.FirstOrDefault(p => p.MaDongHo == masp );
                if (dbDelete != null)
                {
                    context.DongHoes.Remove(dbDelete);
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

        public System.Windows.Forms.DataGridViewSelectedRowCollection SelectedRows { get; }
        private void dgvDongHo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDongHo.SelectedRows.Count > 0)
            {
                txtMaSP.Text = dgvDongHo.SelectedRows[0].Cells[1].Value.ToString();
                txtTenSP.Text = dgvDongHo.SelectedRows[0].Cells[2].Value.ToString();
                txtLoaiSP.Text = dgvDongHo.SelectedRows[0].Cells[3].Value.ToString();
                txtTH.Text = dgvDongHo.SelectedRows[0].Cells[4].Value.ToString();
                txtSL.Text = dgvDongHo.SelectedRows[0].Cells[5].Value.ToString();
                txtGia.Text = dgvDongHo.SelectedRows[0].Cells[6].Value.ToString();
                picSP.Image = Image.FromFile(dgvDongHo.SelectedRows[0].Cells[0].Value.ToString());
                txtPic.Text = dgvDongHo.SelectedRows[0].Cells[0].Value.ToString();
            }    
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
