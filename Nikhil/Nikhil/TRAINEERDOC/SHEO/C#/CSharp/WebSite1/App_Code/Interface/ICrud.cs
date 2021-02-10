using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Investigator
/// </summary>
internal interface ICrud
{

    int MyProperty { get; set; }
    string Add(int a, int b);
    void Edit();
    void Delete();
    void List();
}