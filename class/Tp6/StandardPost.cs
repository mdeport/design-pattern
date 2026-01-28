public class StandardPost : IStrategieLivraison
{
    public decimal CalculerFrais(decimal poidsKg, decimal valeurCommande, double distanceKm)
    {
        return 5m + 0.5m * poidsKg;
    }
}