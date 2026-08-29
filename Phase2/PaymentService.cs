public class PaymentService
{
    private readonly IPayment _payment;

    public PaymentService(IPayment payment)
    {
        _payment = payment;
    }

    public void ProcessPayment(decimal amount)
    {
        _payment.Pay(amount);
    }
}
