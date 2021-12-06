using ModelRestApiDDD.Domain.Core.Interfaces.Repositories;
using ModelRestApiDDD.Domain.Entities;

namespace ModelRestApiDDD.Infrastructure.Data.Repositories
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        private readonly ModelRestApiContext _context;

        public ClientRepository(ModelRestApiContext context) : base(context)
        {
            _context = context;
        }
    }
}