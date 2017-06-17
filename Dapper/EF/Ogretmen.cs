namespace Dapper.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ogretmen
    {
        [Key]
        public int ID_OGRETMEN { get; set; }

        [StringLength(75)]
        public string ADSOYAD { get; set; }
    }
}
