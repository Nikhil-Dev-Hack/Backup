using CityInfoAPI.Contexts;
using CityInfoAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfoAPI.Services
{
    public class CityInfoRepository : ICityInfoRepository
    {
        private readonly CityInfoContext _context;

        public CityInfoRepository(CityInfoContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<City> GetCities()
        {
            return _context.Cities.OrderBy(c => c.Name).ToList();
        }

        public City GetCity(int cityId, bool includePointsOfInterest)
        {
            if (includePointsOfInterest)
            {
                return _context.Cities.Include(c => c.PointOfIntrests)
                    .Where(c => c.Id == cityId).FirstOrDefault();
            }

            return _context.Cities
                    .Where(c => c.Id == cityId).FirstOrDefault();
        }

        public PointOfIntrest GetPointOfInterestForCity(int cityId, int pointOfInterestId)
        {
            return _context.PointOfIntrests
               .Where(p => p.CityId == cityId && p.Id == pointOfInterestId).FirstOrDefault();
        }

        public IEnumerable<PointOfIntrest> GetPointsOfInterestForCity(int cityId)
        {
            return _context.PointOfIntrests
                          .Where(p => p.CityId == cityId).ToList();
        }

        public bool CityExists(int cityId)
        {
            return _context.Cities.Any(c => c.Id == cityId);
        }

        public void AddPointOfInterestForCity(int cityId, PointOfIntrest pointOfInterest)
        {
            var city = GetCity(cityId, false);
            city.PointOfIntrests.Add(pointOfInterest);
        }

        public void UpdatePointOfInterestForCity(int cityId, PointOfIntrest pointOfInterest)
        {

        }

        public void DeletePointOfInterest(PointOfIntrest pointOfInterest)
        {
            _context.PointOfIntrests.Remove(pointOfInterest);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
