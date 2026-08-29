public interface IPayment
{
    Guid Id { get; }
    void Pay(decimal amount);
}