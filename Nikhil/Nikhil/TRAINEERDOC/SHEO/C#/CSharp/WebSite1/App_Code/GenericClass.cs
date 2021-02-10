using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GenericClass
/// </summary>
public class GenericClass<T>
{
    public string FirstName { get; set; }
    public GenericClass()
    {
        //
        // TODO: Add constructor logic here
        //
        
        

    }

	public GenericClass(T obj)
	{
        FirstName = obj.ToString();   
		//
		// TODO: Add constructor logic here
		//
	}
}