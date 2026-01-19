using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZespołówka.DTOs
{
    public class AddonsDto
    {
        public Guid Id { get; set; }
        public string EntityType { get; set; }
        public int EntityId { get; set; }
        public Guid FileAttachmentId { get; set; }
        public Guid UploadedByUserId { get; set; }
        public DateTime UploadedAt { get; set; }
    }
}