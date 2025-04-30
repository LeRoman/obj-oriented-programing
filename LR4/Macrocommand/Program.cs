class Program
{
    static void Main()
    {
        var typicalOrder = new MacroCommand();
        typicalOrder.Add(new ShowOnScreenCommand());
        typicalOrder.Add(new PrintReceiptCommand());
        typicalOrder.Add(new ServeDrinkCommand());

        Console.WriteLine("Виконуємо макрокоманду:");
        typicalOrder.Execute();
    }
}
