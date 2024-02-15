using BuisnessLayer.Abstract;
using BuisnessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _ContactService;

        public ContactController(IContactService contactService)
        {
            _ContactService = contactService;
        }
        public IActionResult Index()
        {
            var values = _ContactService.GetListAll();
            return View(values);
        }
        public IActionResult DeleteMessage(int id)
        {
            var values = _ContactService.GetById(id);
            _ContactService.Delete(values);
            return RedirectToAction("Index");
        }
        public IActionResult MessageDetails(int id)
        {
            var values = _ContactService.GetById(id);
            return View(values);
        }
    }
}
