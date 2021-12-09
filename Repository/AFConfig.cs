using Autofac;

namespace Repository
{
    public class AFConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<DataRepositoryB>().As<IDataRepository>();

            return builder.Build();
        }
    }
}