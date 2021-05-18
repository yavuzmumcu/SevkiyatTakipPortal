using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class SevkiyatGuncellemeView
    {
        public int Id { get; set; }
        public string SiparisNo { get; set; }
        public string MusteriAd { get; set; }
        public string Aciklama { get; set; }
        public string Durum { get; set; }
        public DateTime IslemTarih { get; set; }
    }
}
