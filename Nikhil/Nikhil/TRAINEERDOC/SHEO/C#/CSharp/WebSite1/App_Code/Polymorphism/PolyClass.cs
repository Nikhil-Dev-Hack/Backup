using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PolyClass
/// </summary>
public class PolyClass : PolyParent
{
	public PolyClass()
	{
		//
		// TODO: Add constructor logic here
		//
	}


    protected string Sum(int a, int b)
    {
        return "The sum is :" + (a + b);
    }


    public string Sum(int a, int b, int c)
    {
        return "The sum of these three number is :" + (a + b + c);
    }

    public override string Multiply(int a, int b)
    {
        // write some logic
        return base.Multiply(a, b);
        return "<b>The multiplication of two numbers is (Coming from Child Class): </b>" 
            + a * b;
    }


}










