using Microsoft.AspNetCore.Mvc;

namespace Shipper.Web.Areas.Admin.Controllers
{
    public class CourierController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
