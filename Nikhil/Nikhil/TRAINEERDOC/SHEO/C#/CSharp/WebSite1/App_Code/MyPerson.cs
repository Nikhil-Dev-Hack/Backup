using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalDetails
{
    /// <summary>
    /// Summary description for MyPerson
    /// </summary>
    public class MyPerson
    {

        public static int Salary = 54464646;


        public string SchoolName = string.Empty;

        public MyPerson()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public MyPerson(string firstName, string lastName)
        {
            string mySchool = string.Empty;

            FirstName = firstName;
            LastName = lastName;
        }


        private int _age = 0;
        public int Age
        {
            get { return _age; }
            set { 
                if (value < 18)
                {
                    throw new ApplicationException("Sorry, age can't be less than 18");
                }
                _age = value; 
            }
        }


        public string FirstName { get; set; }
        public string LastName { get; set; }


        public string GetName()
        {
            return FirstName + " " + LastName;
        }

        public static string GetFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }

        ~MyPerson()
        {
            // objec = null;
        }

    }
}