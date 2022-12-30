﻿using IzvidaciWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IzvidaciWebApp.Controllers
{
    public class ClanstvoController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ClanstvoController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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