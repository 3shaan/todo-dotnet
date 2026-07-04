using Microsoft.EntityFrameworkCore;
using Todo.Infra.Persistance.Configuration;

namespace Todo.Infra.Persistance.Entities;

public class TodoDbContext(DbContextOptions<TodoDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        new UserConfiguration().Configure(modelBuilder.Entity<User>());

    }

    public DbSet<User> Users { get; set; }
    public DbSet<TodoList> TodoLists { get; set; }
    public DbSet<TodoItems> TodoItems { get; set; }
    public DbSet<Tags> Tags { get; set; }
    public DbSet<TodoItemTag> TodoItemTags { get; set; }
    public DbSet<Comments> Comments { get; set; }
    public DbSet<ActivityLog> ActivityLogs { get; set; }




}
