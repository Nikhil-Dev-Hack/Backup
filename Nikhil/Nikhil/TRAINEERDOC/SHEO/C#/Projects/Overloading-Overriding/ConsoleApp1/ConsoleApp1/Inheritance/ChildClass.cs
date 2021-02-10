using ConsoleApp1.Interfaces;
using System;

namespace ConsoleApp1.Inheritance
{
    public class ChildClass : ParentClass, IMathClass
    {
        #region IMathClass implementation

        public override string Ravi()
        {
            return "Sai raviteja";
        }







        public int Add(int a, int b)
        {
            return a + b;
        }

        public string Add(string a, string b)
        {
            return a + " AND " + b;
        }


        public int Add(int a, int b, int c)
        {
            return a + b + c;
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
