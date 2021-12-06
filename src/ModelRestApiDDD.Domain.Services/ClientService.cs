using ModelRestApiDDD.Domain.Core.Interfaces.Repositories;
using ModelRestApiDDD.Domain.Core.Interfaces.Services;
using ModelRestApiDDD.Domain.Entities;

namespace ModelRestApiDDD.Domain.Services
{
    public class ClientService : Service<Client>, IClientService
    {
        private readonly IClientRepository _repository;

        public ClientService(IClientRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}