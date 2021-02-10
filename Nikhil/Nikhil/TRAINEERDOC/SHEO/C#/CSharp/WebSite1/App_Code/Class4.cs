using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class4
/// </summary>
public class Class4
{
   // public string FirstName { get; } // property
    // public string LastName { set; }

    public string myName = string.Empty; // member variable / field / data member


	public Class4()
	{
		//
		// TODO: Add constructor logic here
		//        
        myName = "Something";
	}


    public Class4(string name)
    {
        //
        // TODO: Add constructor logic here
        //        
        myName = name;
    }
}