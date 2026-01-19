using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ProjektZespołówka.Models.Helpers;

namespace ProjektZespołówka.DTOs
{
    public class MeasurmentsDto
    {
        public Guid Id { get; set; }
        public Guid OutletId { get; set; }
        public Guid ServiceWorkerId { get; set; }
        public Guid AttachmentId { get; set; }
        public MeasurementType Type { get; set; }
        public string TechnicalDetails { get; set; }
        public DateTime MeasuredAt { get; set; }
        public CertificationStatus Certification { get; set; }
    }
}