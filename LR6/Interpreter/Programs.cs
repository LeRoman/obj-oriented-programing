class Program
{
    static void Main()
    {
        var orders = new List<Order>
        {
            new("Кава", 45),
            new("Чай", 60),
            new("Кава", 70),
        };

        var expr = new DrinkEqualsExpression("Кава");

        Console.WriteLine("Фільтр: напій = кава");
        foreach (var o in orders)
        {
            if (expr.Interpret(o))
                Console.WriteLine($"- {o.Drink}, {o.Total} грн");
        }

        Console.WriteLine("\nФільтр: сума > 50");
        var expr2 = new TotalGreaterThanExpression(50);
        foreach (var o in orders)
        {
            if (expr2.Interpret(o))
                Console.WriteLine($"- {o.Drink}, {o.Total} грн");
        }
    }
}
