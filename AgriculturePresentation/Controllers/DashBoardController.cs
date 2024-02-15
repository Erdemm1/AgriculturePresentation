using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AgriculturePresentation.Controllers
{
    public class DashBoardController : Controller
    {
        AgricultureContext context = new AgricultureContext();
        public IActionResult Index()
        {
            ViewBag.teamCount = context.Teams.Count();
            ViewBag.serviceCount = context.Services.Count();
            ViewBag.messageCount = context.Contacts.Count();
            ViewBag.currentMonthCount = 3;


            ViewBag.annaouncementTrue = context.Annoucements.Where(x => x.Status == true).FirstOrDefault();
            ViewBag.annaouncementFalse = context.Annoucements.Where(x => x.Status == false).FirstOrDefault();

            ViewBag.urunPazarlama = context.Teams.Where(x=>x.Title == "Ürün Pazarlama").Select(y=>y.PersonName).FirstOrDefault();
            ViewBag.bakliyatYoneticisi = context.Teams.Where(x=>x.Title == "Bakliyat Yöneticisi").Select(y=>y.PersonName).FirstOrDefault();
            ViewBag.hasatUzmani = context.Teams.Where(x=>x.Title == "Hasat Uzmanı").Select(y=>y.PersonName).FirstOrDefault();
            ViewBag.sutUreticisi = context.Teams.Where(x=>x.Title == "Süt Üreticisi").Select(y=>y.PersonName).FirstOrDefault();
            return View();
        }
    }
}
