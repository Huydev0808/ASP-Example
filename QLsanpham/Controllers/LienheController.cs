using Microsoft.AspNetCore.Mvc;

namespace QLsanpham.Controllers
{
    public class LienheController : Controller
    {
        public IActionResult lienhe()
        {
            ViewData["HoTen"] = "Phạm Ngô Hoàng Huy";
            ViewData["NgaySinh"] = "08 / 08 / 1995";
            ViewData["Email"] = "phamngohoanghuy95@gmail.com";
            ViewData["SoDienThoai"] = "0374169298";
            return View();
        }
    }
}
