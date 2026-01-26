public class ParticulierDocumentFactory : IDocumentFactory
{
    public IRIB CreateRIB(int accountId) => new RIBParticulier(accountId);
    public IAttestation CreateAttestation(int accountId) => new AttestationParticulier(accountId);
}