using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Articles
/// </summary>
public class Articles
{
    /// <summary>
    /// Age of the article
    /// </summary>
    public static int Age = 30;

    /// <summary>
    /// Full name of the article
    /// </summary>
    public string MyFullName { get; private set; }

    public string FullName = string.Empty;
    
    	
    public Articles()
	{
        FullName = "Default data";
	}

    ~Articles()
    {
        
    }


    /// <summary>
    /// set full of the article
    /// </summary>
    /// <param name="defaultData">Pass the default data to set the value</param>
    public Articles(string defaultData)
    {
        FullName = defaultData;
    }

    /// <summary>
    /// Get my name
    /// </summary>
    /// <returns>it will return a string</returns>
    public string GetMyName()
    {
        return MyFullName;
    }


    public string GetName()
    {
        return " " + FullName;
    }
}