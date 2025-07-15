using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shipper.Models.Enums;

namespace Shipper.Areas.Client.Controllers
{
    [Area("Client")]
    [Authorize(Roles = "Client")]
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult SendAParcel()
        {
            return View();
        }

        public IActionResult ShipmentStatus()
        {
            return View();
        }
    }
}
