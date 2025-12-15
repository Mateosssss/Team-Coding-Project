using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZespołówka.DTOs
{
    public class ExecutiveDocumentsDto
    {
        public Guid ProjectId { get; set; }
        public Guid DocumentId { get; set; }
        public DateTime UploadedAt { get; set; }
        public Guid RecipientId { get; set; }
    }
}