using Microsoft.EntityFrameworkCore;
using ProjektZespołówka.Models;

namespace ProjektZespołówka.Data
{
    public static class DbSeeder
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;
            }

            var adminId = Guid.NewGuid();
            var managerId = Guid.NewGuid();
            var technician1Id = Guid.NewGuid();
            var technician2Id = Guid.NewGuid();
            var investorId = Guid.NewGuid();

            // users
            var users = new User[]
            {
                new User {
                    Id = adminId,
                    email = "admin@cloudwire.pl",
                    passwordHash = "Admin123!",
                    Name_Surname = "Jan Kowalski",
                    role = Helpers.UserRole.Admin,
                    createdAt = DateTime.UtcNow
                },
                new User {
                    Id = managerId,
                    email = "manager@cloudwire.pl",
                    passwordHash = "Manager123!",
                    Name_Surname = "Anna Nowak",
                    role = Helpers.UserRole.Manager,
                    createdAt = DateTime.UtcNow
                },
                new User {
                    Id = technician1Id,
                    email = "tech1@cloudwire.pl",
                    passwordHash = "Tech123!",
                    Name_Surname = "Piotr Wiśniewski",
                    role = Helpers.UserRole.ServiceWorker,
                    createdAt = DateTime.UtcNow
                },
                new User {
                    Id = technician2Id,
                    email = "tech2@cloudwire.pl",
                    passwordHash = "Tech123!",
                    Name_Surname = "Marta Zielińska",
                    role = Helpers.UserRole.ServiceWorker,
                    createdAt = DateTime.UtcNow
                },
                new User {
                    Id = investorId,
                    email = "investor@firma.pl",
                    passwordHash = "Investor123!",
                    Name_Surname = "Robert Firma",
                    role = Helpers.UserRole.Investor,
                    createdAt = DateTime.UtcNow
                },
            };

            context.Users.AddRange(users);
            context.SaveChanges();

            // localizations
            var locationId = Guid.NewGuid();
            var localization = new Localization
            {
                Id = locationId,
                Name = "Biurowiec Galaxy",
                Description = "Nowoczesny biurowiec klasy A w centrum miasta",
                Address = "ul. Biznesowa 123, 00-001 Warszawa",
                ContactEmail = "biuro@galaxy.pl",
                ContactPhone = "+48 22 123 4567",
                createdAt = DateTime.UtcNow
            };

            context.Localizations.Add(localization);
            context.SaveChanges();

            // project
            var projectId = Guid.NewGuid();
            var project = new Project
            {
                Id = projectId,
                Title = "Instalacja sieci strukturalnej - Biurowiec Galaxy",
                Description = "Kompleksowa instalacja sieci LAN w biurowcu",
                ContactPhone = "+48 22 987 6543",
                ContactEmail = "projekt@galaxy.pl",
                Status = Helpers.ProjectStatus.InProgress,
                ManagerId = managerId,
                InvestorId = investorId,
                CreatedAt = DateTime.UtcNow,
                LocationId = locationId
            };

            context.Projects.Add(project);
            context.SaveChanges();

            // service workers
            var serviceWorkers = new ServiceWorkerInProject[]
            {
                new ServiceWorkerInProject
                {
                    ProjectId = projectId,
                    ServiceWorkerId = technician1Id,
                    AssignedAt = DateTime.UtcNow
                },
                new ServiceWorkerInProject
                {
                    ProjectId = projectId,
                    ServiceWorkerId = technician2Id,
                    AssignedAt = DateTime.UtcNow.AddDays(-1)
                }
            };

            context.ServiceWorkerInProjects.AddRange(serviceWorkers);
            context.SaveChanges();

            // levels
            var levelId = Guid.NewGuid();
            var level = new Levels
            {
                Id = levelId,
                ProjectId = projectId,
                LevelNumber = 1,
                TechnicalDescription = "Parter - strefa recepcyjna i biurowa",
                CableType = "CAT6A UTP",
                LevelPlanFileAttachmentId = Guid.NewGuid().ToString(),
                CreatedAt = DateTime.UtcNow
            };

            context.Levels.Add(level);
            context.SaveChanges();

            // rooms
            var room1Id = Guid.NewGuid();
            var room2Id = Guid.NewGuid();
            var room3Id = Guid.NewGuid();

            var rooms = new Room[]
            {
                new Room
                {
                    Id = room1Id,
                    LevelId = levelId,
                    Number = 101,
                    TechnicalName = "Biuro open-space",
                    OutletCount = 24,
                    CoordinatesOnPlan = "{\"x\": 120, \"y\": 150, \"width\": 400, \"height\": 300}",
                    Description = "Główne biuro pracownicze"
                },
                new Room
                {
                    Id = room2Id,
                    LevelId = levelId,
                    Number = 102,
                    TechnicalName = "Sala konferencyjna",
                    OutletCount = 12,
                    CoordinatesOnPlan = "{\"x\": 600, \"y\": 150, \"width\": 500, \"height\": 400}",
                    Description = "Sala na spotkania i prezentacje"
                },
                new Room
                {
                    Id = room3Id,
                    LevelId = levelId,
                    Number = 103,
                    TechnicalName = "Serwerownia",
                    OutletCount = 8,
                    CoordinatesOnPlan = "{\"x\": 50, \"y\": 500, \"width\": 300, \"height\": 250}",
                    Description = "Pomieszczenie techniczne z szafami rack"
                }
            };

            context.Rooms.AddRange(rooms);
            context.SaveChanges();

            // outlets
            var outlet1Id = Guid.NewGuid();
            var outlet2Id = Guid.NewGuid();
            var outlet3Id = Guid.NewGuid();

            var outlets = new Outlet[]
            {
                new Outlet
                {
                    Id = outlet1Id,
                    RoomId = room1Id,
                    ServedById = technician1Id,
                    TechnicalName = "GN-101-01",
                    OutletCount = 1,
                    Type = Helpers.OutletType.Data,
                    NearPhotoId = Guid.NewGuid(),
                    FarPhotoId = Guid.NewGuid(),
                    Status = Helpers.OutletStatus.Active,
                    InstallationDate = DateTime.UtcNow.AddDays(-5)
                },
                new Outlet
                {
                    Id = outlet2Id,
                    RoomId = room1Id,
                    ServedById = technician2Id,
                    TechnicalName = "GN-101-02",
                    OutletCount = 1,
                    Type = Helpers.OutletType.Telephone,
                    NearPhotoId = Guid.NewGuid(),
                    FarPhotoId = Guid.NewGuid(),
                    Status = Helpers.OutletStatus.UnderMaintenance,
                    InstallationDate = DateTime.UtcNow.AddDays(-3)
                },
                new Outlet
                {
                    Id = outlet3Id,
                    RoomId = room2Id,
                    ServedById = technician1Id,
                    TechnicalName = "GN-102-01",
                    OutletCount = 1,
                    Type = Helpers.OutletType.Data,
                    NearPhotoId = Guid.NewGuid(),
                    FarPhotoId = Guid.NewGuid(),
                    Status = Helpers.OutletStatus.Active,
                    InstallationDate = DateTime.UtcNow.AddDays(-2)
                }
            };

            context.Outlets.AddRange(outlets);
            context.SaveChanges();

            // measurements
            var measurements = new Measurments[]
            {
                new Measurments
                {
                    Id = Guid.NewGuid(),
                    OutletId = outlet1Id,
                    ServiceWorkerId = technician1Id,
                    AttachmentId = Guid.NewGuid(),
                    Type = Helpers.MeasurementType.Correct,
                    TechnicalDetails = "{\"dlugosc\": \"45.5m\", \"tłumienność\": \"21.3dB\", \"test\": \"PASS\"}",
                    MeasuredAt = DateTime.UtcNow.AddDays(-1),
                    Certification = Helpers.CertificationStatus.Approved
                },
                new Measurments
                {
                    Id = Guid.NewGuid(),
                    OutletId = outlet2Id,
                    ServiceWorkerId = technician2Id,
                    AttachmentId = Guid.NewGuid(),
                    Type = Helpers.MeasurementType.With_Error_Margin,
                    TechnicalDetails = "{\"dlugosc\": \"48.2m\", \"tłumienność\": \"24.1dB\", \"test\": \"MARGINAL\"}",
                    MeasuredAt = DateTime.UtcNow.AddHours(-6),
                    Certification = Helpers.CertificationStatus.Pending
                }
            };

            context.Measurments.AddRange(measurements);
            context.SaveChanges();

            // network racks
            var networkRackId = Guid.NewGuid();
            var networkRack = new NetworkRack
            {
                Id = networkRackId,
                ProjectId = projectId,
                Model = "APC NetShelter SX 42U",
                Size = "42U",
                Location = "Serwerownia, pokój 103",
                FrontViewImageId = Guid.NewGuid(),
                RearViewImageId = Guid.NewGuid(),
                SideViewImageId = Guid.NewGuid(),
                InstallationDate = DateTime.UtcNow.AddDays(-10)
            };

            context.NetworkRacks.Add(networkRack);
            context.SaveChanges();

            // rack panels
            var rackPanels = new RackPanel[]
            {
                new RackPanel
                {
                    Id = Guid.NewGuid(),
                    NetworkRackId = networkRackId,
                    Type = "Patch panel 48 portów CAT6",
                    PortNumber = 48,
                    Position = "U10-U12"
                },
                new RackPanel
                {
                    Id = Guid.NewGuid(),
                    NetworkRackId = networkRackId,
                    Type = "Switch Cisco 2960X 48 portów",
                    PortNumber = 48,
                    Position = "U13-U14"
                },
                new RackPanel
                {
                    Id = Guid.NewGuid(),
                    NetworkRackId = networkRackId,
                    Type = "Panel keystone 12 portów",
                    PortNumber = 12,
                    Position = "U15"
                }
            };

            context.RackPanels.AddRange(rackPanels);
            context.SaveChanges();

            // work stages
            var workStage1Id = Guid.NewGuid();
            var workStage2Id = Guid.NewGuid();
            var workStage3Id = Guid.NewGuid();

            var workStages = new WorkStages[]
            {
                new WorkStages
                {
                    Id = workStage1Id,
                    ProjectId = projectId,
                    StageName = "Projektowanie i planowanie",
                    Description = "Przygotowanie dokumentacji projektowej",
                    AssignedUserId = managerId,
                    Deadline = DateTime.UtcNow.AddDays(-30),
                    Status = Helpers.WorkStatus.Completed,
                    StartedAt = DateTime.UtcNow.AddDays(-45),
                    CompletedAt = DateTime.UtcNow.AddDays(-30)
                },
                new WorkStages
                {
                    Id = workStage2Id,
                    ProjectId = projectId,
                    StageName = "Instalacja okablowania",
                    Description = "Montaż przewodów i gniazd sieciowych",
                    AssignedUserId = technician1Id,
                    Deadline = DateTime.UtcNow.AddDays(15),
                    Status = Helpers.WorkStatus.InProgress,
                    StartedAt = DateTime.UtcNow.AddDays(-20),
                    CompletedAt = null
                },
                new WorkStages
                {
                    Id = workStage3Id,
                    ProjectId = projectId,
                    StageName = "Testy i certyfikacja",
                    Description = "Pomiary i certyfikacja okablowania",
                    AssignedUserId = technician2Id,
                    Deadline = DateTime.UtcNow.AddDays(30),
                    Status = Helpers.WorkStatus.NotStarted,
                    StartedAt = DateTime.UtcNow.AddDays(15),
                    CompletedAt = null
                }
            };

            context.WorkStages.AddRange(workStages);
            context.SaveChanges();

            // room stages
            var roomStages = new RoomStages[]
            {
                new RoomStages { WorkStageId = workStage2Id, RoomId = room1Id },
                new RoomStages { WorkStageId = workStage2Id, RoomId = room2Id },
                new RoomStages { WorkStageId = workStage3Id, RoomId = room1Id }
            };

            context.RoomsStages.AddRange(roomStages);
            context.SaveChanges();

            // outlet stages
            var outletStages = new OutletStages[]
            {
                new OutletStages { WorkStageId = workStage2Id, OutletId = outlet1Id },
                new OutletStages { WorkStageId = workStage2Id, OutletId = outlet2Id },
                new OutletStages { WorkStageId = workStage3Id, OutletId = outlet1Id }
            };

            context.OutletsStages.AddRange(outletStages);
            context.SaveChanges();

            // comments
            var comments = new Comments[]
            {
                new Comments
                {
                    Id = Guid.NewGuid(),
                    EntityType = Helpers.EntityType.Project,
                    EntityId = projectId,
                    AuthorId = managerId,
                    Content = "Projekt przebiega zgodnie z planem, brak opóźnień.",
                    Status = Helpers.CommentStatus.Closed,
                    CreatedAt = DateTime.UtcNow.AddDays(-5)
                },
                new Comments
                {
                    Id = Guid.NewGuid(),
                    EntityType = Helpers.EntityType.Outlet,
                    EntityId = outlet2Id,
                    AuthorId = technician1Id,
                    Content = "Gniazdo wymaga dodatkowego zabezpieczenia przed kurzem",
                    Status = Helpers.CommentStatus.Open,
                    CreatedAt = DateTime.UtcNow.AddDays(-2)
                }
            };

            context.Comments.AddRange(comments);
            context.SaveChanges();

            // addons
            var addons = new Addons[]
            {
                new Addons
                {
                    Id = Guid.NewGuid(),
                    EntityType = "Project",
                    EntityId = 1,
                    FileAttachmentId = Guid.NewGuid(),
                    UploadedByUserId = managerId,
                    UploadedAt = DateTime.UtcNow.AddDays(-25)
                }
            };

            context.Addons.AddRange(addons);
            context.SaveChanges();

            // executive documents
            var executiveDocs = new ExecutiveDocuments[]
            {
                new ExecutiveDocuments
                {
                    Id = Guid.NewGuid(),
                    ProjectId = projectId,
                    DocumentId = Guid.NewGuid(),
                    UploadedAt = DateTime.UtcNow.AddDays(-20),
                    RecipientId = Guid.NewGuid() 
                }
            };

            context.ExecutiveDocuments.AddRange(executiveDocs);
            context.SaveChanges();

            Console.WriteLine("database seeded");
        }
    }
}