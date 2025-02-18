using Microsoft.AspNetCore.Mvc;

namespace OOP_TEMELLERİ.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
