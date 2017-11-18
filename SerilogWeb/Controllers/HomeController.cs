using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using SerilogWeb.Models;
using SerilogWeb.Services;

namespace SerilogWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly SimpleLogger logger;

        public HomeController(SimpleLogger simpleLogger)
        {
            this.logger = simpleLogger;
            logger.SimpleLog("test form simple logger");
        }

        public IActionResult Index()
        {
            Log.Debug("INTO THE CONTROLLER");
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
