using Microsoft.AspNetCore.Mvc;

namespace Shipper.Web.Areas.Admin.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
