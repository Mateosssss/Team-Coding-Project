using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZespołówka.Models
{
    public class Room
    {
        public Guid Id { get; set; }
        public Guid LevelId { get; set; }
        public int Number { get; set; }
        public string TechnicalName { get; set; }
        public int OutletCount { get; set; }
        public string CoordinatesOnPlan {get;set;}
        public string Description { get; set; }
    }
}