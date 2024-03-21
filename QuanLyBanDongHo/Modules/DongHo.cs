namespace QuanLyBanDongHo.Modules
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DongHo")]
    public partial class DongHo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDongHo { get; set; }

        [Required]
        [StringLength(200)]
        public string TenDongHo { get; set; }

        [Required]
        [StringLength(200)]
        public string LoaiDongHo { get; set; }

        [Required]
        [StringLength(200)]
        public string HangDongHo { get; set; }

        public int SoLuong { get; set; }

        public double DonGia { get; set; }

        [Required]
        public string HinhAnh { get; set; }
    }
}
