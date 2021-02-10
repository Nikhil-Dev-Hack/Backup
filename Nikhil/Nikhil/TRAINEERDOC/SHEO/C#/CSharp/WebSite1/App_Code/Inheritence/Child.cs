using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Child
/// </summary>
public class Child : Parent
{
	public Child()
	{
		//
		// TODO: Add constructor logic here
		//
	}


    public string LastName { get; set; }

    public string GetName()
    {
        string s = GetFirstName();

        return FirstName + " : " + LastName;
    }
}