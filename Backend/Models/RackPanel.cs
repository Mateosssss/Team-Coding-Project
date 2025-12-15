using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZespołówka.Models
{
    public class RackPanel
    {
        public Guid Id { get; set; }
        public Guid NetworkRackId { get; set; }
        public string Type { get; set; }
        public int PortNumber { get; set; }
        public string Position { get; set; }
    }
}