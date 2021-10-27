using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hepsiburada.Application.DTOs.UserDTOs;
using Hepsiburada.Application.ServiceInterfaces;

namespace Hepsiburada.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateUserDto userDto)
        {
            _userService.Create(userDto);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id,[FromBody] UpdateUserDto userDto)
        {
            _userService.Update(id,userDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete( int id)
        {
            _userService.Delete(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var entity=_userService.GetById(id).Result;
            return Ok(entity);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var list=_userService.GetAll().Result;
            return Ok(list);
        }

    }
}
