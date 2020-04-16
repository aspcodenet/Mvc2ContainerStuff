using System;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Mvc2DemoDay1.Models;
using Mvc2DemoDay1.Services;

namespace Mvc2DemoDay1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRateService rateService;
        private readonly SampleSettings sampleSettings;
        public HomeController(ILogger<HomeController> logger, IRateService rateService, ITaxReport report, IOptions<SampleSettings> settingsOptions, IEmailSender emailSender)
        {
            sampleSettings = settingsOptions.Value;
            _logger = logger;
            this.rateService = rateService;
            //emailSender.SendEmailAsync("hello@hello.se","dasdasdas", "tjenare<br />hopp").Wait();
        }

        public IActionResult Index(int v)
        {
            decimal d = rateService.GetRate();
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
