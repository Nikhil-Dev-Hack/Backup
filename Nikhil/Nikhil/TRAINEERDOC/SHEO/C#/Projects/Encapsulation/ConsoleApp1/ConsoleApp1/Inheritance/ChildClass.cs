using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Inheritance
{
    public class ChildClass : ParentClass, IMathClass
    {
        #region IMathClass implementation

        public int Add(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Divide(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Multiply(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Substract(int a, int b)
        {
            throw new NotImplementedException();
        }

        #endregion 

        public string PublicGetMyChildName()
        {
            var name = ProtectedGetMyName();
            var name1 = PublicGetMyName();

            return "This is my child class name";
        }

       
    }
}
