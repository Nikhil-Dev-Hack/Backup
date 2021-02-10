using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class2
/// </summary>
public static class Class2
{
    //public Class2()
    //{
    //    //
    //    // TODO: Add constructor logic here
    //    //
    //}


    /// <summary>
    /// This returns the custom string
    /// </summary>
    /// <param name="class1"></param>
    /// <param name="customString"></param>
    /// <returns>string data type</returns>
    public static string ToCustomString(this Class1 class1, string customString)
    {
        return "My custom string: " + customString;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="c1"></param>
    /// <param name="myString"></param>
    /// <returns></returns>
    public static string ToString(this Class1 c1, string myString)
    {
        return "The class name is: " + myString;
    }
}