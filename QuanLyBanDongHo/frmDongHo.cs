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
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Image = System.Drawing.Image;

namespace QuanLyBanDongHo
{
    public partial class frmDongHo : Form
    {
        public frmDongHo(string tk, string dh)
        {
            InitializeComponent();
            lblMa.Text = dh;
            txtTK.Text = tk;
        }
  
        private void frmDongHo_Load(object sender, EventArgs e)
        {
            DongHo();
            txtSL.Text = "0";
        }
        private void DongHo()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLBanDongHo;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select HinhAnh, MaDongHo, TenDongHo, LoaiDongHo, HangDongHo, SoLuong, DonGia " +
                                            "from DongHo where MaDongHo = '" + lblMa.Text + "'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            lblTen.Text = dt.Rows[0][2].ToString();
            lblLoai.Text = dt.Rows[0][3].ToString();
            lblHang.Text = dt.Rows[0][4].ToString();
            lblSL.Text = dt.Rows[0][5].ToString();
            lblGia.Text = dt.Rows[0][6].ToString();
            picDongHo.Image = Image.FromFile(dt.Rows[0][0].ToString());
        }

        private void btnMua_Click(object sender, EventArgs e)
        {
            int sl = int.Parse(lblSL.Text);
            if(sl == 0)
            {
                MessageBox.Show("Đã Hết Hàng!", "Thông báo");
            }
            else
            {
                frmThanhToanMOMO tt = new frmThanhToanMOMO(txtTK.Text, lblMa.Text, txtTien.Text, txtSL.Text);
                tt.ShowDialog();
                this.Close();
            }    
        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {
            if(txtTK.Text == "Admin01")
            {
                MessageBox.Show("Chủ Cửa Hàng Mà Đi Mua Hàng Là Sao? :3", "Thông báo");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLBanDongHo;Integrated Security=True");
                conn.Open();
                string sql = "select Max(MaGioHang) from GioHang";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int mamax = int.Parse(dr[0].ToString()) + 1;

                QLBanDongHoContextDB context = new QLBanDongHoContextDB();
                GioHang gh = new GioHang()
                {
                    MaGioHang = mamax,
                    TenTK = txtTK.Text,
                    MaDongHo = int.Parse(lblMa.Text),
                    SoLuongMua = int.Parse(txtSL.Text),
                    TongTien = double.Parse(txtTien.Text)
                };
                context.GioHangs.Add(gh);
                context.SaveChanges();
                MessageBox.Show("Thêm Vào Giỏ Hàng Thành Công!", "Thông báo");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTrangChu tc = new frmTrangChu(txtTK.Text);
            tc.ShowDialog();
            this.Close();
        }


        private void btnTru_Click(object sender, EventArgs e)
        {
            int number = 0;
            if(int.TryParse(txtSL.Text.Trim(), out number))
            {
                
                txtSL.Text = (int.Parse(txtSL.Text) - 1).ToString();
            }
            else
            {
                txtSL.Text = "0";
            }
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int number = 0;
            if (int.TryParse(txtSL.Text.Trim(), out number))
            {
                txtSL.Text = (int.Parse(txtSL.Text) + 1).ToString();
            }
            else
            {
                txtSL.Text = "1";
            }
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            int number = 0;
            
            if (int.TryParse(txtSL.Text.Trim(), out number))
            {
                if (int.Parse(txtSL.Text) == 0)
                {
                    btnTru.Enabled = false;
                    btnMua.Enabled = false;
                    btnGioHang.Enabled = false;
                }
                else
                {
                    btnTru.Enabled = true;
                    btnGioHang.Enabled = true;
                    btnMua.Enabled = true;
                }
                SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLBanDongHo;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("select SoLuong, DonGia " +
                                                "from DongHo where MaDongHo = '" + lblMa.Text + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int max = int.Parse(dr[0].ToString());
                txtTien.Text = (double.Parse(txtSL.Text) * double.Parse(dr[1].ToString())).ToString();
                if (int.Parse(txtSL.Text) == max)
                {
                    btnCong.Enabled = false;
                }
                else
                {
                    btnCong.Enabled = true;
                }
            }
        }
    }
}
