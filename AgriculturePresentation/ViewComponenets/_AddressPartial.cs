using BuisnessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace AgriculturePresentation.ViewComponenets
{
	public class _AddressPartial : ViewComponent
	{
		private readonly IAddressService _addressService;

		public _AddressPartial(IAddressService addressService)
		{
			_addressService = addressService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _addressService.GetListAll();
			return View(values);
		}
	}
}
