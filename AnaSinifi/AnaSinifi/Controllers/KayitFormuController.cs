using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AnaSinifi.Controllers
{
    public class KayitFormuController : Controller
    {
        KayitformManager kfm = new KayitformManager(new EfKayitformRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult KayitformEkle(KayitForm p)
        {
            kfm.TAdd(p);
            return RedirectToAction("Index", "Anasayfa");
        }
      
    }
}
