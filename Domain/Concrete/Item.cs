using Domain.Interfaces;

namespace Domain.Concrete
{
    public class Item : AActor, IItem
    {
        public Item(string name, string description, int quantity, string image) : base(name, description)
        {
            this.Quantity = quantity;
            this.Image = image;
        }

        public Item() { }
        public int Quantity { get; set; }
        public string Image { get; set; }

        public string GetEffect()
        {
            throw new System.NotImplementedException();
        }
    }
}