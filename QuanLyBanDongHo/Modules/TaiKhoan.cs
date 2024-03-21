namespace QuanLyBanDongHo.Modules
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [StringLength(50)]
        public string TenTK { get; set; }

        [Required]
        [StringLength(16)]
        public string MatKhau { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        public int LoaiTK { get; set; }
    }
}
