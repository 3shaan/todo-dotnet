namespace Todo.Infra.Persistance.Entities;

public class User : BaseAuditableEntity
{

    public required string Name { get; set; }

    public required string Email { get; set; }

    public required string Password { get; set; }

}
