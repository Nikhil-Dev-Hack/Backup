using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ALLMVC.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult CustomWare()
        {
            return View();
        }
    }
}
