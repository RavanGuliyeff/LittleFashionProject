using LittleFashion.DAL;
using LittleFashion.Models;
using LittleFashion.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LittleFashion.Controllers
{
	public class HomeController : Controller
	{
        AppDbContext _db;

        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
		{
			List<Product> products = _db.Products.ToList();
			List<Slider> sliders = _db.Sliders.ToList();

			HomeVm vm = new HomeVm()
			{
				Products = products,
				Sliders = sliders
			};

			return View(vm);
		}

		public IActionResult Detail(int? id)
		{

			var product = _db.Products.FirstOrDefault(p => p.Id == id);

            return View(product);
		}
	}
}
