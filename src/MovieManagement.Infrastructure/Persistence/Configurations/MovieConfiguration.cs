using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieManagement.Infrastructure.Persistence.Configurations
{
    public sealed class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("movies");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .HasConversion(
                    title => title.Value,
                    value => new(value))
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.Synopsis)
                .HasConversion(
                    synopsis => synopsis.Value,
                    value => new(value))
                .HasMaxLength(2000)
                .IsRequired();

            builder.Property(x => x.Duration)
                .HasConversion(
                    duration => duration.Minutes,
                    value => new(value))
                .IsRequired();

            builder.Property(x => x.ReleaseDate)
                .IsRequired();
                
        }
    }
}
