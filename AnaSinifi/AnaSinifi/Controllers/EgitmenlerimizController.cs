using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnaSinifi.Controllers
{
	public class EgitmenlerimizController : Controller
	{
		EgitmenManager em = new EgitmenManager(new EfEgitmenRepository());

		public IActionResult Index()
		{
			var values = em.GetList();
			return View(values);
		}
	}
}
