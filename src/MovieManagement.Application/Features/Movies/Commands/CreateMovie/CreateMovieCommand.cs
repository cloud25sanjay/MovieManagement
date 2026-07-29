using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieManagement.Application.Features.Movies.Commands.CreateMovie
{
    public sealed record CreateMovieCommand(string Title, string Synopsis, int Duration, DateTime ReleaseDate) : IRequest<Guid>;
    
}
