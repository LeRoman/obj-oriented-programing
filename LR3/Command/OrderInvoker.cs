public class OrderInvoker
{
    private List<IOrderCommand> _history = new();

    public void ExecuteCommand(IOrderCommand command)
    {
        command.Execute();
        _history.Add(command);
    }

    public void ShowHistory()
    {
        Console.WriteLine("Історія дій:");
        foreach (var cmd in _history)
        {
            Console.WriteLine("- " + cmd.Description);
        }
    }
}
