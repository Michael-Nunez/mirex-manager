using Microsoft.Extensions.DependencyInjection;
using MirexManager.Application.Abstracts;
using MirexManager.Application.Clients;

namespace MirexManager.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IClientService, ClientService>();
        return services;
    }
}