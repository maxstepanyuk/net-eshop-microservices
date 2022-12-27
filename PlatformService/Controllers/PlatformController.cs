using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PlatformService.Dtos;
using PlatformService.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;

namespace PlatformService.Controllers
{
    [Route("api/[controller]")]// same as - [Route("api/platforms")]
    [ApiController]

    public class PlatformsController : ControllerBase
    {
        private readonly IPlatformRepo _repository;
        private readonly IMapper _mapper;

        public PlatformsController(IPlatformRepo repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PlatformReadDto>> GetPlatforms()
        {
            try
            {
                Console.WriteLine("--> Getting Platforms");
                var platformItem = _repository.GetAllPlatforms();
                Console.WriteLine("--> Returning Platforms");
                return Ok(_mapper.Map<IEnumerable<PlatformReadDto>>(platformItem));
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message});
            }
        }

        [HttpGet("{id}", Name = "GetPlatformById")] //uri -  HttpPost
        public ActionResult<PlatformReadDto> GetPlatformById(int id)
        {
            try
            {
                Console.WriteLine("--> Getting Platform - "+ id);
                var platformItem = _repository.GetPlatformById(id);
                if (platformItem == null)
                {
                    return NotFound();
                }
                Console.WriteLine("--> Returning Platform - "+ id);
                return Ok(_mapper.Map<PlatformReadDto>(platformItem));
        
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message});
            }
        }

        [HttpPost]
        public ActionResult<PlatformReadDto> CreatePlatform(PlatformCreateDto platformCreateDto)
        {
            try
            {

                Console.WriteLine("--> Saving Platform");
                var palatformModel = _mapper.Map<Platform>(platformCreateDto);
                _repository.CreatePlatform(palatformModel);
                _repository.SaveChanges();

                var platformReadDto = _mapper.Map<PlatformReadDto>(palatformModel);

                Console.WriteLine("--> Returning saved Platform");
                return CreatedAtRoute(nameof(GetPlatformById), new {Id = platformReadDto.Id}, platformReadDto);

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message});
            }
            
        }
    }
}