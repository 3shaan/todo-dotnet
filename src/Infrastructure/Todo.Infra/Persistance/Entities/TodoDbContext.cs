using Microsoft.EntityFrameworkCore;

namespace Todo.Infra.Persistance.Entities;

public class TodoDbContext(DbContextOptions<TodoDbContext> options) : DbContext(options)
{


    public DbSet<User> Users { get; set; }
    public DbSet<TodoList> TodoLists { get; set; }
    public DbSet<TodoItems> TodoItems { get; set; }
    public DbSet<Tags> Tags { get; set; }
    public DbSet<TodoItemTag> TodoItemTags { get; set; }
    public DbSet<Comments> Comments { get; set; }
    public DbSet<ActivityLog> ActivityLogs { get; set; }

}
