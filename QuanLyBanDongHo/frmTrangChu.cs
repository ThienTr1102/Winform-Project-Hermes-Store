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

namespace QuanLyBanDongHo
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu(string TenTK)
        {
            InitializeComponent();
            tsmTaiKhoan.Text = TenTK;
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            if(tsmTaiKhoan.Text=="Admin01")
            {
                tsmiThongKe.Visible = true;
                tsmiQLHH.Visible = true;
            }
            else
            {
                tsmiGioHang.Visible = true;
                tsmiDaMua.Visible = true;
            }
            dgvDongHo.EnableHeadersVisualStyles = false;
            dgvDongHo.ColumnHeadersDefaultCellStyle.Font = new Font("century", 15, FontStyle.Bold);
            dgvDongHo.Columns["MaDongHo"].DefaultCellStyle.Font = new Font("century", 13, FontStyle.Bold);
            dgvDongHo.Columns["TenDongHo"].DefaultCellStyle.Font = new Font("century", 13, FontStyle.Bold);
            dgvDongHo.Columns["LoaiDongHo"].DefaultCellStyle.Font = new Font("century", 13, FontStyle.Bold);
            dgvDongHo.Columns["HangDongHo"].DefaultCellStyle.Font = new Font("century", 13, FontStyle.Bold);
            dgvDongHo.Columns["DonGia"].DefaultCellStyle.Font = new Font("century", 13, FontStyle.Bold);
            dgvDongHo.Columns["SoLuong"].DefaultCellStyle.Font = new Font("century", 13, FontStyle.Bold);
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLBanDongHo;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select HinhAnh, MaDongHo, TenDongHo, LoaiDongHo, HangDongHo, SoLuong, DonGia from DongHo", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dt.Columns[0].ColumnMapping = MappingType.Hidden;
            dt.Columns.Add("Pic", Type.GetType("System.Byte[]"));
            foreach (DataRow drow in dt.Rows)
            {

                drow["Pic"] = File.ReadAllBytes(drow["HinhAnh"].ToString());
            }
            dgvDongHo.DataSource = dt;
            dgvDongHo.AllowUserToAddRows = false;
        }
        private void tsmiDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap dn = new frmDangNhap();
            dn.ShowDialog();
            this.Close();
        }

        private void dgvDongHo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDongHo.Rows[e.RowIndex];
                string tk = tsmTaiKhoan.Text.ToString();
                string dh = row.Cells[0].Value.ToString();
                frmDongHo fdh = new frmDongHo(tk, dh);
                fdh.ShowDialog();
                this.Close();
            }
        }

        private void tsmTrangChu_Click(object sender, EventArgs e)
        {
            dgvDongHo.Visible = true;
            tstxtTimKiem.Text = "Tìm Kiếm";
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLBanDongHo;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select HinhAnh, MaDongHo, TenDongHo, LoaiDongHo, HangDongHo, SoLuong, DonGia from DongHo", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dt.Columns[0].ColumnMapping = MappingType.Hidden;
            dt.Columns.Add("Pic", Type.GetType("System.Byte[]"));
            foreach (DataRow drow in dt.Rows)
            {
                drow["Pic"] = File.ReadAllBytes(drow["HinhAnh"].ToString());
            }
            dgvDongHo.DataSource = dt;
            dgvDongHo.AllowUserToAddRows = false;
        }

        private void tstxtTimKiem_Enter(object sender, EventArgs e)
        {
            tstxtTimKiem.SelectAll();
            tstxtTimKiem.Focus();
        }

        private void tstxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLBanDongHo;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select HinhAnh, MaDongHo, TenDongHo, LoaiDongHo, HangDongHo, SoLuong, DonGia " +
                                            "from DongHo " +
                                            "where MaDongHo like N'%" + tstxtTimKiem + "%' or TenDongHo like N'%" + tstxtTimKiem + "%'or LoaiDongHo like N'%" + tstxtTimKiem + "%' or HangDongHo like N'%" + tstxtTimKiem + "%'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dt.Columns[0].ColumnMapping = MappingType.Hidden;
            dt.Columns.Add("Pic", Type.GetType("System.Byte[]"));
            foreach (DataRow drow in dt.Rows)
            {
                drow["Pic"] = File.ReadAllBytes(drow["HinhAnh"].ToString());
            }
            dgvDongHo.DataSource = dt;
            dgvDongHo.AllowUserToAddRows = false;
        }

        private void tsmiGioHang_Click(object sender, EventArgs e)
        {
            string tk = tsmTaiKhoan.Text.ToString();
            frmGioHang gh = new frmGioHang(tk);
            gh.ShowDialog();
        }

        private void tsmiThongTin_Click(object sender, EventArgs e)
        {
            this.Hide();
            string tk = tsmTaiKhoan.Text.ToString();
            frmThongTin gh = new frmThongTin(tk);
            gh.ShowDialog();
            this.Close();
        }

        private void tsmiQLHH_Click(object sender, EventArgs e)
        {
            frmDSSP sp = new frmDSSP();
            sp.ShowDialog();
        }

        private void tsmiDaMua_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLichSuDonHang ls = new frmLichSuDonHang(tsmTaiKhoan.Text);
            ls.ShowDialog();
            this.Close();
        }
    }
}