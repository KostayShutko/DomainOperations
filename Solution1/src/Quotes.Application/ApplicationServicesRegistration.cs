﻿using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Quotes.Application;

public static class ApplicationServicesRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        var executingAssembly = Assembly.GetExecutingAssembly();

        services.AddAutoMapper(executingAssembly);
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(executingAssembly));

        return services;
    }
}
