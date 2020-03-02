using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Core.Abstract;
using MVC_Core.Entities;
using MVC_Core.Models;

namespace MVC_Core.Controllers
{
    public class HomeController : Controller
    {
        IConnection connection;
        IMessage message;
        //public HomeController(IConnection _connection,IMessage _message)
        //{
        //    connection = _connection;
        //    message = _message;
        //}
        public IActionResult Index([FromServices]IConnection connection, [FromServices]IMessage message)
        {
            ViewData["Name"] = connection.GetConnection();
            ViewData["MessageStatus"] = message.Send();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }
    }
}
