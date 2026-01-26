public class RIBProfessionnel : Document, IRIB
{
    private readonly int accountId;
    private readonly string siret;

    public RIBProfessionnel(int accountId, string siret)
    {
        this.accountId = accountId;
        this.siret = siret;
    }

    public string GenerateRIB()
    {
        return $"RIB détaillé - Compte #{accountId} - SIRET:{siret} - Logo:{Logo}";
    }

    public override string Generate() => GenerateRIB();
}