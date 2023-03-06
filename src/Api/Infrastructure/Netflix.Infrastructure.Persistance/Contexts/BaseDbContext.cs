using Bogus;
using Microsoft.EntityFrameworkCore;
using Netflix.Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Infrastructure.Persistance.Contexts
{
    public class BaseDbContext : DbContext
    {
        
        public BaseDbContext(DbContextOptions options) : base(options)
        {
        }

        protected BaseDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //var result = DataSeeding.GetUsers();
            //modelBuilder.Entity<User>().HasData(result);
            //var movieSeeds = DataSeeding.GetMovies();
            //modelBuilder.Entity<Movie>().HasData(movieSeeds);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            ConfigureDateTime();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            ConfigureDateTime();
            return base.SaveChangesAsync(cancellationToken);
        }
    
    
    public void ConfigureDateTime()
        {
            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach (var data in datas)
            {

                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                };

            }
        }
    
    
    }
}
