using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.GameObjects
{
    public class Details
    {
        public class Query : IRequest<GameObject>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, GameObject>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<GameObject> Handle(Query request, CancellationToken cancellationToken)
            {
                var gameobject = await _context.GameObjects.FindAsync(request.Id);
                return gameobject.IsValid() ? gameobject : null;
            }
        }
    }
}