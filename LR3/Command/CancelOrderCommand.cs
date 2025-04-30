public class CancelOrderCommand : IOrderCommand
{
    public void Execute()
    {
        Console.WriteLine("Замовлення скасовано.");
    }

    public string Description => "Скасування замовлення";
}