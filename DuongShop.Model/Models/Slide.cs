namespace DuongShop.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Slide")]
    public partial class Slide
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(500)]
        public string Image { get; set; }

        [Required]
        [StringLength(500)]
        public string url { get; set; }

        public int? STT { get; set; }

        public bool Trangthai { get; set; }
    }
}
