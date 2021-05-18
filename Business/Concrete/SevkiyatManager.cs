using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SevkiyatManager : ISevkiyatService
    {
        ISevkiyatDal _sevkiyatDal;

        public SevkiyatManager(ISevkiyatDal sevkiyatDal)
        {
            _sevkiyatDal = sevkiyatDal;
        }

        public int DurumGuncelle(Sevkiyat sevkiyat)
        {
            return _sevkiyatDal.DurumGuncelle(sevkiyat);
        }

        public int Ekle(Sevkiyat sevkiyat )
        {
            return _sevkiyatDal.Ekle(sevkiyat);
        }

        public int Guncelle(Sevkiyat sevkiyat)
        {
            return _sevkiyatDal.Guncelle(sevkiyat);
        }

        public List<SevkiyatView> GunlukSevkiyatlariListele(int yil, int hafta, int gun)
        {
            return _sevkiyatDal.GunlukSevkiyatlar(yil, hafta, gun);
        }

        public List<SevkiyatView> HaftalikSevkiyatlar(int yil, int hafta)
        {
            return _sevkiyatDal.HaftalikSevkiyatlar(yil, hafta);
        }

        public Sevkiyat SevkiyatDeger(int sevkiyatId)
        {
            return _sevkiyatDal.SevkiyatDeger(sevkiyatId);
        }

        public SevkiyatView SevkiyatViewDeger(int sevkiyatId)
        {
            return _sevkiyatDal.SevkiyatViewDeger(sevkiyatId);
        }

        public int Sil(Sevkiyat sevkiyat)
        {
            return _sevkiyatDal.Sil(sevkiyat);
        }
    }
}
