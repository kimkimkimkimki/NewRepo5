using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hepsiburada.Application.DTOs.ItemDTOs;
using Hepsiburada.Application.ServiceInterfaces;

namespace Hepsiburada.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemsController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateItemDto userDto)
        {
            _itemService.Create(userDto);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UpdateItemDto userDto)
        {
            _itemService.Update(id, userDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _itemService.Delete(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var entity = _itemService.GetById(id).Result;
            return Ok(entity);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var list = _itemService.GetAll().Result;
            return Ok(list);
        }
    }
}
