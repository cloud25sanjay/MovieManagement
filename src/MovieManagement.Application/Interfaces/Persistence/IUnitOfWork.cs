using System;
using System.Collections.Generic;
using System.Text;

namespace MovieManagement.Application.Interfaces.Persistence
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
