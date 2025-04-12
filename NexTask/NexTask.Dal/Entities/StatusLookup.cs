namespace NexTask.Dal.Entities
{
    public class StatusLookup
    {
        public int Id { get; set; }
        public string StatusName { get; set; } = string.Empty;
        public string ColorHex { get; set; } = string.Empty;
    }
}
