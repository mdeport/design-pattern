public class ClientComptant : Client
{
    protected override Commande CreeCommande()
    {
        return new CommandeComptant(100);
    }
}