using Microsoft.EntityFrameworkCore;

namespace Todo.Infra.Persistance.Entities;

public class TodoDbContext(DbContextOptions<TodoDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }

}
