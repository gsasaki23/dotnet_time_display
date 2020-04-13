using Microsoft.AspNetCore.Mvc;
using System;

namespace time_display
{
    public class IndexController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.date = DateTime.Now.ToString("MMMM dd, yyyy");
            ViewBag.time = DateTime.Now.ToString("hh:mm tt");
            return View("Index");
        }
    }
}
