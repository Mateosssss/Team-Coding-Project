using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjektZespołówka.Models;

namespace ProjektZespołówka.DTOs.Create
{
    public class CreateCommentsDto
    {
        public Helpers.EntityType EntityType { get; set; }
        public Guid EntityId { get; set; }
        public Guid AuthorId { get; set; }
        public string Content { get; set; }
        public Helpers.CommentStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }    
    }
}