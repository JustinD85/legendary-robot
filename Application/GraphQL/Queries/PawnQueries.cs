using System;
using System.Linq;
using Application.GraphQL.Repositories;
using Domain.Concrete;
using HotChocolate;
using HotChocolate.Types;

namespace Application.GraphQL.Queries
{
    [ExtendObjectType(Name = "Query")]
    public class PawnQueries
    {
        public IQueryable<IPawn> Pawns([Service]IPawnRepository data) => data.Pawns();
        public IPawn Pawn(Guid Id, [Service]IPawnRepository data) => data.Pawn(Id);
    }
}