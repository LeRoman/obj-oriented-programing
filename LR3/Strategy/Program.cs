class Program
{
    static void Main()
    {
        var order = new Order(75.50m);

        
        order.SetPaymentStrategy(new CardPayment());
        order.ProcessPayment();

       
        order.SetPaymentStrategy(new BonusPayment());
        order.ProcessPayment();
    }
}