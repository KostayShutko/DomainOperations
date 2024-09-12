using Microsoft.Extensions.DependencyInjection;
using Quotes.Domain.BusinessRules;
using Quotes.Domain.Operations;
using System.Reflection;

namespace Quotes.Domain;

public static class DomainServicesRegistration
{
    public static IServiceCollection AddDomainServices(this IServiceCollection services)
    {
        services.RegisterServiceImplementationsOf<IOperation>();
        services.RegisterServiceImplementationsOf<IBusinessRule>();
        return services;
    }

    private static void RegisterServiceImplementationsOf<TInterface>(this IServiceCollection services)
    {
        var interfaceType = typeof(TInterface);
        var executingAssembly = Assembly.GetExecutingAssembly();
        var types = executingAssembly
            .GetTypes()
            .Where(type => interfaceType.IsAssignableFrom(type) && type.IsClass && !type.IsAbstract);

        foreach (var type in types)
        {
            var interfaces = type.GetInterfaces().Where(i => i != interfaceType);
            foreach (var @interface in interfaces)
            {
                services.AddTransient(@interface, type);
            }
        }
    }
}