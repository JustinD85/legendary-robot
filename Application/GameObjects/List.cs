using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.GameObjects
{
    public class List
    {
        public class Query : IRequest<List<GameObject>> { }
        public class Handler : IRequestHandler<Query, List<GameObject>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }


            public async Task<List<GameObject>> Handle(Query request, CancellationToken cancellationToken)
            {
                var gameobjects = await _context.GameObjects.ToListAsync(cancellationToken);
                return gameobjects.FindAll(_ => _.IsValid);
            }
        }
    }
}