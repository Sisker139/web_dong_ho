using Microsoft.AspNetCore.Mvc;

namespace SDH.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class QuanlyTKController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
