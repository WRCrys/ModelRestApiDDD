using System.Collections.Generic;
using System.Threading.Tasks;
using ModelRestApiDDD.Application.Dtos;

namespace ModelRestApiDDD.Application.Interfaces
{
    public interface IProductApplicationService
    {
        Task<IEnumerable<ProductDto>> GetAll();

        Task<ProductDto> GetById(int id);

        Task Add(ProductDto product);

        Task Update(ProductDto productDto);

        Task Remove(ProductDto productDto);
    }
}