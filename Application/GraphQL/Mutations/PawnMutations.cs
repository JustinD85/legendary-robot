using HotChocolate.Types;
using Application.GraphQL.InputTypes;
using HotChocolate;
using Application.GraphQL.Repositories;
using System.Threading.Tasks;
using Domain.Concrete;
using System;
using System.Collections.Generic;

namespace Application.GraphQL
{
    [ExtendObjectType(Name = "Mutation")]
    public class PawnMutations
    {
        public bool editPawn([Service]IPawnRepository data, PawnInput cb) => data.editPawn(cb);
        public bool deletePawns([Service]IPawnRepository data, params Guid[] ids) => data.deletePawn(ids);
        public IEnumerable<IPawn> createPawns([Service]IPawnRepository data, params PawnInput[] pawns)
            => data.createPawns(pawns);
    }

}