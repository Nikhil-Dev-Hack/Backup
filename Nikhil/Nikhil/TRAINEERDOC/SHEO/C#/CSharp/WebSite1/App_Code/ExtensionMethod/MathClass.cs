using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class4
/// </summary>
public class MathClass
{
    // Assume: this is coming from the 3rd party .dll
    public MathClass()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }


    public int Divide(int a, int b)
    {
        return a / b;
    }
}