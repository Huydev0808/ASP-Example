using Microsoft.AspNetCore.Mvc;
using QLsanpham.Models;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using QLsanpham.Controllers;
using Microsoft.Extensions.Logging;

namespace QLsanpham.Controllers
{
    public class SanphamController : Controller
    {
        public static List<SanPham> sanpham = new List<SanPham>();
        private readonly ILogger<SanphamController> _logger;

        public SanphamController(ILogger<SanphamController> logger)
        {
            _logger = logger;
        }

        public IActionResult Sanpham(bool? check = false)
        {
            if ((bool)check)
            {
                sanpham.Clear();
            }
            else
            {
                return View(sanpham.ToList());
            }
            return View();
        }
        [HttpPost]
        public IActionResult Sanpham(string tensanpham, int soluong, int dongia)
        {
            var homeProduct = new SanPham(tensanpham, soluong, dongia);
            sanpham.Add(homeProduct);
            return View(sanpham);
        }
        public IActionResult RemoveProduct(int position)
        {
            sanpham.RemoveAt(position - 1);
            return RedirectToAction("sanpham", "Sanpham");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
