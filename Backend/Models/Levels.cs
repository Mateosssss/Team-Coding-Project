using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZespołówka.Models
{
    public class Levels
    {
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public int LevelNumber { get; set; }
        public string TechnicalDescription { get; set; } = null!;
        public string CableType { get; set; } = null!;
        public string? LevelPlanFileAttachmentId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}