using System;
using System.Collections.Generic;
using Domain.Concrete;

namespace Application.GraphQL.InputTypes
{
    public class PawnInput
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Pawn.ArmorClass AC { get; set; }
        public IEnumerable<ItemInput> Items { get; set; }
    }
}