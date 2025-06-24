using Microsoft.AspNetCore.Mvc;

namespace Shipper.Controllers
{
    public class TransportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
