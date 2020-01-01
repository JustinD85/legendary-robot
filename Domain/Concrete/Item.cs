using Domain.Interfaces;

namespace Domain.Concrete
{
    public class Item : AActor, IItem
    {
        public Item(string name, string description, int quantity) : base(name, description)
        {
            this.Quantity = quantity;
        }

        public Item() { }
        public int Quantity { get; set; }

        public string GetEffect()
        {
            throw new System.NotImplementedException();
        }
    }
}