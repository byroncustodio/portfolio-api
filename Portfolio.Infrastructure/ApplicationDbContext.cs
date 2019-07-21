using Portfolio.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Image> Images { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public DbSet<ProjectImageMapping> ProjectImageMapping { get; set; }
        public DbSet<ProjectTechnologyMapping> ProjectTechnologyMapping { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Image>().ToTable("Image");
            builder.Entity<Project>().ToTable("Project");
            builder.Entity<Technology>().ToTable("Technology");
            builder.Entity<ProjectImageMapping>().ToTable("ProjectImageMapping");
            builder.Entity<ProjectTechnologyMapping>().ToTable("ProjectTechnologyMapping");

            builder.Seed();
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public override int SaveChanges(bool acceptAllChangesOnSucces)
        {
            return base.SaveChanges(acceptAllChangesOnSucces);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return base.SaveChangesAsync(cancellationToken);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSucces, CancellationToken cancellationToken = default(CancellationToken))
        {
            return base.SaveChangesAsync(acceptAllChangesOnSucces, cancellationToken);
        }
    }
}
