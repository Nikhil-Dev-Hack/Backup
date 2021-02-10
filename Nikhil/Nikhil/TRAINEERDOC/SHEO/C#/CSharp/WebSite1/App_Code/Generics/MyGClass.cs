using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MyGClass
/// </summary>
public class MyGClass<T>
{
    T _myType;
    //int age;

	public MyGClass(T t)
	{
        _myType = t;
	}

    public string GetData()
    {
        return "Passed data is " + _myType + " of " + _myType.GetType() + " type";
    }
}