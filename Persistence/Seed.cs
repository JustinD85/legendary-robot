using System;
using System.Collections.Generic;
using System.Linq;
using Domain;
using Domain.Concrete;
using Domain.Interfaces;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Potions.Any())
            {
                var actors = new List<Potion>();
                var idx = 0;

                foreach (var gameobject in Enumerable.Range(0, 100))
                {
                    idx++;
                    actors.Add(new Potion($"Potion -- {idx}", $"Description -- {idx}", 0));
                }
                context.AddRange(actors);
            }
            if (!context.Buildings.Any())
            {
                var actors = new List<Building>();
                var idx = 0;

                foreach (var gameobject in Enumerable.Range(0, 100))
                {
                    idx++;
                    actors.Add(new Building($"Building -- {idx}", $"Description -- {idx}"));
                }
                context.AddRange(actors);
            }
            if (!context.Pawns.Any())
            {
                var actors = new List<Pawn>();
                var idx = 0;

                foreach (var gameobject in Enumerable.Range(0, 100))
                {
                    idx++;
                    var pawn = new Pawn($"Pawn -- {idx}", $"Description -- {idx}", "https://cdn.discordapp.com/attachments/643545635005530112/656123992356159499/Baal_a.jpg");
                    pawn.Items.Add(new Potion($"Potion -- {idx + 100}", $"Description -- {idx + 100}", 0));
                    actors.Add(pawn);
                }
                context.AddRange(actors);
            }

            if (!context.Values.Any())
            {
                var values = new List<Value>();
                var idx = 0;
                foreach (var value in Enumerable.Range(0, 50))
                {
                    idx++;
                    values.Add(new Value
                    {
                        Name = $"Value -- {idx}",
                    });
                }
                context.Values.AddRange(values);
            }
            context.SaveChanges();
        }
    }
}