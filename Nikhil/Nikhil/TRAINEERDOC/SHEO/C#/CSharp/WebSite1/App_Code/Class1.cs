using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// NOTE: WE are assuming that this is third party class and we do not have ability to modify this
/// </summary>
[Serializable]
public class Class1
{

    /// <summary>
    /// Initializes a new instance of the <see cref="Class1"/> class.
    /// </summary>
	public Class1()
	{

        Child ch = new Child();
        //ch.FirstName = "FFDSAFASD";

		
        MyNameSpace.Class1 c1 = new MyNameSpace.Class1();
        c1.FirstName = "FDASFA";
        c1.LastName = "FDAFASD";



        string lastName = c1.LastName;

        c1.Age = 60;
        c1.AdultAge = 6;

        MyNameSpace.Class1 c2 = new MyNameSpace.Class1();
        c2.Age = 50;


        MyNameSpace.Class1.Address = "My address";


        int sub = Add(5, 6);

        Subtract(6, 7);

        MyNameSpace.Class1 c11 = new MyNameSpace.Class1();
        MyNameSpace.Class1 c111 = new MyNameSpace.Class1(5, 6);

	}

    public void Subtract(int a, int b)
    {
        HttpContext.Current.Response.Write(a - b);
    }

    public int Add(int a, int b)
    {
        return a + b;
    }
}

namespace  MyNameSpace
{
    public class Class1
    {
        public Class1()
        {
            // fdsafasdfadsf
        }

        public Class1(int a, int b)
        {
            Age = a + b;
        }

        ~Class1()
        {
            // dipose
        }

        public static string Address = string.Empty;

        public int Age = 0; // data member

        int _adultAge = 0;
        public int AdultAge
        {
            get { return _adultAge; }
            set
            {
                if (value < 18)
                {
                    throw new Exception("Age must be greater than 18");
                }
                else
                {
                    _adultAge = value;
                }
            }
        }

        private string _lastName = string.Empty;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }


        public string FirstName { get; set; }

    }
}
