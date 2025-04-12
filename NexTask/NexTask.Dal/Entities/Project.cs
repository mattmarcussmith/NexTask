namespace NexTask.Dal.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; } = string.Empty;

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    
    }
}
