using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALLMVC.Dependency_Injection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ALLMVC.Controllers
{
    public class DIController : Controller
    {
        private readonly IDependencyInjection _Injection;

        public DIController(IDependencyInjection injection)
        {
            _Injection = injection;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Index(IFormCollection form)
        {
            var dob = DateTime.Parse(form["YourAge"]);
            ViewBag.DOB = dob;
            ViewBag.YourAge = _Injection.GetMyAge(dob);
            return View();
        }
    }
}
