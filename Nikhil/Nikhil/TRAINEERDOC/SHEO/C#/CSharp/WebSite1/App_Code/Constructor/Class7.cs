using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class7
/// </summary>
///             
public class Class7
{
    int _age = 0;

	public Class7()
	{
        _age = 50;
	}

    public Class7(int age)
    {
        _age = age;
    }

    public Class7(int age, string s)
    {
        _age = age;
    }

    public int GetAge()
    {
        return _age;
    }

    ~Class7()
    {
        
    }
}