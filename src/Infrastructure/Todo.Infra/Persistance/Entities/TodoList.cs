namespace Todo.Infra.Persistance.Entities;

public class TodoList : BaseAuditableEntity
{

    public required string Name { get; set; }
    public required string Description { get; set; }

    public required Guid UserId { get; set; }

    public User? User { get; set; }


    public ICollection<TodoItemTag> TodoItems { get; set; } = [];

}
