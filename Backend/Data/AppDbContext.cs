using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjektZespołówka.Models;

namespace ProjektZespołówka.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options):DbContext(options)
    {
        public DbSet<User> Users {get;set;}
        public DbSet<WorkStages> WorkStages {get;set;}
        public DbSet<ServiceWorkerInProject>ServiceWorkerInProjects  {get;set;}
        public DbSet<RoomStages> RoomsStages {get;set;}
        public DbSet<Room> Rooms {get;set;}
        public DbSet<RackPanel> RackPanels {get;set;}
        public DbSet<Project> Projects {get;set;}
        public DbSet<OutletStages> OutletsStages {get;set;}
        public DbSet<Outlet> Outlets {get;set;}
        public DbSet<NetworkRack> NetworkRacks {get;set;}
        public DbSet<Measurments> Measurments {get;set;}
        public DbSet<Localization> Localizations {get;set;}
        public DbSet<Levels> Levels {get;set;}
        public DbSet<ExecutiveDocuments> ExecutiveDocuments {get;set;}
        public DbSet<Comments> Comments {get;set;}
        public DbSet<Addons> Addons {get;set;}
    }
}