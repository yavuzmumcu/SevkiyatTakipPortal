using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class LogView
    {
        public int Id { get; set; }

        public int SevkiyatId { get; set; }
        public string MusteriAd{ get; set; }
        public string AracAd { get; set; }
        public string YuklemeTipAd { get; set; }
        public int Adet { get; set; }
        public string PlakaNo { get; set; }
        public string LojistikFirma { get; set; }
        public string SiparisNo { get; set; }
        public string Aciklama { get; set; }
        public DateTime TerminTarih { get; set; }
        public DateTime IslemTarih { get; set; }
        public string Islem { get; set; }
        public string DurumAd { get; set; }
    }
}
