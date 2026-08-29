public class PaymentService
{
    private readonly IPayment _payment;
    public Guid ServiceId { get; } = Guid.NewGuid();
    public PaymentService(IPayment payment)
    {
        _payment = payment;
    }
    public Guid PaymentId
    {
        get
        {
            return _payment.Id;
        }
    }

    public void ProcessPayment(decimal amount)
    {
        _payment.Pay(amount);
    }

}