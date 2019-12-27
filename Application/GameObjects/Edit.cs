

using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Persistence;

namespace Application.GameObjects
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

                var gameobject = await _context.GameObjects.FindAsync(request.Id);
                if (gameobject == null)
                    throw new Exception("Could not find GameObject");

                gameobject.Date = new DateTime();
                gameobject.Description = request.Description ?? gameobject.Description;
                gameobject.Image = request.Image ?? gameobject.Image;
                gameobject.Name = request.Name ?? gameobject.Name;

                var success = await _context.SaveChangesAsync() > 0;
                if (success) return Unit.Value;

                throw new Exception("Error while attempting to edit gameobject");
            }
        }
    }
}