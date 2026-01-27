public class ContratAuto : Contrat
{
    protected override List<string> ChargerClausesStandard()
    {
        return new List<string>
        {
            "Clause automobile 1",
            "Clause responsabilité civile",
            "Clause vol"
        };
    }
}
