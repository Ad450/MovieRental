using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MovieRental.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Infrastructure.Configurations
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie> 
    { 
    
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.Property(u => u.Name).IsRequired();
            builder.Property(u => u.Title).IsRequired();

            builder.HasOne(m => m.User).WithMany( u => u.Movies).HasForeignKey(m=>m.UserId);

        }
    }
}
