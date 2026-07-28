using MovieManagement.Domain.Common;
using MovieManagement.Domain.Exceptions;
using MovieManagement.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieManagement.Domain.Entities
{
    public class Movie : AggregateRoot
    {
        public MovieTitle Title { get; private set; } = null!;

        public Synopsis Synopsis { get; private set; } = null!;

        public Duration Duration { get; private set; } = null!;
        public DateTime ReleaseDate { get; private set; }

        private Movie() { }

        public  Movie(MovieTitle title,Synopsis synopsis ,Duration duration ,DateTime releaseDate)
        {
            if(title is null)
            {
                throw new DomainException("Movie title is required");
            }

            if (synopsis is null)
                throw new DomainException("Synopsis required.");

            if (duration is null)
                throw new DomainException("Duration required.");

            if (releaseDate > DateTime.UtcNow)
            {
                throw new DomainException("Release Date cannot be in the feature");
            }

            Title = title;
            ReleaseDate = releaseDate;
        }
    }
}
