using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain.Concrete;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.RestAPI
{

    public class List
    {
        public class Query : IRequest<List<Pawn>> { }
        public class Handler : IRequestHandler<Query, List<Pawn>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }


            public async Task<List<Pawn>> Handle(Query request, CancellationToken cancellationToken)
            {
                var pawns = await _context.Pawns.ToListAsync(cancellationToken);
                return pawns.FindAll(_ => !_.IsDeleted);
            }
        }
    }
}