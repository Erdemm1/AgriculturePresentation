using BuisnessLayer.Abstract;
using BuisnessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddressService _AddressService;

        public AddressController(IAddressService AddressService)
        {
            _AddressService = AddressService;
        }
        public IActionResult Index()
        {
            var values = _AddressService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult EditAddress(int id)
        {
            var values = _AddressService.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditAddress(Address Address)
        {
            AddressValidator validationRules = new AddressValidator();
            ValidationResult results = validationRules.Validate(Address);
            if (results.IsValid)
            {
                _AddressService.Update(Address);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
