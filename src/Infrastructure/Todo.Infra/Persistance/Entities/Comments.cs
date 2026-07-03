namespace Todo.Infra.Persistance.Entities;

public class Comments : BaseAuditableEntity
{

    public Guid TodoItemId { get; set; }

    public TodoItems? TodoItem { get; set; }

    public Guid UserId { get; set; }

    public User? User { get; set; }


    public required string Message { get; set; } = string.Empty;

}
