using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for IClass6
/// </summary>
public interface IClass6
{
    string FirstName { get; set; }

    int Add(int a, int b);

    int Update(int a, int b);    

    int Delete(int a, int b);

    string Load();

}