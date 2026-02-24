using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZespołówka.DTOs.Create
{
    public class CreateLevelsDto
    {
        public Guid ProjectId { get; set; }
        public int LevelNumber { get; set; }
        public string TechnicalDescription { get; set; } = null!;
        public string CableType { get; set; } = null!;
        public string? LevelPlanFileAttachmentId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}