using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjektZespołówka.Models;

namespace ProjektZespołówka.DTOs
{
    public class ProjectDto
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ContactPhone { get; set; } = null!;
        public string ContactEmail { get; set; } = null!;
        public Helpers.ProjectStatus Status { get; set; }
        public Guid ManagerId { get; set; }
        public Guid InvestorId { get; set; }
        public Guid LocationId { get; set; }
    }
}