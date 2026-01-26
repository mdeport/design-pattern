public class CommandeComptant : Commande
{
    public CommandeComptant(int price) : base(price)
    {
    }

    public override bool Valide()
    {
        valid = price > 0;
        return valid;
    }

    public override void Paye()
    {
        System.Console.WriteLine($"Paye en comptant: {price}");
    }
}