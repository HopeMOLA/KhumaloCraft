using KhumaloCraft.Data;
using KhumaloCraft.Models;
using KhumaloCraft.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Threading.Tasks;

namespace KhumaloCraft.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductContext _context;
        private readonly ProductRepo _productRepo;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ProductContext context, ProductRepo productRepo)
        {
            _context = context;
            _productRepo = productRepo;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public async Task<IActionResult> Work()
        {
            var Product = await _context.Product.ToListAsync();
            return View(Product);
        }
        public IActionResult Talktous()
        {
            return View();
        }
        public IActionResult Knowus()
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
