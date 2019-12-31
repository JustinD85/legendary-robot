using Domain.Concrete;

namespace Domain
{
    public abstract class ChildOfBaal : Pawn
    {
        public ChildOfBaal(string name, string description, string image)
            : base(name, description, image)
        {
        }
        public ChildOfBaal() { }

        SpiritLevel SpiritEnergy { get; set; }
    }


    public enum SpiritLevel
    {
        None = 0,
        Low = 1,
        Medium = 2,
        High = 3,
        Max = 4

    }
}