using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexTask.Dal.Entities
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Deadline { get; set; } 
        public TimeSpan TimeSpent { get; set; }

        public int StatusLookupId { get; set; }
        public StatusLookup StatusLookup { get; set; }

        public int AssignedId { get; set; }
        public User Assigned { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

    }
}
