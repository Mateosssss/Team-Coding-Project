using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZespołówka.DTOs
{
    public class RoomDto
    {
        public Guid Id { get; set; }
        public Guid LevelId { get; set; }
        public int Number { get; set; }
        public string TechnicalName { get; set; }
        public string TechnicalCode { get; set; }
        public int OutletCount { get; set; }
        public string CoordinatesOnPlan {get;set;}
        public string Description { get; set; }
    }
}