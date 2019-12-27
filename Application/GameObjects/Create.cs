using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.GameObjects
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
                var gameobject = new GameObject
                {
                    Id = new Guid(),
                    Name = request.Name,
                    Image = request.Image,
                    Description = request.Description,
                    Date = request.Date
                };

                _context.GameObjects.Add(gameobject);

                var success = await _context.SaveChangesAsync() > 0;
                if (success) return gameobject.Id;

                throw new Exception("Issue saving new Game Object");
            }
        }
    }
}