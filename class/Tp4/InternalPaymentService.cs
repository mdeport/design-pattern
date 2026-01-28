public class InternalPaymentService : IPaymentService
{
    public bool ProcessPayment(decimal amount, string currency)
    {
        Console.WriteLine($"Paiement interne: {amount} {currency}");
        return true;
    }

    public bool RefundPayment(string transactionId, decimal amount)
    {
        Console.WriteLine($"Remboursement interne: {transactionId} - {amount}");
        return true;
    }

    public string GetTransactionStatus(string transactionId)
    {
        return "Completed";
    }
}