class Adapter : IPaymentService{
    public bool ProcessPayment(decimal amount, string currency)
    {
        PaymentPro paymentPro = new PaymentPro();
        int codeDevise = currency switch
        {
            "EUR" => 1,
            "USD" => 2,
            "GBP" => 3
        };
        string reference = paymentPro.ExecuterTransaction((double)amount, codeDevise);
        return !string.IsNullOrEmpty(reference);
    }

    public bool RefundPayment(string transactionId, decimal amount)
    {
        PaymentPro paymentPro = new PaymentPro();
        return paymentPro.AnnulerTransaction(transactionId);
    }

    public string GetTransactionStatus(string transactionId)
    {
        PaymentPro paymentPro = new PaymentPro();
        int etat = paymentPro.ObtenirEtat(transactionId);
        return etat switch
        {
            0 => "En cours",
            1 => "Validé",
            2 => "Échoué"
        };
    }
}