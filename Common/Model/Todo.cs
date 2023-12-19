namespace Common.Model
{
	public class Todo : BaseEntity
	{
		public string Task { get; set; }
		public User AssignedTo { get; set; }
	}
}
