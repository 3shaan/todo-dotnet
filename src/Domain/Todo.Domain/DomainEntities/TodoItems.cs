namespace Todo.Domain.DomainEntities
{
    public class TodoItemsDomain
    {

        public required Guid TodoListId { get; set; }

        public TodoListDomain? TodoList { get; set; }



        public required string Title { get; set; }

        public required string Description { get; set; }

        public int Priority { get; set; } = 0;

        public int Status { get; set; } = 0;

        public DateTime? DueDate { get; set; } = null;

        public DateTime? ReminderDate { get; set; } = null;

        public DateTime? CompletedAt { get; set; } = null;

        public bool IsDeleted { get; set; } = false;


    }
}
