using System;
using System.Linq;
using Application.GraphQL.Repositories;
using Domain.Interfaces;
using HotChocolate;
using HotChocolate.Types;

namespace Application.GraphQL.Queries
{
    [ExtendObjectType(Name = "Query")]
    public class ItemQueries
    {
        public IQueryable<IItem> Items([Service]IItemRepository data) => data.All();
        public IItem Item(Guid id, [Service]IItemRepository data) => data.Item(id);
    }
}