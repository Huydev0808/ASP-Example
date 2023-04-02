using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebDemo.Models;

namespace WebDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
	
		[HttpPost]
        public IActionResult Index(int soNguyenA, int soNguyenB)
        {
            int S = soNguyenA + soNguyenB;
            ViewData["SoNguyenA"] = soNguyenA;
            ViewData["SoNguyenB"] = soNguyenB;


            ViewData["TongHaiSo"] = S;

            return View();
        }
		[HttpPost]


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