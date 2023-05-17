using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnaSinifi.ViewComponents.AnasayfaGaleri
{
    public class AnasayfaGaleri:ViewComponent
    {
        GaleriManager gm = new GaleriManager(new EfGaleriRepository());
        public IViewComponentResult Invoke()
        {
            var values = gm.GetList();
            return View(values);
        }
    }
}
