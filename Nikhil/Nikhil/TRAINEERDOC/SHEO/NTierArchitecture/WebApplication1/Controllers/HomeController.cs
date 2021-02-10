using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;
using BusinessAccessLayer;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Data;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            // this is not the correct way, ideally your DAL should be getting the connection string from the appsettings.json
            var connStr = _configuration.GetConnectionString("ConnStr");
            EmployeeAddressDetails employeeAddressDetails = new EmployeeAddressDetails();
            var details = employeeAddressDetails.GetEmployees(connStr, "");
            ViewBag.ConnStr = connStr;

            IList<Employee> list = new List<Employee>();
            foreach(DataRow row in details.Rows)
            {
                Employee employee = new Employee()
                {
                    EmpId = row["EmpId"].ToString(),
                    Location = row["Location"].ToString(),
                    Name = row["Name"].ToString(),
                    Salary = decimal.Parse(row["Salary"].ToString())
                };
                list.Add(employee);
            }

            return View(list);
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
