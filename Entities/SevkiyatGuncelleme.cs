using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SevkiyatGuncelleme
    {
        public int Id { get; set; }
        public int SevkiyatId { get; set; }
        public int DurumId { get; set; }
        public string Aciklama { get; set; }
        public DateTime IslemTarih { get; set; }
    }
}
