using System;

public class EcoShipping : IStrategieLivraison
{
    public decimal CalculerFrais(decimal poidsKg, decimal valeurCommande, double distanceKm)
    {
        if (poidsKg >= 5m)
            throw new InvalidOperationException("EcoShipping disponible uniquement pour les colis < 5kg.");
        return 3m + 0.3m * poidsKg;
    }
}