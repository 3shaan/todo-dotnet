
namespace Todo.Domain.DomainEntities
{
    public class CommentsDomain
    {

        public Guid TodoItemId { get; set; }

        public TodoItemsDomain? TodoItem { get; set; }

        public Guid UserId { get; set; }

        public UserDomain? User { get; set; }


        public required string Message { get; set; } = string.Empty;

    }
}
