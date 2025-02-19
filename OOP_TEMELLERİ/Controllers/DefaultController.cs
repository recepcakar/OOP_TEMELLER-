using Microsoft.AspNetCore.Mvc;
using OOP_TEMELLERİ.Ornekler;

namespace OOP_TEMELLERİ.Controllers
{
    public class DefaultController : Controller
    {

        void messeage()
        {
            ViewBag.m1 = "I am writing";
            ViewBag.m2 = "I am Wrote";
        }
        int sum()
        {
            int a = 5;
            int b = 20;
            int c = a+b;
            return c;
        }
        int perimeter()
        {
            int a = 10;
            int b = 20;
            int c = (a+b)*2;
            return c;
        }
        public IActionResult Index()
        {
            messeage();
            return View();
        }
        public IActionResult Product() 
        {
            ViewBag.s1=sum();
            ViewBag.p1=perimeter();
            return View();
        }
        public IActionResult Deneme()
        {
            Sehirler sehirler = new Sehirler();
            sehirler.SehirName = "İstanbul";
            sehirler.SehirId = 34;
            sehirler.SehirNufus = 16000;
            sehirler.Color1 = "mavi";
            sehirler.Color2 = "sarı";

            ViewBag.Sehir1 =sehirler.SehirName ;
            ViewBag.Sehir2=sehirler.SehirId ;
            ViewBag.Sehir3=sehirler.SehirNufus ;
            ViewBag.sehir4=sehirler.Color1 ;
            ViewBag.sehir5=sehirler.Color2 ;
                return View();
        }
    }
}
