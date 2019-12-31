using Domain.Concrete;

namespace Domain
{
    public class Potion : Item
    {
        public Potion(string Name, string Description, int quantity)
        {
            this.Quantity = quantity;
            this.Description = Description;
            this.Name = Name;
            //TODO: Add method that takes: params string[] and checks forIsNullOrWhiteSpace()

        }
        public Potion() { }

        public enum Category
        {
            BUFF = 0,
            DEBUFF = 1,
        }
    }
}