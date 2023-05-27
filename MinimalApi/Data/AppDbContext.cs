﻿using Microsoft.EntityFrameworkCore;
using MinimalApi.Models;

namespace MinimalApi.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<TodoModel> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("DataSource=app.db;Cache=Shared");
        }
    }
}
