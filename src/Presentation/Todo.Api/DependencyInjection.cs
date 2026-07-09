using Mapster;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Todo.Application.Contracts;
using Todo.Application.Implementation;
using Todo.Infra.Persistance.Entities;

namespace Todo.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {

        var connectionString = configuration.GetConnectionString("TodoAppDB");



        // services.AddDbContext<TodoDbContext>(options => options.UseSqlite(connectionString));
        services.AddSqlite<TodoDbContext>(connectionString);

        // add mapster
        services.AddSingleton(TypeAdapterConfig.GlobalSettings);
        services.AddScoped<IMapper, ServiceMapper>();


        return services;

    }

    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();

        return services;

    }

}
