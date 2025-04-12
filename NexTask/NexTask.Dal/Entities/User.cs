namespace NexTask.Dal.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int RoleLookupId { get; set; }
        public RoleLookup RoleLookup { get; set; }
        public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
        public ICollection<TaskComment> TaskComments { get; set; } = new List<TaskComment>();
    }
}
