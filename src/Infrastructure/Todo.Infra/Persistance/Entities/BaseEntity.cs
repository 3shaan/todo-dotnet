namespace Todo.Infra.Persistance.Entities;

public abstract class BaseEntity
{

    public Guid Id { get; set; } = Guid.NewGuid();


}
