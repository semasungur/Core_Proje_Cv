using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardWriterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardWriterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v1 = values.Name + " " + values.Surname;
            //HAVA DURUMU APİ

            string api = "372c1490e4302c786b78371c72eb9595";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=kayseri&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document=XDocument.Load(connection);
            ViewBag.v6 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            //İSTATİSTİKLER
            Context c = new Context();
            ViewBag.v2 = c.WriterMessages.Where(x=>x.Receiver==values.Email).Count();
            ViewBag.v3 = c.Announcements.Count();
            ViewBag.v4 = c.Users.Count();
            ViewBag.v5 = c.Skills.Count();
            return View();
        }
    }
}
