using ModelRestApiDDD.Application.Dtos;
using ModelRestApiDDD.Application.Interfaces.Mappers;
using ModelRestApiDDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ModelRestApiDDD.Application.Mappers
{
    public class ClientMapper : IClientMapper
    {
        public IEnumerable<ClientDto> MapperClientDtoList(IEnumerable<Client> clients)
        {
            var dto = clients.Select(client => new ClientDto
            {
                Id = client.Id,
                FirstName = client.FirstName,
                LastName = client.LastName,
                Email = client.Email
            });

            return dto;
        }

        public Client MapperDtoToEntity(ClientDto clientDto)
        {
            var client = new Client
            {
                Id = clientDto.Id > 0 ? clientDto.Id.Value : 0,
                FirstName = clientDto.FirstName,
                LastName = clientDto.LastName,
                Email = clientDto.Email
            };

            return client;
        }

        public ClientDto MapperEntityToDto(Client client)
        {
            var clientDto = new ClientDto
            {
                Id = client.Id,
                FirstName = client.FirstName,
                LastName = client.LastName,
                Email = client.Email
            };

            return clientDto;
        }
    }
}
