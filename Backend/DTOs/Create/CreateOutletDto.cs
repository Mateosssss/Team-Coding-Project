using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ProjektZespołówka.Models.Helpers;

namespace ProjektZespołówka.DTOs.Create
{
    public class CreateOutletDto
    {
         public Guid RoomId { get; set; }
        public Guid ServedById { get; set; }
        public string TechnicalName { get; set; }
        public OutletType Type { get; set; }
        public Guid NearPhotoId { get; set; }   
        public Guid FarPhotoId { get; set; }
    }
}