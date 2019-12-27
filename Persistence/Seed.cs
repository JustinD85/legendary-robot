using System;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.GameObjects.Any())
            {
                var gameobjects = new List<GameObject>();
                var idx = 0;

                foreach (var gameobject in Enumerable.Range(0, 100))
                {
                    idx++;
                    gameobjects.Add(new GameObject
                    {
                        Name = $"Joe {idx}",
                        Image = "https://picsum.photos/200/300",
                        Description = $"Description {idx}",
                        Date = DateTime.Now.AddMonths(-idx).AddDays(-idx * idx + idx)
                    });
                }

                context.GameObjects.AddRange(gameobjects);
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
                        Name = $"Value -- {idx}"
                    });
                }
                context.Values.AddRange(values);
            }
            context.SaveChanges();
        }
    }
}