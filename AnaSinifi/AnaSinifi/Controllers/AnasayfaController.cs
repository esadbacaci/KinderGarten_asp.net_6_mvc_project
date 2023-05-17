using AnaSinifi.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnaSinifi.Controllers
{
    public class AnasayfaController : Controller
	{
		SliderManager sm = new SliderManager(new EfSliderRepository());
		YtLinkManager ylm = new YtLinkManager(new EfYtLinkRepositories());
    
		public IActionResult Index()
		{
            var link = ylm.GetList();
            var slider = sm.GetList();
            var viewmodel = new AnasayfaModel
            {
                Sliders = slider,
                YtLinks = link
            };
            return View(viewmodel);

        }
    }
}
