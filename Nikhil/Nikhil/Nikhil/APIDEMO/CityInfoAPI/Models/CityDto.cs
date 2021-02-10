﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfoAPI.Models
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberOfPointsOfInterest
        {
            get
            {
                return PointOfInterests.Count;
            }
        }
        public ICollection<PointOfInterestDto> PointOfInterests{ get; set; } = new List<PointOfInterestDto>();
    }
}
