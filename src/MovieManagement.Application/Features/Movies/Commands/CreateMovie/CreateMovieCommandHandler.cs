using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieManagement.Application.Features.Movies.Commands.CreateMovie
{
    public sealed class CreateMovieCommandHandler : IRequestHandler<CreateMovieCommand , Guid>
    {
        public async Task<Guid> Handle(CreateMovieCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(Guid.NewGuid());
        }
    }
}
