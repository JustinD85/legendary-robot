using System;
using Domain.Concrete;
using System.Collections.Generic;
using HotChocolate.Types;
using static Domain.Concrete.Pawn;
using Domain.Interfaces;

namespace Application.GraphQL.InputTypes
{
    public class PawnInput
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public ArmorClass AC { get; set; }
        // public IEnumerable<IItem> Items { get; set; } = new List<Item>();//TODO: Why can't I use an enumeration type.. I get a no constructor found error from Hot Chocolate
    }
}