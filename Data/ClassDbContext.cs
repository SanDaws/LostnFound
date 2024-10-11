using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostnFound.Models;
using LostnFound.Seeders;
using Microsoft.EntityFrameworkCore;

namespace LostnFound.Data
{
    public class ClassDbContext: DbContext
    {
        public ClassDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Category> Categories{get;set;}
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            categorySeeders.seed(modelBuilder);
        }
        
    }
}