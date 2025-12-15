using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZespołówka.DTOs.Create
{
   public class CreateWorkStagesDto
    {
        public string StageName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public Guid AssignedUserId { get; set; }
        public DateTime Deadline { get; set; }
    }
}