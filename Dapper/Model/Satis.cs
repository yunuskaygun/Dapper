using System.Collections.Generic;

namespace Dapper.Model
{
    public class Satis
    {
        public int ID_SATIS { get; set; }
        public int ID_OGRENCI { get; set; }
        public decimal TUTAR { get; set; }
        public List<OdemePlan> OdemePlanListesi { get; set; }
    }
}
