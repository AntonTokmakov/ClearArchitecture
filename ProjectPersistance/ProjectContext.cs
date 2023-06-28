using Microsoft.EntityFrameworkCore;
using System.Xml;
using Tasks.Models;
using TrialProject.Models;

namespace Tasks.Controllers.Repositories
{
    public class ProjectContext : DbContext
    {

        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) { }


        public DbSet<Project> project { get; set; }
        public DbSet<TasksProject> tasks { get; set; }
        public DbSet<Teacher> teacher { get; set; }
        public DbSet<TechnicalSpecification> technical_specifications { get; set; }
        public DbSet<Student> student { get; set; }
        public DbSet<ProjectStatus> project_status { get; set; }
        public DbSet<ProjectTaskStatus> task_status { get; set; }
        public DbSet<ProjectTeam> project_teams { get; set; }
        public DbSet<TaskAssigments> task_assigments { get; set; }
        public DbSet<Complexity> complexity { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectTeam>()
                .HasNoKey();
            modelBuilder.Entity<TaskAssigments>()
                .HasNoKey();
            modelBuilder
                .Entity<TechnicalSpecification>()
                .Property(e => e.start_date)
                .HasConversion(
                    v => v.ToUniversalTime(),
                    v => DateTime.SpecifyKind(v, DateTimeKind.Utc));
            modelBuilder
                .Entity<TechnicalSpecification>()
                .Property(e => e.end_date)
                .HasConversion(
                    v => v.ToUniversalTime(),
                    v => DateTime.SpecifyKind(v, DateTimeKind.Utc));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=ProjectManagement;User Id=postgres;Password=56001;");
        }

    }
}
