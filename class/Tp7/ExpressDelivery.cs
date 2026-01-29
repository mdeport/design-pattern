using System;

public class ExpressDelivery : IStrategieLivraison
{
    public decimal CalculerFrais(decimal poidsKg, decimal valeurCommande, double distanceKm)
    {
        var distanceBlocks = (decimal)System.Math.Ceiling(distanceKm / 100.0);
        return 10m + 1m * poidsKg + 2m * distanceBlocks;
    }
}