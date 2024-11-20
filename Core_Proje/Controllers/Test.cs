using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class Test : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
