using System;
using System.Collections.Generic;
using System.Linq;
using Application.GraphQL.InputTypes;
using Domain.Concrete;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.GraphQL.Repositories
{
    public interface IPawnRepository
    {
        IPawn Pawn(Guid Id);
        IPawn Pawn(string name);
        IQueryable<IPawn> Pawns();
        IEnumerable<IPawn> Pawns(params Guid[] ids);
        IEnumerable<IPawn> Pawns(params string[] name);
        IEnumerable<IPawn> createPawns(params PawnInput[] pawn);
        bool editPawn(PawnInput pawn);
        void editPawns(params Pawn[] pawn);
        bool deletePawn(params Guid[] id);
        IEnumerable<ISearchResult> Searches(string Text);
    }

    public class PawnRepository : IPawnRepository
    {
        private readonly DbSet<Pawn> _pawns;
        private readonly DataContext _data;
        public PawnRepository(DataContext data)
        {
            _pawns = data.Pawns;
            _data = data;
        }

        //C
        public IEnumerable<IPawn> createPawns(params PawnInput[] pawn)
        {
            foreach (PawnInput p in pawn)
            {
                _pawns.Add(new Pawn(p.Name, p.Description, p.Image));
            }
            _data.SaveChanges();
            return _pawns.TakeLast(pawn.Length).AsEnumerable();
        }

        //R

        public IPawn Pawn(Guid Id) => _pawns.Find(Id);

        public IEnumerable<IPawn> Pawns(params Guid[] Ids) => _pawns;

        public IPawn Pawn(string name) => _pawns.First(p => p.Name == name);

        public IQueryable<IPawn> Pawns() => _pawns.AsQueryable();

        public IEnumerable<IPawn> Pawns(params string[] names)
                => _pawns.Where(p => names.Contains(p.Name));

        public IEnumerable<ISearchResult> Searches(string text)
        {
            // string[] filters = text.Split(new[] { ' ' });
            // return from p in _pawns
            //        where filters.Any(f => p.Name.Contains(f))
            //        select p;
            throw new NotImplementedException();
        }
        //U
        public bool editPawn(PawnInput pawn)
        {
            var oldPawn = _pawns.Find(pawn.Id);
            oldPawn.Image = pawn.Image ?? oldPawn.Image;
            oldPawn.Name = pawn.Name ?? oldPawn.Name;
            oldPawn.Description = pawn.Description ?? oldPawn.Description;
            if (Enum.IsDefined(typeof(Pawn.ArmorClass), pawn.AC)) oldPawn.AC = pawn.AC;
            // if (pawn.Items.Any()) oldPawn.Items.AddRange(pawn.Items);
            oldPawn.UpdatedAt = DateTime.Now;

            _data.Update(oldPawn);
            _data.SaveChangesAsync();
            return true;
        }
        public void editPawns(params Pawn[] pawn)
        {
            throw new NotImplementedException();
        }
        //D
        public bool deletePawn(params Guid[] id)
        {
            var deleteWorthy =
            from p in _pawns
            where id.Contains(p.Id)
            select p;
            _pawns.RemoveRange(deleteWorthy);
            _data.SaveChanges();

            return true;
        }
    }
}