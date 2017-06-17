namespace Dapper.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ogrenci")]
    public partial class Ogrenci
    {
        [Key]
        public int ID_OGRENCI { get; set; }

        [Required]
        [StringLength(75)]
        public string ADSOYAD { get; set; }

        [StringLength(100)]
        public string ADRES { get; set; }
    }
}
