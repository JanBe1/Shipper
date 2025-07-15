using Microsoft.AspNetCore.Mvc;

namespace Shipper.Web.Areas.Admin.Controllers
{
    public class DispatcherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
