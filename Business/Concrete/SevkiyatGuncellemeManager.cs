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
    
    
    public class SevkiyatGuncellemeManager : ISevkiyatGuncellemeService
    {
        ISevkiyatGuncellemeDal _sevkiyatGuncellemeDal;

        public SevkiyatGuncellemeManager(ISevkiyatGuncellemeDal sevkiyatGuncellemeDal)
        {
            _sevkiyatGuncellemeDal = sevkiyatGuncellemeDal;
        }

        public int Ekle(SevkiyatGuncelleme sevkiyatGuncelleme)
        {
            return _sevkiyatGuncellemeDal.Ekle(sevkiyatGuncelleme);
        }

        public List<SevkiyatGuncellemeView> Listele()
        {
            return _sevkiyatGuncellemeDal.Listele();
        }

        public List<SevkiyatGuncellemeView> ListeleBySevkiyatId(int sevkiyatId)
        {
            return _sevkiyatGuncellemeDal.ListeleBySevkiyatId(sevkiyatId);
        }
    }
}
