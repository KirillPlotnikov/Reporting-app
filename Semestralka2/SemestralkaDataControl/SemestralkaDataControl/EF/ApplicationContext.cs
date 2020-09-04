using Microsoft.EntityFrameworkCore;
using SemestralkaDataControl.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SemestralkaDataControl.EF
{
    public class ApplicationContext : DbContext
    {
        internal ApplicationContext()
        {

        }
        public ApplicationContext(DbContextOptions options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"server=(LocalDb)\MSSQLLocalDB;database=Semestralka;integrated security=True;
                    MultipleActiveResultSets=True;App=EntityFramework;");
            }
        }
        
    }
}
