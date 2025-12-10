using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ProjektZespołówka.Models.Helpers;

namespace ProjektZespołówka.Models
{
    public class Outlet
    {
        public int Id { get; set; }
        public Room Room { get; set; }
        public User ServedBy { get; set; }
        public string TechnicalName { get; set; }
        public OutletType Type { get; set; }
        public FileAttachment NearPhoto { get; set; }   
        public FileAttachment FarPhoto { get; set; }
        public OutletStatus Status { get; set; }
        public DateTime InstallationDate { get; set; }
    }
}