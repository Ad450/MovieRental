using Microsoft.EntityFrameworkCore;
using MovieRental.Domain.Entities;
using MovieRental.Infrastructure.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Infrastructure.Context
{
    public class MovieRentalContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public MovieRentalContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MovieConfiguration).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
