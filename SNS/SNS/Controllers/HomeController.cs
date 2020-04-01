using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SNS.Data;
using SNS.Models;

namespace SNS.Controllers
{
    public class HomeController : Controller
    {
        private readonly SNSContext _context;

        public HomeController(SNSContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {


            return View(_context.Notifications.OrderByDescending(x=>x.NotificationId).Take(5).ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
