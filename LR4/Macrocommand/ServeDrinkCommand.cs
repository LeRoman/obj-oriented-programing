public class ServeDrinkCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Видаємо напій клієнту.");
    }
}