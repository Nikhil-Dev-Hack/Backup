using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALLMVC.Data;
using ALLMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ALLMVC.Controllers
{
    public class SearchController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SearchController(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public IActionResult SearchNormal()
        {
            return View(new List<Employee>());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SearchNormal(IFormCollection form)
        {
            var FieldName = form["FieldName"].ToString();
            var KeyWord = form["KeyWord"].ToString();

            IList<Employee> employees = new List<Employee>();

            switch (FieldName)
            {
                case "Id":
                    var id = int.Parse(KeyWord);
                    employees = _context.Employee.Where(d => d.Id.Equals(id)).ToList();
                    break;
                case "Name":
                    employees = _context.Employee.Where(d => d.Name.StartsWith(KeyWord)).OrderBy(d => d.Name).ToList();
                    break;
                case "DepartmentId":
                    var Did = int.Parse(KeyWord);
                    employees = _context.Employee.Where(d => d.DepartmentId.Equals(Did)).ToList();
                    break;
            }
            return View();
        }

    }
}
