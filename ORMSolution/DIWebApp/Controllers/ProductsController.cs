using DIWebApp.Interfaces;
using Microsoft.AspNetCore.Mvc;
using DIWebApp.Services;
namespace DIWebApp.Controllers
{
	public class ProductsController : Controller
	{
		private readonly IProductCatalogService _productCatalogService;

		public ProductsController(IProductCatalogService productCatalogService)
		{
			Console.WriteLine("ProductsController Instance is Initialized.........*******");
			this._productCatalogService = productCatalogService;	
		}
		public IActionResult Insert()
		{
			bool status=this._productCatalogService.Insert();
			ViewData["status"] = "New Product is inserted status=" + status; 
			return View();
		}
	}
}
