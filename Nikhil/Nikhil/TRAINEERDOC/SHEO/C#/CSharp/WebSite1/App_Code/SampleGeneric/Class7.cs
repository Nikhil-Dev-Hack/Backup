using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class7
/// </summary>
public class Class7<A>
{
    A _value;

	public Class7(A t)
	{
        _value = t;
	}

    public string GetData()
    {
        return "The data type of the passed in variable is " + _value.GetType() + " and the value is " + _value;
    }

    
}