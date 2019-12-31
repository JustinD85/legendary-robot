using Domain.Interfaces;

namespace Domain.Concrete
{
    public class Building : AActor
    {
        public Building(string name, string description)
        {
            this.Description = description;
            this.Name = name;
        }
    }
}