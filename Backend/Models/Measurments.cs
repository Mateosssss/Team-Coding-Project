using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ProjektZespołówka.Models.Helpers;
namespace ProjektZespołówka.Models
{
    public class Measurments
    {
        public Guid Id { get; set; }
        public Outlet Outlet { get; set; }
        public User ServiceWorker { get; set; }
        public FileAttachment Attachment { get; set; }
        public MeasurementType Type { get; set; }
        public string TechnicalDetails { get; set; }
        public DateTime MeasuredAt { get; set; }
        public CertificationStatus Certification { get; set; }
    }
}