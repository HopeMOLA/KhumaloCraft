using Microsoft.AspNetCore.Mvc;
using ClassLibrary2;

namespace KhumaloCraft.Controllers
{
    public class ClassController : Controller
    {
        public IActionResult Index()
        {
            var class1 = new Class1();
            string message = class1.GetGreeting("World");
            ViewData["Message"] = message;
            return View();
        }
    }
}

