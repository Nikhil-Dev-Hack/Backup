using System;

namespace C_Sharp_Work_.TaskDay_3
{
    public class Employee
    {
        private int empNo;
        private string firstName;
        private int salary;
        private string deptName;
        /// <summary>
        /// For EmpNo 
        /// </summary>
        public int EmpNo
        {
            get
            {
                return empNo;
            }
            set
            {
                empNo = value;
                if (empNo < 1001)
                {
                    throw new Exception("Employee number should be more than 1001");
                }
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
                if (firstName.Length < 3 || firstName == null)
                {
                    throw new Exception("Employee name should be more than 3 characters");
                }
            }
        }

        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
                if (salary < 0)
                {
                    throw new Exception("salary should be positive");
                }
            }
        }

        public string DeptName
        {
            get
            {
                return deptName;
            }
            set
            {
                deptName = value;
                if (deptName != "Devolopment")
                {
                    throw new Exception("Department must be developer");
                }
            }
        }
    }
}