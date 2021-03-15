using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MessageBoard.Models;
// using System.Linq;

namespace MessageBoard.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MessageForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MessageForm(Message getMessage)
        {
            //TODO: Store messages
            if (ModelState.IsValid)
            {
                Repository.AddMessage(getMessage);
                return View("Thanks", getMessage);
            }
            else
            {
                return View();
            }
        }

        public IActionResult ListMessages()
        {
            return View(Repository.Messages);
        }
    }
}
