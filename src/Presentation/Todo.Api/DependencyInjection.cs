using Mapster;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Todo.Application.Contracts;
using Todo.Application.Implementation;
using Todo.Domain.RepositoryInterface;
using Todo.Infra.Persistance.Entities;
using Todo.Infra.Repository;

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

        // repo
        services.AddScoped<IUserRepository, UserRepository>();


        return services;

    }

    public static IServiceCollection AddApplication(this IServiceCollection services)
    {

        // add mapster
        services.AddSingleton(TypeAdapterConfig.GlobalSettings);
        services.AddScoped<IMapper, ServiceMapper>();


        services.AddScoped<IUserService, UserService>();

        return services;

    }

}
