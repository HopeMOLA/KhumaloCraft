using Microsoft.AspNetCore.Mvc;
using System.Linq;
using KhumaloCraft.Models;
using KhumaloCraft.ViewModels;
using System.Collections.Generic;
using KhumaloCraft.Data;

namespace KhumaloCraft.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductContext _context;
        
        public ProductController(ProductContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Search(string searchTerm)
        {
            var model = new ProductSearchViewModel();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                model.SearchTerm = searchTerm;
                model.Results = _context.Product
                    .Where(p => p.Name.Contains(searchTerm) || p.Category.Contains(searchTerm))
                    .ToList();
            }
            else
            {
                model.Results = new List<Product>();
            }

            return View(model);
        }
    }
}
