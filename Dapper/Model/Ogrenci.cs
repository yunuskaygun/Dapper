using System.Collections.Generic;

namespace Dapper.Model
{
    public class Ogrenci
    {
        public int ID_OGRENCI { get; set; }
        public string ADSOYAD { get; set; }
        public string ADRES { get; set; }
        public List<Evrak> EvrakListesi { get; set; }
        public List<Satis> SatisListesi { get; set; }
    }
}
