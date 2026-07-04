namespace Todo.Infra.Persistance.Entities;

public class TodoItemTag
{

    public Guid Id { get; set; }

    public Guid TodoItemId { get; set; }

    public TodoItems? TodoItem { get; set; }

    public Guid TagId { get; set; }

    public Tags? Tag { get; set; }



}
