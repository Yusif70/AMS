using AMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace AMS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                return Json(ticket);
            }
            return View();
        }
    }
}
