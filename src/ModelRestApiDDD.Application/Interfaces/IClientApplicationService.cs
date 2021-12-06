using System.Collections.Generic;
using System.Threading.Tasks;
using ModelRestApiDDD.Application.Dtos;

namespace ModelRestApiDDD.Application.Interfaces
{
    public interface IClientApplicationService
    {
        Task<IEnumerable<ClientDto>> GetAll();

        Task<ClientDto> GetById(int id);

        Task Add(ClientDto clientDto);

        Task Update(ClientDto clientDto);

        Task Remove(ClientDto clientDto);
    }
}