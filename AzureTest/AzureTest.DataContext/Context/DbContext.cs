using System;
using System.Collections.Generic;
using System.Text;
using AzureTest.DataContext.Model;
using Microsoft.EntityFrameworkCore;

namespace AzureTest.DataContext.Context
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext()
        {
        }
        public DbContext(DbContextOptions<DbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }


        public DbSet<Card> Cards { get; set; }
    }
}
