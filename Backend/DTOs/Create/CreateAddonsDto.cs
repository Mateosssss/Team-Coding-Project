using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZespołówka.DTOs.Create
{
    public class CreateAddonsDto
    {
        public string EntityType { get; set; }
        public int EntityId { get; set; }
        public Guid FileAttachmentId { get; set; }
        public Guid UploadedByUserId { get; set; }
        public DateTime UploadedAt { get; set; }
    }
}