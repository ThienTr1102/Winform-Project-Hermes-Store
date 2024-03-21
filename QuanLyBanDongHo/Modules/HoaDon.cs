namespace QuanLyBanDongHo.Modules
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHoaDon { get; set; }

        [Required]
        [StringLength(50)]
        public string TenTK { get; set; }

        public int MaDongHo { get; set; }

        public int SoLuongMua { get; set; }

        public double ThanhTien { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayMua { get; set; }
    }
}
