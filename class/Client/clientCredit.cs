public class ClientCredit : Client
{
    protected override Commande CreeCommande()
    {
        return new CommandeCredit(100);
    }
}