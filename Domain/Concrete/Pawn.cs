using System.Collections.Generic;
using Domain.Interfaces;

namespace Domain.Concrete
{
    public interface IPawn
    {
        string Image { get; set; }
        List<Item> Items { get; set; }
        Pawn.ArmorClass AC { get; }
    }

    public class Pawn : AActor, IPawn
    {
        public Pawn() { }
        public Pawn(string name, string description, string image) //: base(name, description)
        {
            Description = description;
            Name = name;
            Image = image;
        }

        public string Image { get; set; }
        public List<Item> Items { get; set; } = new List<Item> { };
        public ArmorClass AC { get; set; }

        public enum ArmorClass
        {
            None = 0,
            Natural = 1,
            Heavy = 2,
            GodLike = 3

        }
    }
}