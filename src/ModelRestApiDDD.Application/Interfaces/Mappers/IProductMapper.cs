using ModelRestApiDDD.Application.Dtos;
using ModelRestApiDDD.Domain.Entities;
using System.Collections.Generic;

namespace ModelRestApiDDD.Application.Interfaces.Mappers
{
    public interface IProductMapper
    {
        IEnumerable<ProductDto> MapperProductDtoList(IEnumerable<Product> products);

        Product MapperDtoToEntity(ProductDto productDto);

        ProductDto MapperEntityToDto(Product product);
    }
}
