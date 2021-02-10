using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SureAeroplane
/// </summary>
public class SureAeroplane
{
    // fields / public fields/members
    public int PlaneId = 0;
    public int Wheels = 0;

    /// <summary>
    /// Manufacturer of this plane
    /// </summary>
    public string Manufacturer = string.Empty;


    //== properties


    private int _capacity = 0;
    public int Capacity
    {
        get
        {
            return _capacity;
        }
        set
        {
            if (value > 1000)
            {
                throw new ApplicationException("Sorry, the data seems wrong");
            }
            else
            {
                _capacity = value;
            }
        }
    }

    /// <summary>
    /// Location of the plane
    /// </summary>
    public string Location { get; set; }


    /// <summary>
    /// Color of the Plane
    /// </summary>
    public string Color { get; set; }

    /// <summary>
    /// This method returns the details of this plane
    /// </summary>
    /// <returns></returns>
    public string GetPlaneDetails()
    {
        string returnValue = Manufacturer + " " + Wheels + " " + Capacity + " " + Color;
        return returnValue;
    }

    /// <summary>
    /// This method returns the current location of this plane
    /// </summary>
    /// <param name="planneId">Unique id of this plane</param>
    /// <returns></returns>
    public string GetPlaneLocation(int planneId)
    {
        // doing some database operations

        return Location;
    }

}