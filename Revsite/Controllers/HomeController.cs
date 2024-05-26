using Microsoft.AspNetCore.Mvc;
using Revsite.Data;
using Revsite.Models;
using System.Diagnostics;

namespace Revsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RevsiteContext revsiteContext;

        public HomeController(ILogger<HomeController> logger, RevsiteContext context)
        {
            revsiteContext = context;
            revsiteContext.Database.EnsureCreated();

            _logger = logger;
        }

        public IActionResult Index()
        {
            var users = revsiteContext.Users.ToList();
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
