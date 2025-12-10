using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZespołówka.Models
{
    public class WorkStages
    {
        public Guid Id { get; set; }
        public Project Project { get; set; }
        public string StageName { get; set; }
        public string Description { get; set; }
        public User AssignedTo { get; set; }
        public DateTime DeadLine { get; set; }
        public Helpers.WorkStatus Status { get; set; }
        public DateTime? CompletedAt { get; set; }
        public DateTime StartedAt { get; set; }
    }
}