using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Interfaces;

namespace Application.GraphQL.Repositories
{
    public interface IItemRepository
    {
        IQueryable<IItem> All();
        IEnumerable<IItem> All(params Guid[] ids);
        IEnumerable<IItem> All(params string[] name);
        IEnumerable<ISearchResult> Searches(string text);
        IItem Item(string name);
        IItem Item(Guid id);
    }
}