using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ServiceBusAutomation.Models;
using ServiceBusAutomation.Data;

namespace ServiceBusAutomation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Employee()
        {
            ServiceBusAutomationContext db = new ServiceBusAutomationContext();
            var empList = db.Employees.ToList();
            return Json(empList);
        }
    }
}
