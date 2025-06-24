using Microsoft.AspNetCore.Mvc;

namespace Shipper.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
