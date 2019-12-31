using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using Domain.Interfaces;
using MediatR;
using Persistence;

namespace Application.RestAPI
{
    public class Details
    {
        public class Query : IRequest<IActor>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, IActor>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<IActor> Handle(Query request, CancellationToken cancellationToken)
            {
                var pawn = await _context.Pawns.FindAsync(request.Id);
                return !pawn.IsDeleted ? pawn : throw new Exception("This resource is not available");
            }
        }
    }
}