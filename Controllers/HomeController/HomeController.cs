using System;
using Microsoft.AspNetCore.Mvc;

namespace TimeDisplay.Controllers.HomeController
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Home()
        {
            ViewBag.HeadLine = "The current time and date";
            DateTime CurrentTime = DateTime.Now;
            ViewBag.Time = CurrentTime;

            // DateTime d = DateTime.Now;
            // string sd= d.ToString("MMMM dd, yyyy hh:mm tt");
 
            return View();
        }
    }
}