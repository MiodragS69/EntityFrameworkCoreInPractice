using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using EFDataLayer.Helpers;


namespace EFDataLayer.Entities
{
    public class EFContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Explanation> Explanations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionStringHelper.AppJsonConfigConnectionString());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>()
                .HasQueryFilter(f => f.SoftDeleted == false);
            modelBuilder.Entity<Answer>()
                .HasKey(k => new { k.AnswerId, k.QuestionId });
        }
        
    }
}
