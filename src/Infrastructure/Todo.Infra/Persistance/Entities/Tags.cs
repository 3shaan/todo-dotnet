namespace Todo.Infra.Persistance.Entities;

public class Tags : BaseAuditableEntity
{
    public required string Name { get; set; }

    public required string ColorCode { get; set; }


    public ICollection<TodoItemTag> TodoItemTags { get; set; } = [];

}
