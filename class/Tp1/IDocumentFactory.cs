public interface IDocumentFactory
{
    IRIB CreateRIB(int accountId);
    IAttestation CreateAttestation(int accountId);
}