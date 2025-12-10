using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZespołówka.Models
{
    public class ServiceWorkerInProject
    {
        public Project Project { get; set; } = null!;
        public User ServiceWorker { get; set; } = null!;
        public DateTime AssignedAt { get; set; } = DateTime.UtcNow; 
    }
}