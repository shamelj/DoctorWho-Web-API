﻿using AutoMapper;
using DoctorWho.Web.Models;
using DoctorWho.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace DoctorWho.Web.Controllers
{
    [Route("api/doctor")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;
        private readonly IMapper _mapper;


        public DoctorController(IDoctorService doctorService, IMapper mapper)
        {
            _doctorService = doctorService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<DoctorDto>>> GetAllDoctors()
        {
            return Ok(await _doctorService.GetAllDoctorsAsync());
        }

        [HttpPost]
        public async Task<ActionResult<DoctorDto>> CreateDoctor([FromBody] DoctorCreationDto doctorCreationDto)
        {
            var doctorDto = await _doctorService.CreateDoctor(_mapper.Map<DoctorDto>(doctorCreationDto));
            return Ok(doctorDto);
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult<DoctorDto>> UpdateDoctor([FromRoute] int id, [FromBody] DoctorCreationDto doctorCreationDto)
        {
            if (! await _doctorService.DoctorExists(id))
                return NotFound();
            var doctorDto = await _doctorService.UpdateDoctorAsync(id, _mapper.Map<DoctorDto>(doctorCreationDto));
            return Ok(doctorDto);
        }
    }
}
