using Microsoft.AspNetCore.Mvc;

namespace Shipper.Web.Areas.Admin.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
