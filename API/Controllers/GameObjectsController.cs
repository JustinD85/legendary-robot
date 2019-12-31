using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.RestAPI;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Domain.Interfaces; //TODO: POCO's instead of Domain objects
using Domain.Concrete; //TODO: POCO's instead of Domain objects

//Message passing with MediatR
namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PawnsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PawnsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Pawn>> List(CancellationToken ct)
        {
            return await _mediator.Send(new List.Query(), ct);
        }

        [HttpGet("{id}")]
        public async Task<IActor> Details(Guid id)
        {
            return await _mediator.Send(new Details.Query { Id = id });
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create(Application.RestAPI.Create.Command command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Unit>> Edit(Guid id, Edit.Command command)
        {
            command.Id = id;//Because I don't have a requirement for the id to be in the body.
            return await _mediator.Send(command);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(Guid id)
        {
            return await _mediator.Send(new Delete.Command { Id = id });
        }
    }
}