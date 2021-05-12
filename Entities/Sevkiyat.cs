using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Sevkiyat
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public int AracId { get; set; }
        public int YuklemeTipId { get; set; }
        public int Adet { get; set; }
        public string PlakaNo { get; set; }
        public string LojistikFirma { get; set; }
        public string SiparisNo { get; set; }
        public string Aciklama { get; set; }
        public DateTime TerminTarih { get; set; }
        public DateTime IslemTarih { get; set; }
        public int DurumId { get; set; }
    }
}
