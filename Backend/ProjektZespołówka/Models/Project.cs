using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZespołówka.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ContactPhone { get; set; } = null!;
        public string ContactEmail { get; set; } = null!;
        public Helpers.ProjectStatus Status { get; set; } = Helpers.ProjectStatus.Planned;
        public User Manager { get; set; } = null!;
        public User Investor { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public Localization? Location { get; set; }
    }
}