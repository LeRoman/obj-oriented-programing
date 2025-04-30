public class BonusPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Списано {amount} бонусних гривень.");
    }
}