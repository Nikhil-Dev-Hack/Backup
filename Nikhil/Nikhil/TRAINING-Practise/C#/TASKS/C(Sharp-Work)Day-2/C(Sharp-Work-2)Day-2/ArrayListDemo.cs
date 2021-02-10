using System;
using System.Collections;

namespace C_Sharp_Work_2_Day_2
{
    /// <summary>
    /// 
    /// </summary>
    public class ArrayListDemo
    {
        public void Execute()
        {
            //ArrayList arrayList = new ArrayList();
            //EmployeeDetails employeeDetails = new EmployeeDetails();
            //arrayList.Add("String");
            //arrayList.Add(10);
            //DateTime d = new DateTime(2020, 11, 6);
            //arrayList.Add(d);
            //arrayList.Add(employeeDetails.DeptName);
            ////arrayList.Add(employeeDetails);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}


            ArrayList list = new ArrayList();
            Console.WriteLine("Enter department id, name, location:");
            Department dept = new Department();
            dept.Id = Convert.ToInt32(Console.ReadLine());
            dept.Name = Console.ReadLine();
            dept.Location = Console.ReadLine();
            list.Add(dept);
            // Console.WriteLine(list);

            //Console.WriteLine("Enter id , FName , LName , Salary , DeptName ");
            //EmployeeDetails employeeDetails = new EmployeeDetails();
            //employeeDetails.EmployeeId = Convert.ToInt32(Console.ReadLine());
            //employeeDetails.FirstName = Console.ReadLine();
            //employeeDetails.LastName = Console.ReadLine();
            //employeeDetails.Salary = Convert.ToInt32(Console.ReadLine());
            //employeeDetails.DeptName = Console.ReadLine();
            //list.Add(employeeDetails);


            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}


            var dept1 = list[0] as Department;
            var emp1 = list[1] as EmployeeDetails;
            Console.WriteLine("Below are department details: ");
            Console.WriteLine($"{dept1.Id},\n {dept1.Name},\n {dept1.Location}");
            Console.WriteLine("Below are Employee details: ");
            Console.WriteLine($"{emp1.EmployeeId}, \n {emp1.FirstName},\n {emp1.LastName} ,\n {emp1.Salary} ,\n {emp1.DeptName}");


        }
    }
}
