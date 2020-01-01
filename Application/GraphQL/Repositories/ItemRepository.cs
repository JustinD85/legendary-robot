using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Interfaces;
using Persistence;

namespace Application.GraphQL.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly DataContext _data;
        public ItemRepository(DataContext data)
        {
            _data = data;
        }

        public IQueryable<IItem> All()
        {
            return _data.Items.AsQueryable();
        }

        public IEnumerable<IItem> All(params Guid[] ids)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IItem> All(params string[] name)
        {
            throw new NotImplementedException();
        }

        public IItem Item(string name)
        {
            throw new NotImplementedException();
        }

        public IItem Item(Guid id)
        {
            return _data.Items.Find(id);
        }

        public IEnumerable<ISearchResult> Searches(string text)
        {
            throw new NotImplementedException();
        }
    }
}