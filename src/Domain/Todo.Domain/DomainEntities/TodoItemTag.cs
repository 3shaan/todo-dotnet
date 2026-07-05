namespace Todo.Domain.DomainEntities
{
    public class TodoItemTagDomain
    {

        public Guid Id { get; set; }

        public Guid TodoItemId { get; set; }

        public TodoItemsDomain? TodoItem { get; set; }

        public Guid TagId { get; set; }

        public TagsDomain? Tag { get; set; }



    }
}
