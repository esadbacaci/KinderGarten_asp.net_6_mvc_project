using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace AnaSinifi.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        DersManager dm = new DersManager(new EfDersRepository());
        DuyuruManager dym = new DuyuruManager(new EfDuyuruRepository());
        SliderManager sm = new SliderManager(new EfSliderRepository());
        GaleriManager gm = new GaleriManager(new EfGaleriRepository());
        EgitmenManager em = new EgitmenManager(new EfEgitmenRepository());
        KayitformManager kfm = new KayitformManager(new EfKayitformRepository());
        HakkimizdaManager  hm=new HakkimizdaManager(new EfHakkimizdaRepository());
        YtLinkManager  ylm=new YtLinkManager(new EfYtLinkRepositories());

        Context c = new Context();
        public IActionResult Index()
        {
            ViewBag.ders = c.Dersler.Count().ToString();
            ViewBag.slider = c.Sliders.Count().ToString();
            ViewBag.galeri = c.Galeris.Count().ToString();
            ViewBag.duyuru = c.Duyurulars.Count().ToString();
            ViewBag.kayit = c.KayitForms.Count().ToString();
            var values = dym.GetList();
            return View(values);
        }
        [AllowAnonymous]
        public IActionResult SiteHaritasi()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        public async Task<IActionResult> Login(Admin p)
        {
            Context c = new Context();
            var datavalue = c.Admins.FirstOrDefault(x => x.AdminName == p.AdminName && x.AdminPassword == p.AdminPassword);
            if (datavalue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.AdminName)
                };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Admin");
        }

        [HttpGet]
        public IActionResult EgiticiDersler()
        {
            var values = dm.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult EgiticiDerslerEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EgiticiDerslerEkle(Ders p, IFormFile DersImage)
        {
            if (DersImage != null && DersImage.Length > 0)
            {
                // dosya adı ve uzantısı
                var fileName = Path.GetFileName(DersImage.FileName);
                var fileExtension = Path.GetExtension(fileName);

                // dosya adı değiştirme
                var newFileName = Guid.NewGuid() + fileExtension;

                // dosya kaydedilme yolu
                var location = Directory.GetCurrentDirectory();
                var path = Path.Combine(location, "wwwroot/images/", newFileName);

                // dosyayı kaydetme
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    DersImage.CopyTo(stream);
                }

                // veritabanına kaydetme
                p.DersImage = "/images/" + newFileName;
            }

            dm.TAdd(p);
            return RedirectToAction("Index", "Admin");
        }
        public IActionResult EgiticiDerslerSil(int id)
        {
            var ders = dm.TGetById(id);
            dm.TDelete(ders);
            return RedirectToAction("EgiticiDersler", "Admin");
        }

        [HttpGet]
        public IActionResult Slider()
        {
            var values = sm.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult SliderEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SliderEkle(Slider p, IFormFile SliderImage)
        {
            if (SliderImage != null && SliderImage.Length > 0)
            {
                // dosya adı ve uzantısı
                var fileName = Path.GetFileName(SliderImage.FileName);
                var fileExtension = Path.GetExtension(fileName);

                // dosya adı değiştirme
                var newFileName = Guid.NewGuid() + fileExtension;

                // dosya kaydedilme yolu
                var location = Directory.GetCurrentDirectory();
                var path = Path.Combine(location, "wwwroot/images/", newFileName);

                // dosyayı kaydetme
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    SliderImage.CopyTo(stream);
                }

                // veritabanına kaydetme
                p.SliderImage = "/images/" + newFileName;
            }

            sm.TAdd(p);
            return RedirectToAction("Slider", "Admin");
        }
        public IActionResult SliderSil(int id)
        {
            var ders = sm.TGetById(id);
            sm.TDelete(ders);
            return RedirectToAction("Slider", "Admin");
        }

        [HttpGet]
        public IActionResult Galeri()
        {
            var values = gm.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult GaleriEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GaleriEkle(Galeri p, IFormFile GaleryImage)
        {
            if (GaleryImage != null && GaleryImage.Length > 0)
            {
                // dosya adı ve uzantısı
                var fileName = Path.GetFileName(GaleryImage.FileName);
                var fileExtension = Path.GetExtension(fileName);

                // dosya adı değiştirme
                var newFileName = Guid.NewGuid() + fileExtension;

                // dosya kaydedilme yolu
                var location = Directory.GetCurrentDirectory();
                var path = Path.Combine(location, "wwwroot/images/", newFileName);

                // dosyayı kaydetme
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    GaleryImage.CopyTo(stream);
                }

                // veritabanına kaydetme
                p.GaleryImage = "/images/" + newFileName;
            }

            gm.TAdd(p);
            return RedirectToAction("Galeri", "Admin");
        }
        public IActionResult GaleriSil(int id)
        {
            var galeri = gm.TGetById(id);
            gm.TDelete(galeri);
            return RedirectToAction("Slider", "Admin");
        }

        [HttpGet]
        public IActionResult Duyuru()
        {
            var values = dym.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult DuyuruEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DuyuruEkle(Duyurular p)
        {
            dym.TAdd(p);
            return RedirectToAction("Duyuru", "Admin");
        }
        public IActionResult DuyuruSil(int id)
        {
            var duyuru = dym.TGetById(id);
            dym.TDelete(duyuru);
            return RedirectToAction("Duyuru", "Admin");
        }

        [HttpGet]
        public IActionResult Kayitform()
        {
            var values = kfm.GetList();
            return View(values);
        }
        public IActionResult KayitformSil(int id)
        {
            var duyuru = kfm.TGetById(id);
            kfm.TDelete(duyuru);
            return RedirectToAction("Duyuru", "Admin");
        }


        [HttpGet]
        public IActionResult Egitmen()
        {
            var values = em.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult EgitmenEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EgitmenEkle(Egitmenler p, IFormFile EgitmenGorsel)
        {
            if (EgitmenGorsel != null && EgitmenGorsel.Length > 0)
            {
                // dosya adı ve uzantısı
                var fileName = Path.GetFileName(EgitmenGorsel.FileName);
                var fileExtension = Path.GetExtension(fileName);

                // dosya adı değiştirme
                var newFileName = Guid.NewGuid() + fileExtension;

                // dosya kaydedilme yolu
                var location = Directory.GetCurrentDirectory();
                var path = Path.Combine(location, "wwwroot/images/", newFileName);

                // dosyayı kaydetme
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    EgitmenGorsel.CopyTo(stream);
                }
                p.EgitmenGorsel = "/images/" + newFileName;

            }
            em.TAdd(p);
            return RedirectToAction("Egitmen", "Admin");
        }
        public IActionResult EgitmenSil(int id)
        {
            var egitmen = em.TGetById(id);
            em.TDelete(egitmen);
            return RedirectToAction("Egitmen", "Admin");
        }


		[HttpGet]
		public IActionResult Hakkimizda()
		{
			var values = hm.GetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult HakkimizdaEkle()
		{
			return View();
		}
		[HttpPost]
		public IActionResult HakkimizdaEkle(Hakkimizda p)
		{
			hm.TAdd(p);
			return RedirectToAction("Hakkimizda", "Admin");
		}
		public IActionResult HakkimizdaSil(int id)
		{
			var hakkimizda = hm.TGetById(id);
			hm.TDelete(hakkimizda);
			return RedirectToAction("Hakkimizda", "Admin");
		}

        [HttpGet]
        public IActionResult YoutubeLink()
        {
            var values = ylm.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult YoutubeLinkEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YoutubeLinkEkle(YtLink p)
        {
            ylm.TAdd(p);
            return RedirectToAction("YoutubeLink", "Admin");
        }
        public IActionResult YoutubeLinkSil(int id)
        {
            var yt = ylm.TGetById(id);
            ylm.TDelete(yt);
            return RedirectToAction("YoutubeLink", "Admin");
        }
    } 
}
