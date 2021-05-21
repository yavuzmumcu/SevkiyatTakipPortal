using Business.Concrete;
using DataAccess.Concrete.AdoNET;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUI_Net.Controllers
{
    public class HomeController : Controller
    {
        SevkiyatManager sevkiyatManager = new SevkiyatManager(new AdSevkiyatDal());
        
        public ActionResult Index()
        {

            int HaftaNo(DateTime Tarih)
            {
                DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(Tarih);
                if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
                {
                    Tarih = Tarih.AddDays(3);
                }
                return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(Tarih, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            }
            var result = sevkiyatManager.GunlukSevkiyatlariListele(DateTime.Now.Year, HaftaNo(DateTime.Now), (int)DateTime.Now.DayOfWeek);
            return View(result);
        }

        public ActionResult Haftalik()
        {

            int HaftaNo(DateTime Tarih)
            {
                DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(Tarih);
                if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
                {
                    Tarih = Tarih.AddDays(3);
                }
                return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(Tarih, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            }
            var result = sevkiyatManager.HaftalikSevkiyatlar(DateTime.Now.Year,HaftaNo(DateTime.Now));
            return View(result);
        }

        [HttpGet]
        public ActionResult Ara(int haftaNo,int yil,int gun)
        {

            int HaftaNo(DateTime Tarih)
            {
                DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(Tarih);
                if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
                {
                    Tarih = Tarih.AddDays(3);
                }
                return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(Tarih, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            }
            var result = sevkiyatManager.GunlukSevkiyatlariListele(yil, haftaNo, gun);
            return View(result);
        }
    }

       
    
}