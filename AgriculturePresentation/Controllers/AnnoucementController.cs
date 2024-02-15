using BuisnessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AgriculturePresentation.Controllers
{
    public class AnnoucementController : Controller
    {
        private readonly IAnnoucementService _annoucementService;
        public AnnoucementController(IAnnoucementService annoucementService)
        {
            _annoucementService = annoucementService;
        }

        public IActionResult Index()
        {
            var values = _annoucementService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddAnnoucement()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnoucement(Annoucement annoucement)
        {
            annoucement.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            annoucement.Status = false;
            _annoucementService.Insert(annoucement);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteAnnoucement(int id)
        {
            var values = _annoucementService.GetById(id);
            _annoucementService.Delete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditAnnoucement(int id)
        {
            var values = _annoucementService.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditAnnoucement(Annoucement annoucement)
        {
            _annoucementService.Update(annoucement);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusToTrue(int id)
        {
            _annoucementService.AnnoucementStatusToTrue(id);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusToFalse(int id)
        {
            _annoucementService.AnnoucementStatusToFalse(id);
            return RedirectToAction("Index");
        }
    }
}