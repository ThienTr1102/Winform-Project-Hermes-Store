using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using QuanLyBanDongHo.Modules;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Runtime.Remoting.Contexts;

namespace QuanLyBanDongHo
{
    public partial class frmThanhToanMOMO : Form
    {
        public frmThanhToanMOMO(string tk, string dh, string tien, string slm)
        {
            InitializeComponent();
            lblSL.Text = slm;
            txtTien.Text= tien;
            txtMa.Text = dh;
            txtTK.Text = tk;
        }

        private void btTaoQR_Click(object sender, EventArgs e)
        {
            if(btTaoQR.Text == "Tạo mã")
            {
                var qrcode_text = $"2|99|0359258471|TRẦN HẢI ĐĂNG|Tranhaidang01082002@gmail.com|0|0|{txtTien.Text.Trim()}";
                MessageBox.Show("Tạo mã thành công !");
                BarcodeWriter barcodeWriter = new BarcodeWriter();
                EncodingOptions encodingOptions = new EncodingOptions() { Width = 250, Height = 250, Margin = 0, PureBarcode = false };
                encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
                barcodeWriter.Renderer = new BitmapRenderer();
                barcodeWriter.Options = encodingOptions;
                barcodeWriter.Format = BarcodeFormat.QR_CODE;
                Bitmap bitmap = barcodeWriter.Write(qrcode_text);
                Bitmap logo = resizeImage(Properties.Resources.momo, 64, 64) as Bitmap;
                Graphics g = Graphics.FromImage(bitmap);
                g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));
                picMomo.Image = bitmap;
                btTaoQR.Text = "Hoàn Tất";
            }
            else
            {
                QLBanDongHoContextDB context = new QLBanDongHoContextDB();
                SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLBanDongHo;Integrated Security=True");
                conn.Open();
                string sql = "select Max(MaHoaDon) from HoaDon";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int mamax = 1;
                mamax = int.Parse(dr[0].ToString()) + 1;
                HoaDon hd = new HoaDon()
                {
                    MaHoaDon = mamax,
                    TenTK = txtTK.Text,
                    MaDongHo = int.Parse(txtMa.Text),
                    SoLuongMua = int.Parse(lblSL.Text),
                    ThanhTien = double.Parse(txtTien.Text),
                    NgayMua = DateTime.Now
                };
                context.HoaDons.Add(hd);
                context.SaveChanges();
                MessageBox.Show("Mua Sản Phẩm Thành Công!", "Thông báo");
                CapNhat();
                frmHoaDon fhd = new frmHoaDon(txtTK.Text, mamax.ToString() );
                fhd.ShowDialog();
                this.Close();
            }
        }
        private void CapNhat()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLBanDongHo;Integrated Security=True");
            conn.Open();
            string sql = "select SoLuong from DongHo where MaDongHo = '" + txtMa.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int sl = int.Parse(dr[0].ToString()) - int.Parse(lblSL.Text);
            QLBanDongHoContextDB context = new QLBanDongHoContextDB();
            int masp = int.Parse(txtMa.Text);
            DongHo dbUpdate = context.DongHoes.FirstOrDefault(p => p.MaDongHo == masp);
            if (dbUpdate != null)
            {
                dbUpdate.SoLuong = sl;
                context.SaveChanges();
            }
        }
        public Image resizeImage(Image image, int new_height, int new_width)
        {
            Bitmap new_image = new Bitmap(new_width, new_height);
            Graphics g = Graphics.FromImage((Image)new_image);
            g.InterpolationMode = InterpolationMode.High;
            g.DrawImage(image, 0, 0, new_width, new_height);
            return new_image;
        }   
        private void frmThanhToanMOMO_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLBanDongHo;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select HinhAnh, MaDongHo, TenDongHo, DonGia " +
                                                "from DongHo where MaDongHo = '" + txtMa.Text + "'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            lblTen.Text = dt.Rows[0][2].ToString();
            lblGia.Text = dt.Rows[0][3].ToString();
            picDongHo.Image = Image.FromFile(dt.Rows[0][0].ToString());
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTrangChu tc = new frmTrangChu(txtTK.Text);
            tc.ShowDialog();
            this.Close();
        }
    }
}
