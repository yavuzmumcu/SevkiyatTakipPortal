using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ISevkiyatDal
    {
         int Ekle(Sevkiyat sevkiyat);

        List<SevkiyatView> GunlukSevkiyatlar(int yil, int hafta, int gun);

        List<SevkiyatView> HaftalikSevkiyatlar(int yil, int hafta);

        Sevkiyat SevkiyatDeger(int sevkiyatId);

        int Guncelle(Sevkiyat sevkiyat);

        int Sil(Sevkiyat sevkiyat);
    }
}
