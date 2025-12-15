using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZespołówka.Models
{
    public class ServiceWorkerInProject
    {
        public Guid ProjectId { get; set; } 
        public Guid ServiceWorkerId { get; set; } 
        public DateTime AssignedAt { get; set; } = DateTime.UtcNow; 
    }
}