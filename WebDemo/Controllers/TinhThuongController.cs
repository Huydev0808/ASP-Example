using Microsoft.AspNetCore.Mvc;

namespace WebDemo.Controllers
{
	public class TinhThuongController : Controller
	{
		[HttpGet]
		public IActionResult TinhThuong()
		{
			return View();
		}
		[HttpPost]
		public IActionResult TinhThuong(int soNguyenC, int soNguyenD)
		{
			try
			{
				int S1 = soNguyenC / soNguyenD;
				ViewData["SoNguyenC"] = soNguyenC;
				ViewData["SoNguyenD"] = soNguyenD;

				ViewData["ThuongHaiSo"] = S1;
				return View();
			}
			catch (DivideByZeroException)
			{

				string warning = "Loi chia cho 0";
				ViewData["ThongBao"] = warning;
				return View();
			}

		}
	}
}
