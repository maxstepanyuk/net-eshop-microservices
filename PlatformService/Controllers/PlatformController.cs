using System.Collections.Generic;
using System;
//using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlatformService.Dtos;
using PlatformService.Models;
using AutoMapper;

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
            // Console.WriteLine("--> Getting Platforms");
            var platformItem = _repository.GetAllPlatforms();
            // Console.WriteLine("--> Returning Platforms");
            return Ok(_mapper.Map<IEnumerable<PlatformReadDto>>(platformItem));
        }

        [HttpGet("{id}", Name = "GetPlatformById")] //uri -  HttpPost
        public ActionResult<PlatformReadDto> GetPlatformById(int id)
        {
            // Console.WriteLine("--> Getting Platform - "+ id);
            var platformItem = _repository.GetPlatformById(id);
            if (platformItem == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<PlatformReadDto>(platformItem));
        }

        [HttpPost]
        public ActionResult<PlatformReadDto> CreatePlatform(PlatformCreateDto platformCreateDto)
        {
            var palatformModel = _mapper.Map<Platform>(platformCreateDto);
            _repository.CreatePlatform(palatformModel);
            _repository.SaveChanges();

            var platformReadDto = _mapper.Map<PlatformReadDto>(palatformModel);
            //todo here
            
            return CreatedAtRoute(nameof(GetPlatformById), new {Id = platformReadDto.Id}, platformReadDto);
        }
    }
}