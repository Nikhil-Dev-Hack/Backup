using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GetSet : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    
        Person p = new Person()
        {
            FullName = "Vishal Bedre",
            Age = 18
        };
    }

    public class Person
    {
        public string FullName { get; set; }

        private int _age = 0;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                //if (value < 18)
                //{
                //    throw new ArgumentException("Age must not be less than 18");
                //}
                _age = value;
            }
        }
    }
}