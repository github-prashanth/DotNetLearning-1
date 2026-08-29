public class UpiPayment : IPayment
{
    public Guid Id { get; } = Guid.NewGuid();
    public void Pay(decimal amount)
    {
        
        Console.WriteLine($"Paid ₹{amount} using UPI.");
    }
}