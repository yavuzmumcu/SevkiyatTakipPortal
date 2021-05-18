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
    public class DurumManager : IDurumService
    {
        IDurumDal _durumDal;

        public DurumManager(IDurumDal durumDal)
        {
            _durumDal = durumDal;
        }

        public List<Durum> Listele()
        {
            return _durumDal.Listele();
        }
    }
}
