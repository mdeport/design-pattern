public interface IPaymentService
{
    bool ProcessPayment(decimal amount, string currency);
    bool RefundPayment(string transactionId, decimal amount);
    string GetTransactionStatus(string transactionId);
}