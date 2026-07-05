namespace Todo.Domain.DomainEntities;

public class TodoListDomain
{

    public required string Name { get; set; }
    public required string Description { get; set; }

    public required Guid UserId { get; set; }

    public UserDomain? User { get; set; }



}
