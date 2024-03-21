namespace QuanLyBanDongHo.Modules
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GioHang")]
    public partial class GioHang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaGioHang { get; set; }

        [Required]
        [StringLength(50)]
        public string TenTK { get; set; }

        public int MaDongHo { get; set; }

        public int SoLuongMua { get; set; }

        public double TongTien { get; set; }
    }
}
