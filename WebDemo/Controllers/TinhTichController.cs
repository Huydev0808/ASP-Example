using Microsoft.AspNetCore.Mvc;

namespace WebDemo.Controllers
{
	public class TinhTichController : Controller
	{
		[HttpGet]
		public IActionResult TinhTich()
		{
			return View();
		}
		[HttpPost]
		public IActionResult TinhTich(int soNguyenC, int soNguyenD)
		{
			int S1 = soNguyenC * soNguyenD;
			ViewData["SoNguyenC"] = soNguyenC;
			ViewData["SoNguyenD"] = soNguyenD;

			ViewData["TichHaiSo"] = S1;
			return View();
		}
	}
}
