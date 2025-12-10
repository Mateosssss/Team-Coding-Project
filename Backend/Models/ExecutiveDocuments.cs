using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZespołówka.Models
{
    public class ExecutiveDocuments
    {
        public Guid Id { get; set; }
        public Project Project { get; set; }
        public FileAttachment Document { get; set; }
        public DateTime UploadedAt { get; set; }
        public User Recipient { get; set; }
    }
}