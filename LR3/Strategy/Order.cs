public class Order
{
    public decimal TotalAmount { get; set; }
    private IPaymentStrategy _paymentStrategy;

    public Order(decimal amount)
    {
        TotalAmount = amount;
    }

    public void SetPaymentStrategy(IPaymentStrategy strategy)
    {
        _paymentStrategy = strategy;
    }

    public void ProcessPayment()
    {
        _paymentStrategy?.Pay(TotalAmount);
    }
}