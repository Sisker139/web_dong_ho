using Microsoft.AspNetCore.Mvc;

namespace SDH.Areas.Customer.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
