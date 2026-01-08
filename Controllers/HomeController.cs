using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PartyInvites2.Models;

namespace PartyInvites2.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            DateTime now = DateTime.Now;
            int h = now.Hour;
            ViewBag.Greeting = h < 12 ? "Good morning" : "Good afternoon";
            ViewBag.datetime = now;
            return View("MyView");
        }

        public ViewResult MyView()
        {
            return View();
        }
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
