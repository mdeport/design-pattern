public abstract class Client
{

    public void NouvelleCommande()
    {
        Commande commande = CreeCommande();
        if (commande.Valide())
        {
            commande.Paye();
        }
        else
        {
            System.Console.WriteLine("Commande non valide.");
        }
    }


    protected abstract Commande CreeCommande();
}