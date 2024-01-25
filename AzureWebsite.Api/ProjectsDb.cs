using AzureWebsite.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AzureWebsite.Api
{
    public class ProjectsDb : DbContext
    {
        public ProjectsDb(DbContextOptions<ProjectsDb> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ConfigurePersonEntity(modelBuilder.Entity<Project>());
        }

        private void ConfigurePersonEntity(EntityTypeBuilder<Project> entity)
        {
            entity.ToTable("Project");

            entity.Property(p => p.ProjectName).HasMaxLength(100).IsRequired();
            entity.Property(p => p.ProjectDescription).HasMaxLength(300).IsRequired();
            entity.Property(p => p.ProjectDeadline).HasMaxLength(20).IsRequired(false);
        }

        public DbSet<Project> Projects { get; protected set; }
    }
}