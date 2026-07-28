using MovieManagement.Domain.Common;
using MovieManagement.Domain.Exceptions;
using MovieManagement.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieManagement.Domain.Entities
{
    public class Movie : BaseEntity
    {
        public MovieTitle Title { get; private set; } = null!;
        public DateTime ReleaseDate { get; private set; }

        private Movie() { }

        public  Movie(MovieTitle title, DateTime releaseDate)
        {
            if(title is null)
            {
                throw new DomainException("Movie title is required");
            }

            if(releaseDate > DateTime.UtcNow)
            {
                throw new DomainException("Release Date cannot be in the feature");
            }

            Title = title;
            ReleaseDate = releaseDate;
        }
    }
}
