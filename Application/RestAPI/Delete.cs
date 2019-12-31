using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Persistence;

namespace Application.RestAPI
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

                var pawn = await _context.Pawns.FindAsync(request.Id);
                if (pawn == null)
                    throw new Exception("Could not Find Pawn with that Id");
                pawn.IsDeleted = true;

                var success = await _context.SaveChangesAsync() > 0;
                if (success) return Unit.Value;

                throw new Exception("Could not delete Pawn Object");
            }
        }
    }
}