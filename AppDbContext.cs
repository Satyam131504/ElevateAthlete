﻿using CommunityApp.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace CommunityApp.Api.Data

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Add your DbSets here
        public DbSet<User> Users { get; set; }
    }
}

