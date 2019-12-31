using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Interfaces;

namespace Application.GraphQL.Repositories
{
    public interface IItemRepository
    {
        IQueryable<IItem> All();
        IEnumerable<IItem> All(params Guid[] Ids);
        IEnumerable<IItem> All(params string[] Name);
        IEnumerable<ISearchResult> Searches(string Text);
        IItem Item(string name);
        IItem Item(Guid Id);
    }
}