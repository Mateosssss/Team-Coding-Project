using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZespołówka.DTOs.Create
{
    public class CreateNetworkRackDto
    {
        public Guid ProjectId { get; set; }
        public string? Model { get; set; }
        public string? Size { get; set; }
        public string? Location { get; set; }
        public Guid FrontViewImageId { get; set; }
        public Guid SideViewImageId { get; set; }
        public Guid RearViewImageId { get; set; }
        public DateTime InstallationDate { get; set; }
    }
}