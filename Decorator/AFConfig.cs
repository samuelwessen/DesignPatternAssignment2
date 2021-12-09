using Autofac;

namespace Decorator
{
    public class AFConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // Register Main Application
            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<TextInput>().As<ITextInput>();

            return builder.Build();
        }
    }
}