using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CityInfoAPI.Models;
using CityInfoAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CityInfoAPI.Controllers
{
    [Route("api/cities/{cityId}/pointsofinterest")]
    [ApiController]
    public class PointOfInterestsController : ControllerBase
    {
        private readonly ILogger<PointOfInterestsController> _logger;
        private readonly IMailService _mailService;
        private readonly ICityInfoRepository _infoRepository;
        private readonly IMapper _mapper;

        public PointOfInterestsController(ILogger<PointOfInterestsController> logger, IMailService mailService, ICityInfoRepository infoRepository, IMapper mapper)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mailService = mailService ?? throw new ArgumentNullException(nameof(mailService));
            _infoRepository = infoRepository ?? throw new ArgumentNullException(nameof(infoRepository));
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetPointsOfInterest(int cityId)
        {
            try
            {
                // throw new Exception("Exception example.");
                if (!_infoRepository.CityExists(cityId))
                {
                    _logger.LogInformation($"City with id {cityId} wasn't found when " +
                        $"accessing points of interest.");
                    return NotFound();
                }

                var pointsOfInterestForCity = _infoRepository.GetPointsOfInterestForCity(cityId);
                return Ok(_mapper.Map<IEnumerable<PointOfInterestDto>>(pointsOfInterestForCity));
            }
            catch (Exception ex)
            {
                _logger.LogCritical($"Exception while getting points of interest for city with id {cityId}.", ex);
                return StatusCode(500, "A problem happened while handling your request.");
            }
        }

        [HttpGet("{id}", Name = "GetPointOfInterest")]
        public IActionResult GetPointOfInterest(int cityId, int id)
        {
            if (!_infoRepository.CityExists(cityId))
            {
                return NotFound();
            }

            var pointOfInterest = _infoRepository.GetPointOfInterestForCity(cityId, id);

            if (pointOfInterest == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<PointOfInterestDto>(pointOfInterest));
        }

        [HttpPost]
        public IActionResult CreatePointOfIntrest(int cityId, [FromBody] PointOfInterestForCreationDto pointOfInterest)
        {
            if (pointOfInterest.Description == pointOfInterest.Name)
            {
                ModelState.AddModelError(
                    "Description",
                    "The provided description should be different from the name.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!_infoRepository.CityExists(cityId))
            {
                return NotFound();
            }

            var finalPointOfInterest = _mapper.Map<Entities.PointOfIntrest>(pointOfInterest);

            _infoRepository.AddPointOfInterestForCity(cityId, finalPointOfInterest);

            _infoRepository.Save();

            var createdPointOfInterestToReturn = _mapper
                .Map<Models.PointOfInterestDto>(finalPointOfInterest);

            return CreatedAtRoute(
                "GetPointOfInterest",
                new { cityId, id = createdPointOfInterestToReturn.Id },
                createdPointOfInterestToReturn);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePointOfInterest(int cityId, int id, [FromBody] PointOfInterestForCreationDto pointOfInterest)
        {
            if (pointOfInterest.Description == pointOfInterest.Name)
            {
                ModelState.AddModelError(
                    "Description",
                    "The provided description should be different from the name.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!_infoRepository.CityExists(cityId))
            {
                return NotFound();
            }

            var pointOfInterestEntity = _infoRepository
                .GetPointOfInterestForCity(cityId, id);
            if (pointOfInterestEntity == null)
            {
                return NotFound();
            }

            _mapper.Map(pointOfInterest, pointOfInterestEntity);

            _infoRepository.UpdatePointOfInterestForCity(cityId, pointOfInterestEntity);

            _infoRepository.Save();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePointOfInterest(int cityId, int id)
        {
            if (!_infoRepository.CityExists(cityId))
            {
                return NotFound();
            }

            var pointOfInterestEntity = _infoRepository
                .GetPointOfInterestForCity(cityId, id);
            if (pointOfInterestEntity == null)
            {
                return NotFound();
            }

            _infoRepository.DeletePointOfInterest(pointOfInterestEntity);

            _infoRepository.Save();

            _mailService.Send("Point of interest deleted.",
                    $"Point of interest {pointOfInterestEntity.Name} with id {pointOfInterestEntity.Id} was deleted.");

            return NoContent();
        }

    }
}
