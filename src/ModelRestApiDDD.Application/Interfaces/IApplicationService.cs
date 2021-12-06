using System.Collections.Generic;
using System.Threading.Tasks;
using ModelRestApiDDD.Application.Dtos;

namespace ModelRestApiDDD.Application.Interfaces
{
    public interface IApplicationService<TDto> where TDto : Dto
    {
        Task<IEnumerable<TDto>> GetAll();

        Task<TDto> GetById(int id);

        Task Add(TDto dto);

        Task Update(TDto dto);

        Task Remove(TDto dto);
    }
}