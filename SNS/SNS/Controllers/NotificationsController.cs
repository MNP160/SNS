using Microsoft.AspNetCore.Mvc;
using SNS.Data;
using SNS.Migrations;
using SNS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SNS.Controllers
{
    public class NotificationsController :Controller
    {
        private readonly SNSContext _context;

        public NotificationsController(SNSContext con)
        {
            _context = con;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Notification notification)
        {
            var username = HttpContext.User.Identity.Name;
            System.Diagnostics.Debug.WriteLine("------------------------------------------------");
            System.Diagnostics.Debug.WriteLine(username);
            System.Diagnostics.Debug.WriteLine("------------------------------------------------");
            var user = _context.Users.FirstOrDefault(x => x.Email == username);
            notification.Department = user.Department;
            _context.Notifications.Add(notification);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");

        }


    }
}
