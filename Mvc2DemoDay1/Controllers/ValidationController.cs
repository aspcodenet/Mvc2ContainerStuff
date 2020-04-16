using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mvc2DemoDay1.ViewModels;

namespace Mvc2DemoDay1.Controllers
{
    public class ValidationController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = new ValidationDemoViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(ValidationDemoViewModel model)
        {
            if(ModelState.IsValid)
            {
                //Save...
                //Redirect to thanks page?
            }
            return View(model);
        }

    }
}