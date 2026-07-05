using Microsoft.EntityFrameworkCore;
using Todo.Infra.Persistance.Configuration;

namespace Todo.Infra.Persistance.Entities;

public class TodoDbContext(DbContextOptions<TodoDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        new UserConfiguration().Configure(modelBuilder.Entity<User>());

        modelBuilder.Entity<TodoList>().HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<TodoItems>().HasOne(x => x.TodoList).WithMany(x => x.TodoItems).HasForeignKey(x => x.TodoListId).OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Comments>().HasOne(x => x.TodoItem).WithMany(x => x.Comments).HasForeignKey(x => x.TodoItemId).OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Comments>().HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<TodoItemTag>().HasOne(x => x.Tag).WithMany(x => x.TodoItemTags).HasForeignKey(x => x.TagId).OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<TodoItemTag>().HasOne(x => x.TodoItem).WithMany(x => x.TodoItemTags).HasForeignKey(x => x.TodoItemId).OnDelete(DeleteBehavior.Cascade);
    }

    public DbSet<User> Users { get; set; }
    public DbSet<TodoList> TodoLists { get; set; }
    public DbSet<TodoItems> TodoItems { get; set; }
    public DbSet<Tags> Tags { get; set; }
    public DbSet<TodoItemTag> TodoItemTags { get; set; }
    public DbSet<Comments> Comments { get; set; }
    public DbSet<ActivityLog> ActivityLogs { get; set; }




}
