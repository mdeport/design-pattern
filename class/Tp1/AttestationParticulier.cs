public class AttestationParticulier : Document, IAttestation
{
    private readonly int accountId;

    public AttestationParticulier(int accountId)
    {
        this.accountId = accountId;
    }

    public string GenerateAttestation()
    {
        return $"Attestation standard - Compte #{accountId} - Logo:{Logo}";
    }

    public override string Generate() => GenerateAttestation();
}