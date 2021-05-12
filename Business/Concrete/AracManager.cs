using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AracManager : IAracService
    {
        IAracDal _aracDal;

        public AracManager(IAracDal aracDal)
        {
            _aracDal = aracDal;
        }

        public List<Arac> SevkAracListele()
        {
           return _aracDal.SevkAracListele();
        }
    }
}
