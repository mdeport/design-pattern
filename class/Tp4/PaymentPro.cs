public class PaymentPro
{
    public string ExecuterTransaction(double montant, int codeDevise)
    {
        Console.WriteLine($"PaymentPro: Transaction de {montant} avec devise code {codeDevise}");
        return Guid.NewGuid().ToString();
    }

    public bool AnnulerTransaction(string reference)
    {
        Console.WriteLine($"PaymentPro: Annulation de {reference}");
        return true;
    }

    public int ObtenirEtat(string reference)
    {
        // 0=En cours, 1=Validé, 2=Échoué
        return 1;
    }
}