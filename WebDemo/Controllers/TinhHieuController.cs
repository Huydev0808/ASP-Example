using Microsoft.AspNetCore.Mvc;

namespace WebDemo.Controllers
{
	public class TinhHieuController : Controller
	{
		[HttpGet]
		public IActionResult TinhHieu()
		{
			return View();
		}
		[HttpPost]
		public IActionResult TinhHieu(int soNguyenC, int soNguyenD)
		{
			int S1 = soNguyenC - soNguyenD;
			ViewData["SoNguyenC"] = soNguyenC;
			ViewData["SoNguyenD"] = soNguyenD;

			ViewData["HieuHaiSo"] = S1;
			return View();
		}
	}
}
