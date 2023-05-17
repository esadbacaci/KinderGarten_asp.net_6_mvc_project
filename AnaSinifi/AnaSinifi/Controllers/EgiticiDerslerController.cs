using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnaSinifi.Controllers
{
	public class EgiticiDerslerController : Controller
	{
		DersManager dm = new DersManager(new EfDersRepository());
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Detay(int id)
		{
			ViewBag.i = id;
			var values = dm.GetDersById(id);
			return View(values);
			
		}
	}
}
