using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mvc2DemoDay1.Models;
using Mvc2DemoDay1.Services;
using Mvc2DemoDay1.ViewModels;

namespace Mvc2DemoDay1.Controllers
{
    public class OrderController : Controller
    {
        private readonly NorthwindContext context;
        private readonly ITaxReport report;

        public OrderController(NorthwindContext context, ITaxReport report)
        {
            this.context = context;
            this.report = report;
        }
        public IActionResult Index()
        {
            report.GenerateReport(context.Employees);


            var model = new OrderListViewModel();
            model.Orders = new List<OrderListViewModel.Order>();

            //STUPID??? - well it works fine..
            foreach (var v in context.Orders.Include(d => d.Customer))
                model.Orders.Add(new OrderListViewModel.Order
                {
                    Id = v.OrderId,
                    CustomerName = v.Customer.CompanyName,
                    OrderDate = v.OrderDate
                });
            //Lets check SQL Profiler


            //model.Orders = context.Orders.Include(d => d.Customer)
            //    .Select(v => new OrderListViewModel.Order
            //    {
            //        Id = v.OrderId,
            //        CustomerName = v.Customer.CompanyName,
            //        OrderDate = v.OrderDate
            //    }).ToList();


            return View(model);
        }
    }
}