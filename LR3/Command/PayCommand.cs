public class PayCommand : IOrderCommand
{
    private readonly Order _order;
    public PayCommand(Order order)
    {
        _order = order;
    }

    public void Execute()
    {
        Console.WriteLine("Замовлення оплачено.");
    }

    public string Description => "Оплата замовлення";
}