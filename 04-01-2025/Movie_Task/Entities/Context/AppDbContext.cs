using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Context
{
    public class AppDbContext:DbContext
    {
        public DbSet<Movie>? Movies { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Movie>.HasData(
              
                   "title": "After Dark in Central Park",
                   "year": 1900,
                   "cast": "xyz",
                   "genre": "Horror"
                    
               );
               

            
        }



    }
}
