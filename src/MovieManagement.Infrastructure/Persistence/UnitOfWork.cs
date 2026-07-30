using MovieManagement.Application.Interfaces.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieManagement.Infrastructure.Persistence
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly MovieDbContext _dbContext;

        public UnitOfWork(MovieDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
