using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnaSinifi.Controllers
{
	public class DuyurularController : Controller
	{
        DuyuruManager dym = new DuyuruManager(new EfDuyuruRepository());

        public IActionResult Index()
		{
			var values=dym.GetList();
			return View(values);
		}
	}
}
