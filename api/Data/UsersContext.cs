using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class UsersContext : DbContext
    {
        public DbSet<UsersEntity> UsersEntity { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("CONNECTION_STRING"));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}