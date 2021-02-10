using _1JanTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1JanTask.BasicJoins
{
    public class LeftOuterJoins
    {
        public void Leftouter()
        {
            var result = from e in Employee.GetAllEmployees()
                         join d in Department.GetAllDepartments()
                         on e.DepartmentID equals d.ID into eGroup
                         from d in eGroup.DefaultIfEmpty()
                         select new
                         {
                             EmployeeName = e.Name,
                             DepartmentName = d == null ? "No Department" : d.Name
                         };

            foreach (var v in result)
            {
                Console.WriteLine(v.EmployeeName + "\t" + v.DepartmentName);
            }
        }
    }
}
