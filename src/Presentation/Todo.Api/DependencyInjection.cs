using Microsoft.EntityFrameworkCore;
using Todo.Infra.Persistance.Entities;

namespace Todo.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {

        var connectionString = configuration.GetConnectionString("TodoAppDB");



        // services.AddDbContext<TodoDbContext>(options => options.UseSqlite(connectionString));
        services.AddSqlite<TodoDbContext>(connectionString);


        return services;

    }

}
