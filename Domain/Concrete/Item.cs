using Domain.Interfaces;

namespace Domain.Concrete
{
    public class Item : AActor, IItem
    {
        public int Quantity { get; set; }
        public Item(string name, string description, int quantity)
        {
            this.Name = name;
            this.Description = description;
            this.Quantity = quantity;
        }

        public Item() { }



        public string GetEffect()
        {
            throw new System.NotImplementedException();
        }


    }



}