using ModelRestApiDDD.Application.Dtos;
using ModelRestApiDDD.Domain.Entities;
using System.Collections.Generic;

namespace ModelRestApiDDD.Application.Interfaces.Mappers
{
    public interface IClientMapper
    {
        IEnumerable<ClientDto> MapperClientDtoList(IEnumerable<Client> clients);

        Client MapperDtoToEntity(ClientDto clientDto);

        ClientDto MapperEntityToDto(Client client);
    }
}
