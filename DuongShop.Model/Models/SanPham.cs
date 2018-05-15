namespace DuongShop.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(500)]
        public string TenSanPham { get; set; }

        public int DanhMucID { get; set; }

        public DateTime NgayTao { get; set; }

        [Required]
        [StringLength(50)]
        public string NguoiTao { get; set; }

        public DateTime NgayUpdate { get; set; }

        [Required]
        [StringLength(50)]
        public string NguoiUpdate { get; set; }

        public bool TrangThai { get; set; }

        [StringLength(500)]
        public string image { get; set; }

        public string GhiChu { get; set; }

        public bool? SPHOT { get; set; }

        public int? ViewCount { get; set; }

        [Column(TypeName = "xml")]
        public string MoreImage { get; set; }

        public string MoTa { get; set; }

        public string NoiDung { get; set; }

        public int Gia { get; set; }

        public int GiaKhuyenMai { get; set; }

        public int BaoHanh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        public virtual DanhMucSanPham DanhMucSanPham { get; set; }
    }
}
