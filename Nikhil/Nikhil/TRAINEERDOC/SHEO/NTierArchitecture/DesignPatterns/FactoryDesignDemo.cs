using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public interface IPeople
    {
        string GetName();
    }

    public class Villagers : IPeople
    {

        #region IPeople Members
        public string GetName()
        {
            return "Village Guy";
        }
        #endregion
    }

    public class CityPeople : IPeople
    {
        #region IPeople Members

        public string GetName()
        {
            return "City Guy";
        }
        #endregion
    }

    public enum PeopleType
    {
        RURAL,
        URBAN
    }

    /// <summary>
    /// Implementation of Factory - Used to create objects
    /// </summary
    public class Factory
    {
        public IPeople GetPeople(PeopleType peopleType)
        {
            IPeople people = null;
            switch (peopleType)
            {
                case PeopleType.RURAL:
                    people = new Villagers();
                    break;
                case PeopleType.URBAN:
                    people = new CityPeople();
                    break;
            }
            return people;
        }
    }
}