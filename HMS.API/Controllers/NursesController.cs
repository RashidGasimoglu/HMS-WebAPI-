﻿using HMS.BLL.Services.Interfaces;
using HMS.DAL.DBModel;
using HMS.DAL.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NursesController : ControllerBase
    {
        private readonly IGenericService<NurseDto, Nurse> _service;




        public NursesController(IGenericService<NurseDto, Nurse> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<NurseDto>>> GetList()
        {
            var response = await _service.GetListAsync();
            return response;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<NurseDto>> GetByIdAsync(int id)

        {
            if (id == 0)
            {
                return BadRequest();
            }

            var response = await _service.GetByIdAsync(id);
            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<NurseDto>> Create(NurseDto itemDto)
        {

            var response = await _service.AddAsync(itemDto);
            return Ok(response);
        }

        [HttpPut("{id:int}")]
        public ActionResult<NurseDto> Update(int id, [FromBody] NurseDto obj)
        {
            if (id == 0 || id != obj.Id)
            {
                return BadRequest();
            }

            var response = _service.GetByIdAsync(id).Result;
            if (response == null)
            {
                return NotFound();
            }

            response = _service.Update(obj);
            return Ok(response); ;
        }

        [HttpDelete("{id:int}")]

        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var response = _service.GetByIdAsync(id).Result;
            if (response == null)
            {
                return NotFound();
            }

            _service.Delete(id);
            return NoContent();
        }
    }
}
