using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjektZespołówka.Models;

namespace ProjektZespołówka.DTOs
{
    public class WorkStagesDto
    {
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public string? StageName { get; set; }
        public string? Description { get; set; }
        public Guid AssignedUserId { get; set; }
        public DateTime Deadline { get; set; }
        public Helpers.WorkStatus Status { get; set; }
        public DateTime? CompletedAt { get; set; }
        public DateTime StartedAt { get; set; }
    }
}