using Microsoft.EntityFrameworkCore;
using MovieManagement.Domain.Entities;


namespace MovieManagement.Infrastructure.Persistence
{
    public sealed class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options): base(options)
        {

        }

        public DbSet<Movie> Movies => Set<Movie>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MovieDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
