using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZespołówka.Models
{
    public class Localization
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string ContactEmail { get; set; } = null!;
        public string ContactPhone { get; set; } = null!;
        public DateTime createdAt { get; set; } = DateTime.UtcNow;
    }
}