using Autofac;

namespace ModelRestApiDDD.Infrastructure.CrossCutting.Ioc
{
    public class IocModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            IocConfig.Load(builder);
        }
    }
}
