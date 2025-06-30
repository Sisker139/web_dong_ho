using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SDH.Data;
using SDH.Models;
using SDH.Areas.Customer.Controllers;
using System.Diagnostics;


namespace SDH.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class QuanlyDHController : Controller
    {

        private readonly ILogger<QuanlyDHController> _logger;

        public QuanlyDHController(ILogger<QuanlyDHController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            //var products = _context.Products.ToList();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //[HttpPost]
        //public async Task<IActionResult> AddProduct([FromBody] Product product)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Products.Add(product);
        //        await _context.SaveChangesAsync();
        //        return Json(new { success = true, message = "Thêm sản phẩm thành công!" });
        //    }
        //    return Json(new { success = false, message = "Có lỗi xảy ra!" });
        //}



        //[HttpPost]
        //public async Task<IActionResult> UploadImage(IFormFile image)
        //{
        //    if (image != null && image.Length > 0)
        //    {
        //        var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");
        //        if (!Directory.Exists(uploadsFolder))
        //        {
        //            Directory.CreateDirectory(uploadsFolder);
        //        }

        //        var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);
        //        var filePath = Path.Combine(uploadsFolder, uniqueFileName);

        //        using (var fileStream = new FileStream(filePath, FileMode.Create))
        //        {
        //            await image.CopyToAsync(fileStream);
        //        }

        //        var imageUrl = "/images/" + uniqueFileName; // Đường dẫn lưu trong DB
        //        return Json(new { success = true, imageUrl });
        //    }
        //    return Json(new { success = false, message = "Không thể tải ảnh!" });
        //}

        //[HttpGet]
        //public IActionResult GetProducts()
        //{
        //    var products = _context.Products.ToList();
        //    return Json(products);
        //}

    }
}
