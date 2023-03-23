using GreetingWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace GreetingWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Greeting(string name)
        {
            
            var user = new User() { Id = 1, Name = name };
            if(ModelState.IsValid)
            {
                return View(user);
            }

            return View("Index",user);
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