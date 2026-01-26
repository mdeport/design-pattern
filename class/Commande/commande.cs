public abstract class Commande
{
    protected int price;
    protected bool valid;

    protected Commande(int price = 0)
    {
        this.price = price;
        this.valid = false;
    }

    public abstract bool Valide();
    public abstract void Paye();
}