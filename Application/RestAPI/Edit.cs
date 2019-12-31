

using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Persistence;

namespace Application.RestAPI
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Image { get; set; }
            public string Description { get; set; }
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
                    throw new Exception("Could not find pawn");

                pawn.UpdatedAt = DateTime.Now;
                pawn.Description = request.Description ?? pawn.Description;
                pawn.Image = request.Image ?? pawn.Image;
                pawn.Name = request.Name ?? pawn.Name;

                var success = await _context.SaveChangesAsync() > 0;
                if (success) return Unit.Value;

                throw new Exception("Error while attempting to edit pawn");
            }
        }
    }
}