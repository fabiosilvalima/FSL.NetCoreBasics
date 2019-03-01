using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FSL.NetCoreBasics.Mvc.Models;
using FSL.NetCoreBasics.Mvc.Services;

namespace FSL.NetCoreBasics.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfigService _configService;

        public HomeController(
            IConfigService configService)
        {
            _configService = configService;
        }

        public IActionResult Index()
        {
            var enabled = _configService.GetConfig().IsCacheEnabled;

            return View();
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
