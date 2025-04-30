public class Barista : IObserver
{
    public void Update(Order order)
    {
        Console.WriteLine($"Бариста отримав замовлення на суму {order.TotalAmount} грн.");
    }
}