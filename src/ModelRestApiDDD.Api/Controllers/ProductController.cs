using Microsoft.AspNetCore.Mvc;
using ModelRestApiDDD.Application.Dtos;
using ModelRestApiDDD.Application.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ModelRestApiDDD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductApplicationService _application;

        public ProductController(IProductApplicationService application)
        {
            _application = application;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductDto>> GetAll()
        {
            return await _application.GetAll();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProductDto>> GetById(int id)
        {
            var product = await _application.GetById(id);

            if (product == null)
                return NotFound("There isn't any product with id provided");

            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<ProductDto>> Add(ProductDto productDto)
        {
            if (productDto == null)
                return BadRequest("There isn't any data for insert in database");

            await _application.Add(productDto);

            return Ok(productDto);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<ProductDto>> Update(int id, ProductDto productDto)
        {
            if (productDto == null)
                return BadRequest("There isn't any data for update in database");

            if (productDto.Id != id)
                return BadRequest("The id provided is different of product's id");

            await _application.Update(productDto);

            return Ok(productDto);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Remove(int id)
        {
            var product = await _application.GetById(id);

            if (product == null)
                return NotFound("There isn't any product with id provided");

            await _application.Remove(product);

            return Ok(product);
        }
    }
}
