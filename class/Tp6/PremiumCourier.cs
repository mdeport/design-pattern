public class PremiumCourier : IStrategieLivraison
{
    public decimal CalculerFrais(decimal poidsKg, decimal valeurCommande, double distanceKm)
    {
        if (valeurCommande > 100m) return 0m;
        return 20m;
    }
}