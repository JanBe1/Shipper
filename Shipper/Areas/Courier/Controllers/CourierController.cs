using Microsoft.AspNetCore.Mvc;

namespace Shipper.Areas.Courier.Controllers
{
    public class CourierController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
