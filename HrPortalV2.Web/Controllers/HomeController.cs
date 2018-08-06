﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HrPortalV2.Web.Models;
using HrPortalV2.Service;
using Microsoft.AspNetCore.Mvc.Filters;

namespace HrPortalV2.Web.Controllers
{
    public class HomeController : ControllerBase
    {
        private readonly IJobService jobService;
        public HomeController(IJobService jobService)
        {
            this.jobService = jobService;
        }
        
        public IActionResult Index()
        {
            ViewBag.FeaturedJobs = jobService.GetFeaturedJobs();
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
