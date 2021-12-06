using ModelRestApiDDD.Application.Dtos;
using ModelRestApiDDD.Application.Interfaces;
using ModelRestApiDDD.Application.Interfaces.Mappers;
using ModelRestApiDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ModelRestApiDDD.Application
{
    public class ProductApplicationService : IProductApplicationService
    {
        private readonly IProductService _service;
        private readonly IProductMapper _mapper;

        public ProductApplicationService(IProductService service, IProductMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task Add(ProductDto product)
        {
            var newProduct = _mapper.MapperDtoToEntity(product);
            await _service.Add(newProduct);
        }

        public async Task<IEnumerable<ProductDto>> GetAll()
        {
            var products = await _service.GetAll();
            return _mapper.MapperProductDtoList(products);
        }

        public async Task<ProductDto> GetById(int id)
        {
            var product = await _service.GetById(id);
            return _mapper.MapperEntityToDto(product);
        }

        public async Task Remove(ProductDto productDto)
        {
            var product = _mapper.MapperDtoToEntity(productDto);
            await _service.Remove(product);
        }

        public async Task Update(ProductDto productDto)
        {
            var newProdutc = _mapper.MapperDtoToEntity(productDto);
            await _service.Update(newProdutc);
        }
    }
}
