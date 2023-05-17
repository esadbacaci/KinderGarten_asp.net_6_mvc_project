using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnaSinifi.Controllers
{
    public class GaleriController : Controller
    {
        GaleriManager gm = new GaleriManager(new EfGaleriRepository());
        public IActionResult Index()
        {
            var values = gm.GetList();
            return View(values);
        }
    }
}
