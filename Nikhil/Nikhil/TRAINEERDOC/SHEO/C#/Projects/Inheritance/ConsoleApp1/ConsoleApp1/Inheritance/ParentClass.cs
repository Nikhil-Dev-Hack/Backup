using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Inheritance
{
    public class ParentClass
    {
        public string PublicGetMyName()
        {
            return "My name is TollPlus.";
        }

        private string PrivateGetMyName()
        {
            return "My private name";
        }

        protected string ProtectedGetMyName()
        {
            return "My protected name";
        }
    }
}
