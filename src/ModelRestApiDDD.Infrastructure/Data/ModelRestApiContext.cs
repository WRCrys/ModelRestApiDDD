using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModelRestApiDDD.Domain.Entities;

namespace ModelRestApiDDD.Infrastructure.Data
{
    public class ModelRestApiContext : DbContext
    {
        public ModelRestApiContext(DbContextOptions<ModelRestApiContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Product> Products { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
        {
            foreach (var entry in ChangeTracker.Entries()
                .Where(entry => entry.Entity.GetType().GetProperty("DateCreate") != null))
            {
                if (entry.State == EntityState.Added) entry.Property("DateCreate").CurrentValue = DateTime.Now;

                if (entry.State == EntityState.Modified) entry.Property("DateCreate").IsModified = false;
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}