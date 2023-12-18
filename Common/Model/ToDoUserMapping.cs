namespace Common.Model
{
	public class ToDoUserMapping : BaseEntity
	{
		public User AssignedTo { get; set; }
		public ToDoList ToDoListDirectory { get; set; }
	}
}
