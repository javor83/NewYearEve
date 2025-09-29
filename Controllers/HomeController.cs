using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NewYearEve.Interfaces;
using NewYearEve.Models;

namespace NewYearEve.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IRepositoryGuestResponse list = null;
        //*************************************************************************
        public HomeController
            (
            ILogger<HomeController> logger,
            IRepositoryGuestResponse rep_user
            )
        {
            this.list = rep_user;
            _logger = logger;
        }
        //*************************************************************************
        public IActionResult Index()
        {
            return View(this.list.Get());
        }
        //*************************************************************************
        public IActionResult Invite()
        {
            GuestResponse key = new GuestResponse()
            {
                Name = string.Empty,
                Email = string.Empty,
                Phone = string.Empty,
                WillAttend = null
            };
            return View(key);

        }
        //*************************************************************************
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Invite(GuestResponse sender)
        {
            if (ModelState.IsValid)
            {
                this.list.Insert(sender);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }

        }
        //*************************************************************************


    }
}
