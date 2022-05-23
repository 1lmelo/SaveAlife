using Save.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Save.Infrastructure.Entity.Context
{
    public class SaveContext : DbContext
    {
        public DbSet<Covid> SearchCovid { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SaveDb;Data Source=WIN-GW2C7ZXSME");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Covid>(entity =>
            {
                entity.HasKey(e => new { e.Id });           
            
            });
        }
    }
}
