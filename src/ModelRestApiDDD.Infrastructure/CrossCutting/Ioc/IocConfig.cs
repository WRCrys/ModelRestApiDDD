using Autofac;
using ModelRestApiDDD.Application;
using ModelRestApiDDD.Application.Interfaces;
using ModelRestApiDDD.Application.Interfaces.Mappers;
using ModelRestApiDDD.Application.Mappers;
using ModelRestApiDDD.Domain.Core.Interfaces.Repositories;
using ModelRestApiDDD.Domain.Core.Interfaces.Services;
using ModelRestApiDDD.Domain.Services;
using ModelRestApiDDD.Infrastructure.Data.Repositories;

namespace ModelRestApiDDD.Infrastructure.CrossCutting.Ioc
{
    public class IocConfig
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ClientApplicationService>().As<IClientApplicationService>();
            builder.RegisterType<ProductApplicationService>().As<IProductApplicationService>();
            builder.RegisterType<ClientService>().As<IClientService>();
            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<ClientRepository>().As<IClientRepository>();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<ClientMapper>().As<IClientMapper>();
            builder.RegisterType<ProductMapper>().As<IProductMapper>();
        }
    }
}
