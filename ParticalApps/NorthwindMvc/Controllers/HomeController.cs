using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NorthwindMvc.Models;
using Packt.Shared;
using Microsoft.EntityFrameworkCore;

namespace NorthwindMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Northwind db;
        public HomeController(ILogger<HomeController> logger, Northwind injectedContext)
        {
            _logger = logger;
            db = injectedContext;
        }

        public async Task<IActionResult> Index()
        {
            var model = new HomeIndexViewModel
            {
                VisitorCount = (new Random().Next(1,1001)),
                Categories = await db.Categories.ToListAsync(),
                Products = await db.Products.ToListAsync()
            };
            return View(model);
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

        public async Task<IActionResult> ProductDetail(int? id)
        {
            if(!id.HasValue)
            {
                return NotFound("You must pass a product ID in the route, for example, /Home/ProductDetail/21");
            }

            var model = await db.Products
                .SingleOrDefaultAsync(p => p.ProductID == id);

            if(model ==null)
            {
                return NotFound($"Product with ID of {id} ot found.");
            }

            return View(model);
        }

        public IActionResult ModelBinding()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ModelBinding(Thing thing)
        {
            //return View(thing);
            var model = new HomeModelBindingViewModel
            {
                Thing = thing,
                HasErrors = !ModelState.IsValid,
                ValidationErrors = ModelState.Values
                    .SelectMany(state => state.Errors)
                    .Select(error => error.ErrorMessage)
            };

            return View(model);
        }

        public IActionResult ProductsThatCostMoreThan(decimal? price)
        {
            if(!price.HasValue)
            {
                return NotFound("You must pass a product price in the query string, for example, /Home/ProductsTatCostMoreThan?price=50");
            }

            IEnumerable<Product> model = db.Products
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .AsEnumerable()
                .Where(p => p.UnitPrice > price);

            if (model.Count() == 0)
            {
                return NotFound($"No products cost more than {price:c}");
            }
            ViewData["MaxPrice"] = price.Value.ToString("C");

            return View(model);
        }
    }
}
