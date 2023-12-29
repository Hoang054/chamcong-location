using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Recruit.Client.Pages;
using Recruit.Server.Models;
using Recruit.Server.Models.ModelViews;
using Recruit.Shared;
using System.Reflection;

namespace Recruit.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Job> Jobs => Set<Job>();
        public DbSet<Applicant> Applicants => Set<Applicant>();
        public DbSet<Stage> Stages => Set<Stage>();
        public DbSet<Interview> Interviews => Set<Interview>();
        public DbSet<Department> Departments => Set<Department>();
        public DbSet<Template> Templates => Set<Template>();
        public DbSet<EmailItem> Emails => Set<EmailItem>();

        public DbSet<UserInfoDb> UserInfo { get; set; }
        public DbSet<UserGrpDb> UserGrp { get; set; }
        public DbSet<DeptsDb> Depts { get; set; }
        public DbSet<ChamCongLineDb> ChamCongLines { get; set; }
        public DbSet<ChamCongHeaderDb> ChamCongHeaders { get; set; }
        public DbSet<PersonnelsDb> Personnels { get; set; }
        public DbSet<ChamCongTypeDb> ChamCongTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<ChamCongLineDb>(builder =>
            //{
            //    builder.HasNoKey();
            //});
            modelBuilder.Entity<UserInfoDb>().ToTable("Sys_UserInfo");
            modelBuilder.Entity<UserInfoDb>().ToTable("Sys_UserInfo", "dbo");

            modelBuilder.Entity<UserGrpDb>().ToTable("Sys_UserGrp");
            modelBuilder.Entity<UserGrpDb>().ToTable("Sys_UserGrp", "dbo");

            modelBuilder.Entity<DeptsDb>().ToTable("Dm_Depts");
            modelBuilder.Entity<DeptsDb>().ToTable("Dm_Depts", "dbo");

            modelBuilder.Entity<ChamCongLineDb>().ToTable("MngChamCongLine");
            modelBuilder.Entity<ChamCongLineDb>().ToTable("MngChamCongLine", "dbo");

            modelBuilder.Entity<ChamCongHeaderDb>().ToTable("MngChamCongHeader");
            modelBuilder.Entity<ChamCongHeaderDb>().ToTable("MngChamCongHeader", "dbo");

            modelBuilder.Entity<PersonnelsDb>().ToTable("Dm_Personnels");
            modelBuilder.Entity<PersonnelsDb>().ToTable("Dm_Personnels", "dbo");

            modelBuilder.Entity<ChamCongTypeDb>().ToTable("Enum_ChamCongType");
            modelBuilder.Entity<ChamCongTypeDb>().ToTable("Enum_ChamCongType", "dbo");

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}