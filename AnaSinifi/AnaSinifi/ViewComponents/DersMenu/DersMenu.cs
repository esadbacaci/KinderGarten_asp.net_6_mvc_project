using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnaSinifi.ViewComponents.DersMenu
{
    public class DersMenu:ViewComponent
    {
        DersManager dm = new DersManager(new EfDersRepository());
        public IViewComponentResult Invoke()
        {
            var values = dm.GetList();
            return View(values);
        }
    }
}
