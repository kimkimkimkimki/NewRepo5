using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hepsiburada.Application.DTOs.ProductDTOs;
using Hepsiburada.Application.ServiceInterfaces;

namespace Hepsiburada.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateProductDto userDto)
        {
            _productService.Create(userDto);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UpdateProductDto userDto)
        {
            _productService.Update(id, userDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productService.Delete(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var entity = _productService.GetById(id).Result;
            return Ok(entity);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var list = _productService.GetAll().Result;
            return Ok(list);
        }
    }
}
