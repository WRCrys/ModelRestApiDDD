using ModelRestApiDDD.Domain.Core.Interfaces.Repositories;
using ModelRestApiDDD.Domain.Entities;

namespace ModelRestApiDDD.Infrastructure.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ModelRestApiContext _context;

        public ProductRepository(ModelRestApiContext context) : base(context)
        {
            _context = context;
        }
    }
}