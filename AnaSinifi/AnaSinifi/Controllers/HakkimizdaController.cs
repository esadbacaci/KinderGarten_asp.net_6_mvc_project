using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnaSinifi.Controllers
{
	public class HakkimizdaController : Controller
    {
        HakkimizdaManager hm = new HakkimizdaManager(new EfHakkimizdaRepository());

        public IActionResult Index()
		{
            var values = hm.GetList();
            return View(values);
        }
	}
}
