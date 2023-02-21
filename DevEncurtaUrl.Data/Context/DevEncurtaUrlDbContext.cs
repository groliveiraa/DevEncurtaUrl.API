using DevEncurtaUrl.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEncurtaUrl.Data.Context
{
    public class DevEncurtaUrlDbContext : DbContext
    {
        public DevEncurtaUrlDbContext(DbContextOptions<DevEncurtaUrlDbContext> options)
            : base(options)
        {
        }

        public DbSet<ShortenedCustomLink> Links { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ShortenedCustomLink>(e =>
            {
                e.HasKey(l => l.Id);
            });
        }
    }
}
