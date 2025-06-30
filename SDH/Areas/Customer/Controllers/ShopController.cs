using Microsoft.AspNetCore.Mvc;

namespace SDH.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
