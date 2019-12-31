namespace Domain.Interfaces
{

    public interface IItem : IActor
    {
        int Quantity { get; set; }
    }


    /*
        IItem healingPotion = new Potion("healing potion", "great description");

    */
}