﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthorizationAPI.Database
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>().Property(u => u.Name).HasMaxLength(10);
            builder.Entity<Student>().Property(s => s.Name).HasMaxLength(10);
            builder.Entity<Admin>().Property(a => a.Name).HasMaxLength(10);


            builder.HasDefaultSchema("auth");
        }
        
    }
}
