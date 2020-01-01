using HotChocolate.Types;
using Application.GraphQL.InputTypes;
using HotChocolate;
using Application.GraphQL.Repositories;
using System;
using System.Collections.Generic;
using Domain.Concrete;

namespace Application.GraphQL
{
    [ExtendObjectType(Name = "Mutation")]
    public class PawnMutations
    {
        public bool editPawn([Service]IPawnRepository data, PawnInput input) => data.editPawn(input);
        public bool deletePawns([Service]IPawnRepository data, params Guid[] ids) => data.deletePawn(ids);
        public IEnumerable<IPawn> createPawns([Service]IPawnRepository data, params PawnInput[] pawns)
        => data.createPawns(pawns);
    }
}