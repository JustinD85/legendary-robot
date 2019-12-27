using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Persistence;

namespace Application.GameObjects
{
    public class Delete
    {
        public class Command : IRequest
        {
            public Guid Id;
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {

                var gameobject = await _context.GameObjects.FindAsync(request.Id);
                if (gameobject == null)
                    throw new Exception("Could not Find GameObject with that Id");
                gameobject.IsDeleted = true;

                var success = await _context.SaveChangesAsync() > 0;
                if (success) return Unit.Value;

                throw new Exception("Could not delete Game Object");
            }
        }
    }
}