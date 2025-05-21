public class Cashier : IColleague
{
    private readonly CafeMediator _mediator;
    public Cashier(CafeMediator mediator) => _mediator = mediator;

    public void CreateOrder(string msg)
    {
        Console.WriteLine("Касир: створено замовлення.");
        _mediator.Notify("Cashier", msg);
    }

    public void Receive(string message) { } // касир не отримує
}

public class Barista : IColleague
{
    public void Receive(string message)
    {
        Console.WriteLine($"Бариста: отримав — {message}");
    }
}

public class Display : IColleague
{
    public void Receive(string message)
    {
        Console.WriteLine($"Дисплей: показує — {message}");
    }
}
