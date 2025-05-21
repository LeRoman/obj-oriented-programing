//контекс
public class OrderContext
{
    public IOrderState State { get; private set; }

    public OrderContext()
    {
        State = new NewState(); // початковий стан
    }

    public void SetState(IOrderState newState)
    {
        State = newState;
    }

    public void Next()
    {
        State.Handle(this);
    }

    public void ShowState()
    {
        Console.WriteLine($"Поточний стан: {State.Name}");
    }
}
