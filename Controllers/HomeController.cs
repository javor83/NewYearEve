using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NewYearEve.Models;

namespace NewYearEve.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IRepositoryGuestResponse list = null;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(this.list);
        }

        public IActionResult Invite()
        {
            GuestResponse key = new GuestResponse()
            {
                Name = "...name...",
                Email = "...email...",
                Phone = "..phone...",
                WillAttend = null
            };
            return View(key);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Invite(GuestResponse sender)
        {
            return Json(sender);
        }

       
    }
}
