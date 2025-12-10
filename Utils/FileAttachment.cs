using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZespołówka.Models
{
    public class FileAttachment
    {
        public int Id { get; set; }
        public string FileName { get; set; } = null!;
        public string FileType { get; set; } = null!;   
        public string Url { get; set; } = null!;        
        public long Size { get; set; }                 
        public DateTime UploadedAt { get; set; } = DateTime.UtcNow;

        public int? UploadedById { get; set; }
        public Models.User? UploadedBy { get; set; }
    }

}