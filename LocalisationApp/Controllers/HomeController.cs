﻿using LocalisationApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Diagnostics;

namespace LocalisationApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStringLocalizer<HomeController> _localiser;

        public HomeController(ILogger<HomeController> logger, 
            IStringLocalizer<HomeController> localizer)
        {
            _logger = logger;
            _localiser = localizer;
        }

        public IActionResult Index()
        {
            var localizedTitle = _localiser["Welcome"];
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