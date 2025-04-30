public class AddSyrupCommand : IOrderCommand
{
    private readonly Order _order;
    private readonly string _syrup;

    public AddSyrupCommand(Order order, string syrup)
    {
        _order = order;
        _syrup = syrup;
    }

    public void Execute()
    {
        _order.Syrup = _syrup;
        Console.WriteLine($"Додано сироп: {_syrup}");
    }

    public string Description => $"Додано сироп: {_syrup}";
}