using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MirexManager.Domain.Abstractions;
using MirexManager.Infrastructure.Contexts;
using MirexManager.Infrastructure.Respositories;

namespace MirexManager.Infrastructure;

public static class DependencyInjection
{
    private static readonly string CONNECTION_STRING = "Database";
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString(CONNECTION_STRING));
        });

        services.AddScoped<IClientRepository, ClientRepository>();
        services.AddScoped<ICompanyRepository, CompanyRepository>();

        return services;
    }
}