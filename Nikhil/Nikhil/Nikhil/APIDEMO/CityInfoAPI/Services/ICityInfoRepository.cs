using CityInfoAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfoAPI.Services
{
    public interface ICityInfoRepository
    {
        IEnumerable<City> GetCities();

        City GetCity(int cityId, bool includePointsOfInterest);

        IEnumerable<PointOfIntrest> GetPointsOfInterestForCity(int cityId);

        PointOfIntrest GetPointOfInterestForCity(int cityId, int pointOfInterestId);

        bool CityExists(int cityId);

        void AddPointOfInterestForCity(int cityId, PointOfIntrest pointOfInterest);

        void UpdatePointOfInterestForCity(int cityId, PointOfIntrest pointOfInterest);

        void DeletePointOfInterest(PointOfIntrest pointOfInterest);

        bool Save();

    }
}
