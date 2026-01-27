public class ContratHabitation : Contrat
{
    protected override List<string> ChargerClausesStandard()
    {
        return new List<string>
        {
            "Clause habitation 1",
            "Clause habitation 2",
            "Clause incendie"
        };
    }
}
