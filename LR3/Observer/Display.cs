public class Display : IObserver
{
    public void Update(Order order)
    {
        Console.WriteLine("На екрані з’явилося нове замовлення.");
    }
}