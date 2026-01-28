using System;

public class LivraisonContext
{
    private IStrategieLivraison strategie;

    public LivraisonContext(IStrategieLivraison strategie)
    {
        this.strategie = strategie;
    }

    public void SetStrategie(IStrategieLivraison nouvelleStrategie)
    {
        this.strategie = nouvelleStrategie;
    }

    public decimal Calculer(decimal poidsKg, decimal valeurCommande, double distanceKm)
    {
        if (strategie == null) throw new InvalidOperationException("Stratégie non définie.");
        return strategie.CalculerFrais(poidsKg, valeurCommande, distanceKm);
    }
}