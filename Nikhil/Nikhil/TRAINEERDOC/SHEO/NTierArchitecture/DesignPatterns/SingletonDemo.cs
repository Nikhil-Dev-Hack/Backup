using System;

namespace DesignPatterns
{
    public sealed class SingleTon
    {
        private static SingleTon _instance = null;
        static object obj = new object();
        private SingleTon() // Made default constructor as private 
        {

        }

        public static SingleTon Instance
        {
            get
            {
                lock (obj)
                {
                    //_instance = _instance ?? new SingleTon();

                    if (_instance == null)
                    {
                        _instance = new SingleTon();
                    }

                    return _instance;
                }
            }
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
