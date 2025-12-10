using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZespołówka.Models
{
    public class Levels
    {
        public Guid Id { get; set; }
        public Project Project { get; set; } = null!;
        public int LevelNumber { get; set; }
        public string TechnicalDescription { get; set; } = null!;
        public string CableType { get; set; } = null!;
        public FileAttachment? LevelPlan { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}