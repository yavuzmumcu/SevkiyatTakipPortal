using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.AdoNET;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCUI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace MVCUI.Controllers
{
    public class HomeController : Controller
    {
        
        SevkiyatManager sevkiyatManager = new SevkiyatManager(new AdSevkiyatDal());

        
        
        public IActionResult Index()
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
            var result= sevkiyatManager.GunlukSevkiyatlariListele(DateTime.Now.Year, HaftaNo(DateTime.Now), (int)DateTime.Now.DayOfWeek);
            return View(result);
        }

        
    }
}
