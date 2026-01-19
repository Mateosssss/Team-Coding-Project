using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjektZespołówka.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore; 
using Microsoft.EntityFrameworkCore;

namespace ProjektZespołówka.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<User, IdentityRole<Guid>, Guid>(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<WorkStages> WorkStages { get; set; }
        public DbSet<ServiceWorkerInProject> ServiceWorkerInProjects { get; set; }
        public DbSet<RoomStages> RoomsStages { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RackPanel> RackPanels { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<OutletStages> OutletsStages { get; set; }
        public DbSet<Outlet> Outlets { get; set; }
        public DbSet<NetworkRack> NetworkRacks { get; set; }
        public DbSet<Measurments> Measurments { get; set; }
        public DbSet<Localization> Localizations { get; set; }
        public DbSet<Levels> Levels { get; set; }
        public DbSet<ExecutiveDocuments> ExecutiveDocuments { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Addons> Addons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           modelBuilder.Entity<User>(entity =>
            {
                // Mapujemy Twoją klasę User do Twojej tabeli "Użytkownicy"
                entity.ToTable("Użytkownicy");
                
                entity.Property(u => u.Id).HasColumnName("id");
                entity.Property(u => u.Email).HasColumnName("email").HasMaxLength(100);
                entity.Property(u => u.PasswordHash).HasColumnName("hasło").HasMaxLength(255);
                
                entity.Property(u => u.Name_Surname).HasColumnName("imię_nazwisko").HasMaxLength(150);
                entity.Property(u => u.role).HasColumnName("rola").HasMaxLength(20);
                entity.Property(u => u.createdAt).HasColumnName("data_rejestracji");
                
                entity.Property(u => u.RefreshToken).HasColumnName("refresh_token");
                entity.Property(u => u.RefreshTokenExpiryTime).HasColumnName("refresh_token_expiration");
            });

            modelBuilder.Entity<Localization>(entity =>
            {
                entity.ToTable("Lokalizacje");
                entity.HasKey(l => l.Id);
                entity.Property(l => l.Id).HasColumnName("id");
                entity.Property(l => l.Name).HasColumnName("nazwa").HasMaxLength(200);
                entity.Property(l => l.Description).HasColumnName("opis");
                entity.Property(l => l.Address).HasColumnName("dane_adresowe").HasMaxLength(250);
                entity.Property(l => l.ContactEmail).HasColumnName("dane_kontaktowe").HasMaxLength(200);
                entity.Property(l => l.ContactPhone).HasColumnName("contact_phone").HasMaxLength(20);
                entity.Property(l => l.createdAt).HasColumnName("data_utworzenia");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("Projekty");
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Id).HasColumnName("id");
                entity.Property(p => p.Title).HasColumnName("nazwa").HasMaxLength(200);
                entity.Property(p => p.Description).HasColumnName("opis").HasMaxLength(200);
                entity.Property(p => p.ContactPhone).HasColumnName("dane_adresowe").HasMaxLength(200);
                entity.Property(p => p.ContactEmail).HasColumnName("dane_kontaktowe").HasMaxLength(200);
                entity.Property(p => p.Status).HasColumnName("status_projektu").HasMaxLength(20);
                entity.Property(p => p.ManagerId).HasColumnName("kierownik_id");
                entity.Property(p => p.InvestorId).HasColumnName("inwestor_id");
                entity.Property(p => p.CreatedAt).HasColumnName("data_utworzenia");
                entity.Property(p => p.LocationId).HasColumnName("lokalizacja_id");

                // tbd - wlasciwosci do dodania
                //entity.HasOne(p => (User)null) // Manager 
                //    .WithMany()
                //    .HasForeignKey(p => p.ManagerId)
                //    .OnDelete(DeleteBehavior.Restrict);

                //entity.HasOne(p => (User)null) // Investor 
                //    .WithMany()
                //    .HasForeignKey(p => p.InvestorId)
                //    .OnDelete(DeleteBehavior.Restrict);

                //entity.HasOne(p => (Localization)null) // 
                //    .WithMany()
                //    .HasForeignKey(p => p.LocationId)
                //    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<ServiceWorkerInProject>(entity =>
            {
                entity.ToTable("Serwisanci_w_projektach");
                entity.HasKey(sw => new { sw.ProjectId, sw.ServiceWorkerId });
                entity.Property(sw => sw.ProjectId).HasColumnName("projekt_id");
                entity.Property(sw => sw.ServiceWorkerId).HasColumnName("serwisant_id");
                entity.Property(sw => sw.AssignedAt).HasColumnName("data_przypisania");
            });

            modelBuilder.Entity<Levels>(entity =>
            {
                entity.ToTable("Poziomy");
                entity.HasKey(l => l.Id);
                entity.Property(l => l.Id).HasColumnName("id");
                entity.Property(l => l.ProjectId).HasColumnName("projekt_id");
                entity.Property(l => l.LevelNumber).HasColumnName("numer");
                entity.Property(l => l.TechnicalDescription).HasColumnName("oznaczenie_techniczne").HasMaxLength(150);
                entity.Property(l => l.CableType).HasColumnName("kat_rodzajKabla").HasMaxLength(150);
                entity.Property(l => l.LevelPlanFileAttachmentId).HasColumnName("plik_rzutu_url").HasMaxLength(500);
                entity.Property(l => l.CreatedAt).HasColumnName("data_dodania");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.ToTable("Pomieszczenia");
                entity.HasKey(r => r.Id);
                entity.Property(r => r.Id).HasColumnName("id");
                entity.Property(r => r.LevelId).HasColumnName("pietro_id");
                entity.Property(r => r.Number).HasColumnName("nr_pomieszczenia").HasMaxLength(50);
                entity.Property(r => r.TechnicalName).HasColumnName("nazwa_pomieszczenia").HasMaxLength(150);
                entity.Property(r => r.TechnicalCode).HasColumnName("oznaczenie_techniczne").HasMaxLength(150);
                entity.Property(r => r.CoordinatesOnPlan).HasColumnName("współrzędne_na_rzucie");
                entity.Property(r => r.Description).HasColumnName("opis");
            });

            modelBuilder.Entity<Outlet>(entity =>
            {
                entity.ToTable("Gniazda");
                entity.HasKey(o => o.Id);
                entity.Property(o => o.Id).HasColumnName("id");
                entity.Property(o => o.RoomId).HasColumnName("pomieszczenie_id");
                entity.Property(o => o.ServedById).HasColumnName("serwisant_id");
                entity.Property(o => o.TechnicalName).HasColumnName("oznaczenie_techniczne").HasMaxLength(50);
                entity.Property(o => o.OutletCount).HasColumnName("liczba_gniazd");
                entity.Property(o => o.Type).HasColumnName("typ_gniazda").HasMaxLength(20);
                entity.Property(o => o.NearPhotoId).HasColumnName("zdjęcie_zbiżenie_url").HasMaxLength(500);
                entity.Property(o => o.FarPhotoId).HasColumnName("zdjęcie_odległość_url").HasMaxLength(500);
                entity.Property(o => o.InstallationDate).HasColumnName("data_instalacji");
                entity.Property(o => o.Status).HasColumnName("status").HasMaxLength(20);

                entity.HasIndex(o => o.TechnicalName).IsUnique();
            });

            modelBuilder.Entity<Measurments>(entity =>
            {
                entity.ToTable("Pomiary");
                entity.HasKey(m => m.Id);
                entity.Property(m => m.Id).HasColumnName("id");
                entity.Property(m => m.OutletId).HasColumnName("gniazdo_id");
                entity.Property(m => m.ServiceWorkerId).HasColumnName("serwisant_id");
                entity.Property(m => m.AttachmentId).HasColumnName("plik_raportu_url").HasMaxLength(500);
                entity.Property(m => m.Type).HasColumnName("wynik_pomiaru").HasMaxLength(30);
                entity.Property(m => m.TechnicalDetails).HasColumnName("parametry_techniczne");
                entity.Property(m => m.MeasuredAt).HasColumnName("data_pomiaru");
                entity.Property(m => m.Certification).HasColumnName("status_certyfikacji").HasMaxLength(20);
            });

            modelBuilder.Entity<NetworkRack>(entity =>
            {
                entity.ToTable("Szafy_sieciowe");
                entity.HasKey(nr => nr.Id);
                entity.Property(nr => nr.Id).HasColumnName("id");
                entity.Property(nr => nr.ProjectId).HasColumnName("projekt_id");
                entity.Property(nr => nr.Model).HasColumnName("model").HasMaxLength(100);
                entity.Property(nr => nr.Size).HasColumnName("rozmiar").HasMaxLength(100);
                entity.Property(nr => nr.Location).HasColumnName("lokalizacja");
                entity.Property(nr => nr.FrontViewImageId).HasColumnName("zdjęcie_przód_url").HasMaxLength(500);
                entity.Property(nr => nr.RearViewImageId).HasColumnName("zdjęcie_tył_url").HasMaxLength(500);
                entity.Property(nr => nr.SideViewImageId).HasColumnName("zdjęcie_bok_url").HasMaxLength(500);
                entity.Property(nr => nr.InstallationDate).HasColumnName("data_montażu");

            });

            modelBuilder.Entity<RackPanel>(entity =>
            {
                entity.ToTable("Panele_szaf");
                entity.HasKey(rp => rp.Id);
                entity.Property(rp => rp.Id).HasColumnName("id");
                entity.Property(rp => rp.NetworkRackId).HasColumnName("szafa_id");
                entity.Property(rp => rp.Type).HasColumnName("typ").HasMaxLength(100);
                entity.Property(rp => rp.PortNumber).HasColumnName("liczba_portów");
                entity.Property(rp => rp.Position).HasColumnName("pozycja").HasMaxLength(50);
            });

            modelBuilder.Entity<WorkStages>(entity =>
            {
                entity.ToTable("Etapy_prac");
                entity.HasKey(ws => ws.Id);
                entity.Property(ws => ws.Id).HasColumnName("id");
                entity.Property(ws => ws.ProjectId).HasColumnName("projekt_id");
                entity.Property(ws => ws.StageName).HasColumnName("nazwa").HasMaxLength(150);
                entity.Property(ws => ws.Description).HasColumnName("opis");
                entity.Property(ws => ws.AssignedUserId).HasColumnName("przypisany_do");
                entity.Property(ws => ws.Deadline).HasColumnName("termin");
                entity.Property(ws => ws.Status).HasColumnName("status").HasMaxLength(30);
                entity.Property(ws => ws.StartedAt).HasColumnName("data_rozpoczęcia");
                entity.Property(ws => ws.CompletedAt).HasColumnName("data_zakończenia");
            });

            modelBuilder.Entity<RoomStages>(entity =>
            {
                entity.ToTable("Etapy_pomieszczenia");
                entity.HasKey(rs => new { rs.WorkStageId, rs.RoomId });
                entity.Property(rs => rs.WorkStageId).HasColumnName("etap_id");
                entity.Property(rs => rs.RoomId).HasColumnName("pomieszczenie_id");
            });

            modelBuilder.Entity<OutletStages>(entity =>
            {
                entity.ToTable("Etapy_gniazda");
                entity.HasKey(os => new { os.WorkStageId, os.OutletId });
                entity.Property(os => os.WorkStageId).HasColumnName("etap_id");
                entity.Property(os => os.OutletId).HasColumnName("gniazdo_id");
            });

            modelBuilder.Entity<Comments>(entity =>
            {
                entity.ToTable("Uwagi");
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Id).HasColumnName("id");
                entity.Property(c => c.EntityType).HasColumnName("typ_encji").HasMaxLength(50);
                entity.Property(c => c.EntityId).HasColumnName("encja_id");
                entity.Property(c => c.AuthorId).HasColumnName("autor_id");
                entity.Property(c => c.Content).HasColumnName("treść");
                entity.Property(c => c.Status).HasColumnName("status").HasMaxLength(20);
                entity.Property(c => c.CreatedAt).HasColumnName("data_dodania");
            });

            modelBuilder.Entity<Addons>(entity =>
            {
                entity.ToTable("Załączniki");
                entity.HasKey(a => a.Id);
                entity.Property(a => a.Id).HasColumnName("id");
                entity.Property(a => a.EntityType).HasColumnName("typ_encji").HasMaxLength(50);
                entity.Property(a => a.EntityId).HasColumnName("encja_id");
                entity.Property(a => a.FileAttachmentId).HasColumnName("plik_url").HasMaxLength(500);
                entity.Property(a => a.UploadedByUserId).HasColumnName("dodane_przez");
                entity.Property(a => a.UploadedAt).HasColumnName("data_dodania");
            });

            modelBuilder.Entity<ExecutiveDocuments>(entity =>
            {
                entity.ToTable("Dokumenty_wykonawcze");
                entity.HasKey(ed => ed.Id);
                entity.Property(ed => ed.Id).HasColumnName("id");
                entity.Property(ed => ed.ProjectId).HasColumnName("projekt_id");
                entity.Property(ed => ed.DocumentId).HasColumnName("plik_pdf_url").HasMaxLength(500);
                entity.Property(ed => ed.UploadedAt).HasColumnName("data_wygenerowania");
                entity.Property(ed => ed.RecipientId).HasColumnName("odbiorca").HasMaxLength(100);
            });
        }
    }
}