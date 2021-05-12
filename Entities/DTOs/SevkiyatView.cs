using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class SevkiyatView
    {
        public int SevkiyatId { get; set; }
        public DateTime TerminTarih { get; set; }
        public string SiparisNo { get; set; }
        public string MusteriAd { get; set; }
        public string Ulke { get; set; }
        public int Adet { get; set; }
        public string SevkAraci { get; set; }
        public string PlakaNo { get; set; }
        
        public string YuklemeTip { get; set; }
        public string LojistikFirma { get; set; }

        public string Aciklama { get; set; }
        public string Durum { get; set; }
       
        

    }
}
