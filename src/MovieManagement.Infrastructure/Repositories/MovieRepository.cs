using Microsoft.EntityFrameworkCore;
using MovieManagement.Application.Interfaces.Persistence;
using MovieManagement.Domain.Entities;
using MovieManagement.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieManagement.Infrastructure.Repositories
{
    public sealed class MovieRepository : IMovieRepository
    {
        private readonly MovieDbContext _dbContext;

        public MovieRepository(MovieDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddASync(Movie movie, CancellationToken cancellationToken)
        {
            await _dbContext.Movies.AddAsync(movie, cancellationToken);
        }

        public async Task<Movie?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _dbContext.Movies.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }
    }
}
