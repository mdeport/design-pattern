public interface IStrategieLivraison
{
    // poids en kg, valeur de la commande en €, distance en km
    decimal CalculerFrais(decimal poidsKg, decimal valeurCommande, double distanceKm);
}