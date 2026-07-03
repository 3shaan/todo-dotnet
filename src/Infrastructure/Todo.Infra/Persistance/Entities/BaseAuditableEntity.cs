namespace Todo.Infra.Persistance.Entities;

public class BaseAuditableEntity : BaseEntity
{
    public DateTime CreateAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdateAt { get; set; } = null;

    public required string CreatedBy { get; set; }

    public string? UpdatedBy { get; set; } = null;



}
