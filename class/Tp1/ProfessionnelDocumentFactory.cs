public class ProfessionnelDocumentFactory : IDocumentFactory
{
    private readonly string siret;

    public ProfessionnelDocumentFactory(string siret)
    {
        this.siret = siret;
    }

    public IRIB CreateRIB(int accountId) => new RIBProfessionnel(accountId, siret);
    public IAttestation CreateAttestation(int accountId) => new AttestationProfessionnel(accountId);
}