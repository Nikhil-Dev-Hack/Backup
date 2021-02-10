using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PAREXEL
/// </summary>
public partial class Company
{

    public int TurnOver = 0;

    public Company()
    {
        //
        // TODO: Add constructor logic here
        //
        Name = "PAREXEL  PRivate";
    }

    public Company(string name, string location)
    {
        Name = name;
        Location = location;
    }

    public int NumberOfEmployees { get; set; }

    public string Name { get; set; }

    public string Location { get; set;}

    private int _numberOfBranches = 0;
    public int NumberOfBranches
    {
        get
        {
            return _numberOfBranches;
        }
        set
        {
            _numberOfBranches = value;
        }
    }

    public string GetDetails()
    {
        return Name + "<br />" + Location + "<br />" + NumberOfEmployees + "<br />" + TurnOver;
    }

    public static string GetMyDetails()
    {
        return "PAREXEL STATIC DATA";
    }

    ~Company()
    {
        // nullify them
    }

}