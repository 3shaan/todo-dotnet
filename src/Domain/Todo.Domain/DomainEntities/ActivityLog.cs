namespace Todo.Domain.DomainEntities
{
    public class ActivityLogDomain
    {

        public string EntityName { get; set; } = string.Empty;

        public Guid EntityId { get; set; }

        public string Action { get; set; } = string.Empty;

        public string PerformedBy { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public string? OldValue { get; set; }

        public string? NewValue { get; set; }

    }
}
