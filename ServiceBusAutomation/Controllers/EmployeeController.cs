using Microsoft.AspNetCore.Mvc;
using ServiceBusAutomation.Data;
using ServiceBusAutomation.Models;
using System;

namespace ServiceBusAutomation.Controllers
{
    public class EmployeeController : Controller
    {
        readonly ServiceBusAutomationContext _dbContext;


        public EmployeeController(ServiceBusAutomationContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult List()
        {
            var empList = _dbContext.Employees.ToList();
            return Json(empList);
        }

        [HttpPost]
        public IActionResult Ekle([FromBody] Employee emp)
        {
            if (emp == null)
                return BadRequest("Employee can not be empty");

            _dbContext.Employees.Add(emp);
            _dbContext.SaveChanges();
            return Ok(emp);
        }
    }
}
