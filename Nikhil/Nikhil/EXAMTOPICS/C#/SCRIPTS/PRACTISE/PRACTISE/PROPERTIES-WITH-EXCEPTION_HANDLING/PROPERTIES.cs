using System;
using System.Collections.Generic;
using System.Text;

namespace PRACTISE.PROPERTIES_WITH_EXCEPTION_HANDLING
{
    public class PROPERTIES
    {
        private int empNo;
        private string empName;
        private int salary;
        private string deptName;

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

        public string EmpName 
        {
            get
            {
                return empName;
            }
            set
            {
                empName = value;
                if (empName.Length < 3 || empName == null)
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
                if (salary < 0 )
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
                if (deptName != "Development")
                {
                    throw new Exception("Access is Denied");
                    
                }
                return;
                
            }
            
        }

    }
}
