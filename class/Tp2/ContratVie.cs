public class ContratVie : Contrat
{
    protected override List<string> ChargerClausesStandard()
    {
        return new List<string>
        {
            "Clause santé 1",
            "Clause hospitalisation"
        };
    }
}
