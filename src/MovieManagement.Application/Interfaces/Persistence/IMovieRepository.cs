using MovieManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieManagement.Application.Interfaces.Persistence
{
    public interface IMovieRepository
    {
        Task AddASync(Movie movie, CancellationToken cancellationToken);
        Task<Movie?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
