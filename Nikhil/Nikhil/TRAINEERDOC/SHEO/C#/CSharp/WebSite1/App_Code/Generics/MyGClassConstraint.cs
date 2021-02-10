using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class7
/// </summary>
public class MyGClassConstraint<T> where T : IDisposable
{
    T _value;

	public MyGClassConstraint()
	{
        
	}
}