using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Graph;

namespace DynamicDashboard.Models
{
    public partial class Dashboard_TutorialContext : IdentityDbContext
    {
        public Dashboard_TutorialContext()
        {
        }

        public Dashboard_TutorialContext(DbContextOptions<Dashboard_TutorialContext> options)
            : base(options)
        {
        }


        public virtual DbSet<DashboardLinkedElements> DashboardLinkedElements { get; set; }
        public virtual DbSet<DashboardsInfo> DashboardsInfo { get; set; }
        public virtual DbSet<Elements> Elements { get; set; }
        public virtual DbSet<Templates> Templates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=SACHIN\\SQLEXPRESS;Database=DynaicDashboard;Trusted_Connection=True;MultipleActiveResultSets=true", builder => builder.EnableRetryOnFailure());
                 
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<DashboardLinkedElements>(entity =>
            {
                entity.ToTable("DashboardLinkedElements", "Dashboard_Tutorial");

                entity.Property(e => e.Id).HasColumnType("int");

                entity.Property(e => e.DashboardId).HasColumnType("int");

                entity.Property(e => e.ElementId).HasColumnType("int");

                entity.Property(e => e.Placement)
                    .IsRequired()
                    .HasMaxLength(55)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DashboardsInfo>(entity =>
            {
                entity.ToTable("Dashboards_Info", "Dashboard_Tutorial");

                entity.Property(e => e.Id).HasColumnType("int");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateId).HasColumnType("int");
            });

            modelBuilder.Entity<Elements>(entity =>
            {
                entity.ToTable("Elements", "Dashboard_Tutorial");

                entity.Property(e => e.Id).HasColumnType("int");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Templates>(entity =>
            {
                entity.ToTable("Templates", "Dashboard_Tutorial");

                entity.Property(e => e.Id).HasColumnType("int");

                entity.Property(e => e.ElementsCount).HasColumnType("int");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Elements>().HasData(
                new Elements { Id = 1, Name = "Element1" },
                new Elements { Id = 2, Name = "Element2" },
                new Elements { Id = 3, Name = "Element3" },
                new Elements { Id = 4, Name = "Element4" },
                new Elements { Id = 5, Name = "Element5" });

            modelBuilder.Entity<Templates>().HasData(
                new Templates { Id = 1, Name = "Template1", ElementsCount = 1 },
                new Templates { Id = 2, Name = "Template2", ElementsCount = 2 },
                new Templates { Id = 3, Name = "Template3", ElementsCount = 2 },
                new Templates { Id = 4, Name = "Template4", ElementsCount = 3 },
                new Templates { Id = 5, Name = "Template5", ElementsCount = 3 },
                new Templates { Id = 6, Name = "Template6", ElementsCount = 4 },
                new Templates { Id = 7, Name = "Template7", ElementsCount = 4 },
                new Templates { Id = 8, Name = "Template8", ElementsCount = 5 });

        }
    }
}
