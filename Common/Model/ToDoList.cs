namespace Common.Model
{
	public class ToDoList : BaseEntity
	{
		public string Task { get; set; }
		public DateTime Deadline { get; set; }
	}
}
