using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class8
/// </summary>
public class Machine
{
    public string MachineType = string.Empty;


    public string Name { get; set; }

    private string _weight = string.Empty;
    public string Weight
    {
        get
        {
            // some logic

            return _weight;
        }
        set
        {
            _weight = value;
        }
    }

    private int _size = 0;
    public int Size
    {
        get
        {
            return _size;
        }

        set
        {
            if (value < 5)
            {
                throw new ApplicationException("the size must not be less than 5");
            }
            _size = value;
        }
    }

    public string GetMachineDetails()
    {
        return Name + " " + Weight;
    }
}
