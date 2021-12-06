using ModelRestApiDDD.Application.Dtos;
using ModelRestApiDDD.Application.Interfaces.Mappers;
using ModelRestApiDDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ModelRestApiDDD.Application.Mappers
{
    public class ProductMapper : IProductMapper
    {
        public IEnumerable<ProductDto> MapperProductDtoList(IEnumerable<Product> products)
        {
            var dto = products.Select(product => new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Value = product.Value
            });

            return dto;
        }

        public Product MapperDtoToEntity(ProductDto productDto)
        {
            var product = new Product
            {
                Id = productDto.Id > 0 ? productDto.Id.Value : 0,
                Name = productDto.Name,
                Value = productDto.Value
            };

            return product;
        }

        public ProductDto MapperEntityToDto(Product product)
        {
            var productDto = new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Value = product.Value
            };

            return productDto;
        }
    }
}
