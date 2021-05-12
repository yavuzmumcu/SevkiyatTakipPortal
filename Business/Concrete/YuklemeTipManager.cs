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
    public class YuklemeTipManager:IYuklemeTipService
    {
        IYuklemeTipDal _yuklemeTipDal;

        public YuklemeTipManager(IYuklemeTipDal yuklemeTipDal)
        {
            _yuklemeTipDal = yuklemeTipDal;
        }

        public List<YuklemeTip> YuklemeTipListele()
        {
            return _yuklemeTipDal.YuklemeTipListele();
        }
    }
}
