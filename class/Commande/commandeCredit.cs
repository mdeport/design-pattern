public class CommandeCredit : Commande
{
    public CommandeCredit(int price) : base(price)
    {
    }

    public override bool Valide()
    {
        valid = price >= 200;
        return valid;
    }

    public override void Paye()
    {
        System.Console.WriteLine($"Paiement par crédit demandé pour: {price}");
    }
}