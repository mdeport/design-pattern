public class RIBParticulier : Document, IRIB
{
    private readonly int accountId;

    public RIBParticulier(int accountId)
    {
        this.accountId = accountId;
    }

    public string GenerateRIB()
    {
        return $"RIB simplifié - Compte #{accountId} - Logo:{Logo}";
    }

    public override string Generate() => GenerateRIB();
}