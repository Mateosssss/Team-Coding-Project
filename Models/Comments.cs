using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZespołówka.Models
{
    public class Comments
    {
        public Guid Id { get; set; }
        public Helpers.EntityType EntityType { get; set; }
        public int EntityId { get; set; }
        public User Author { get; set; }
        public string Content { get; set; }
        public Helpers.CommentStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }    
    }
}