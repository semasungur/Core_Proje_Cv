using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class AdminNavbarMessageList:ViewComponent
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterDal());
        public IViewComponentResult Invoke()
        {
            Context c = new Context();

            var img1 = c.WriterMessages.Where(x => x.Receiver == "s@yandex.com").Select(z => z.Sender).FirstOrDefault();

            var img2 = c.Users.Where(x => x.Email == img1).Select(z => z.ImageUrl).FirstOrDefault();

            ViewBag.v1 = img2;
            string p = "s@yandex.com";
            var values = writerMessageManager.GetListReceiverMessage(p).OrderByDescending(x=>x.WriterMessageID).Take(3).ToList();
            return View(values);
        }
    }
}
