public class AttestationProfessionnel : Document, IAttestation
{
    private readonly int accountId;

    public AttestationProfessionnel(int accountId)
    {
        this.accountId = accountId;
    }

    public string GenerateAttestation()
    {
        return $"Attestation pro - Compte #{accountId} - mentions légales - Logo:{Logo}";
    }

    public override string Generate() => GenerateAttestation();
}