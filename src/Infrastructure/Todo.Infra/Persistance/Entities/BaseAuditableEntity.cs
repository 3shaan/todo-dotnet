namespace Todo.Infra.Persistance.Entities;

public class BaseAuditableEntity : BaseEntity
{
    public DateTime CreateAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdateAt { get; set; } = null;

    public string CreatedBy { get; set; } = string.Empty;

    public string? UpdatedBy { get; set; } = null;



}
