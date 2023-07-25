using System.Diagnostics;
using DIWebApp.Interfaces;
using DIWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DIWebApp.Controllers
{
	public class HomeController : Controller
	{
		private readonly IHelloWorldService _helloWorldService;
		private readonly IProductCatalogService _productCatalogService;
		public HomeController(IHelloWorldService helloWorldService, IProductCatalogService productCatalogService)
		{
			Console.WriteLine("HomeController Instance is Initialized.........*******");
			this._helloWorldService = helloWorldService;
			this._productCatalogService = productCatalogService;
		}

		public IActionResult Index()
		{
			string message=this._helloWorldService.sayHello();
			this.ViewData["Message"] = message;
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}