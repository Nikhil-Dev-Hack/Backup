using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PolyParent
/// </summary>
public class PolyParent
{
	public PolyParent()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    private int Subtract(int a, int b)
    {
        return a - b;
    }

    public virtual string Multiply(int a, int b)
    {
        return "The multiplication of two numbers is:" + a * b;
    }
}