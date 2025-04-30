public class PrintReceiptCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Друкуємо чек...");
    }
}