using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hepsiburada.Application.DTOs.TopListDTOs;
using Hepsiburada.Application.ServiceInterfaces;

namespace Hepsiburada.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserListsController : ControllerBase
    {
        private readonly IUserListService _topListService;

        public UserListsController(IUserListService topListService)
        {
            _topListService = topListService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateUserListDto userDto)
        {
            _topListService.Create(userDto);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UpdateUserListDto userDto)
        {
            _topListService.Update(id, userDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _topListService.Delete(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var entity = _topListService.GetById(id).Result;
            return Ok(entity);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var list = _topListService.GetAll().Result;
            return Ok(list);
        }
    }
}
