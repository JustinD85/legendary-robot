using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Persistence;
using Domain.Concrete;

namespace Application.RestAPI
{
    public class Create
    {
        public class Command : IRequest<Guid>
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Image { get; set; }
            public string Description { get; set; }
            public DateTime Date { get; set; }
        }

        public class Handler : IRequestHandler<Command, Guid>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Guid> Handle(Command request, CancellationToken cancellationToken)
            {
                var pawn = new Pawn(request.Name, request.Description, request.Image);

                _context.Actors.Add(pawn);

                var success = await _context.SaveChangesAsync() > 0;
                if (success) return pawn.Id;

                throw new Exception("Issue saving new Game Object");
            }
        }
    }
}