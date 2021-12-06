using ModelRestApiDDD.Domain.Core.Interfaces.Repositories;
using ModelRestApiDDD.Domain.Core.Interfaces.Services;
using ModelRestApiDDD.Domain.Entities;

namespace ModelRestApiDDD.Domain.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}