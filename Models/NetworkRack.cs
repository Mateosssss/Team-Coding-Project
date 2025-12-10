using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZespołówka.Models
{
    public class NetworkRack
    {
        public Guid Id { get; set; }
        public Project Project { get; set; }
        public string Model { get; set; }
        public string Size { get; set; }
        public string Location { get; set; }
        public FileAttachment FrontViewImage { get; set; }
        public FileAttachment SideViewImage { get; set; }
        public FileAttachment RearViewImage { get; set; }
        public DateTime InstallationDate { get; set; }
    }
}