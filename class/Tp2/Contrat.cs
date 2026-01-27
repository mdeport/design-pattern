public abstract class Contrat : IContratPrototype
{
    public string NomClient { get; set; }
    public DateTime DateDebut { get; set; }
    public decimal Montant { get; set; }

    // Clauses standard (coûteuses à créer)
    public List<string> ClausesStandard { get; protected set; }

    // Annexes spécifiques
    public List<string> Annexes { get; set; } = new List<string>();

    protected Contrat()
    {
        ClausesStandard = ChargerClausesStandard();
    }

    protected abstract List<string> ChargerClausesStandard();

    public virtual Contrat Clone()
    {
        Contrat copie = (Contrat)this.MemberwiseClone();

        // Copie profonde des collections
        copie.ClausesStandard = new List<string>(ClausesStandard);
        copie.Annexes = new List<string>(Annexes);

        return copie;
    }
}
