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
    }
}
