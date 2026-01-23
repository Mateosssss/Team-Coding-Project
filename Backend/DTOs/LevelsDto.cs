using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZespołówka.DTOs
{
    public class LevelsDto
    {
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public int LevelNumber { get; set; }
        public string TechnicalDescription { get; set; } = null!;
        public string CableType { get; set; } = null!;
        public string? LevelPlanFileAttachmentId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}