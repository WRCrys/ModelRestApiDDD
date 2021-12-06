using ModelRestApiDDD.Application.Dtos;
using ModelRestApiDDD.Application.Interfaces;
using ModelRestApiDDD.Application.Interfaces.Mappers;
using ModelRestApiDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ModelRestApiDDD.Application
{
    public class ClientApplicationService : IClientApplicationService
    {
        private readonly IClientService _service;
        private readonly IClientMapper _mapper;

        public ClientApplicationService(IClientService service, IClientMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task Add(ClientDto clientDto)
        {
            var client = _mapper.MapperDtoToEntity(clientDto);
            await _service.Add(client);
        }

        public async Task<IEnumerable<ClientDto>> GetAll()
        {
            var clients = await _service.GetAll();
            return _mapper.MapperClientDtoList(clients);
        }

        public async Task<ClientDto> GetById(int id)
        {
            var client = await _service.GetById(id);
            return _mapper.MapperEntityToDto(client);
        }

        public async Task Remove(ClientDto clientDto)
        {
            var client = _mapper.MapperDtoToEntity(clientDto);
            await _service.Remove(client);
        }

        public async Task Update(ClientDto clientDto)
        {
            var newClient = _mapper.MapperDtoToEntity(clientDto);
            await _service.Update(newClient);
        }
    }
}
