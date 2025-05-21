class Program
{
    static void Main()
    {
        var orders = new OrderCollection();
        orders.Add(new Order(1, "Латте з ваніллю"));
        orders.Add(new Order(2, "Чай з лимоном"));
        orders.Add(new Order(3, "Еспресо подвійний"));

        var iterator = orders.CreateIterator();

        Console.WriteLine("Перегляд замовлень:");
        while (iterator.HasNext())
        {
            var order = iterator.Next();
            Console.WriteLine($"- Замовлення #{order.Id}: {order.Description}");
        }
    }
}
