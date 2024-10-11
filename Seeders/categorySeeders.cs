using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostnFound.Models;
using Microsoft.EntityFrameworkCore;

namespace LostnFound.Seeders;
    public class categorySeeders
    {
        public static void seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category{ Id=1,Name= "Electronica",Description="productos electrodomesticos"},
                new Category{ Id=2,Name= "Ropa",Description="Ropa general"},
                new Category{ Id=3,Name= "Hogar",Description="productos de uso domestico regular"}
            );
        }
    }