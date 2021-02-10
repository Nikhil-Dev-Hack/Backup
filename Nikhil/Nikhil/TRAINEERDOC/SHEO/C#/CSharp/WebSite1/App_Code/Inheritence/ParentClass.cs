using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ParentClass
/// </summary>
public class Parent
{
	public Parent()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    private string PrivateFirstName { get; set; }

    protected string FirstName { get; set; }

    public string GetFirstName()
    {
        return FirstName;
    }

}