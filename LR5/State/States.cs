//Конкретні стани
public class NewState : IOrderState
{
    public string Name => "Нове";

    public void Handle(OrderContext context)
    {
        Console.WriteLine("Переходимо в стан 'Готується'");
        context.SetState(new PreparingState());
    }
}

public class PreparingState : IOrderState
{
    public string Name => "Готується";

    public void Handle(OrderContext context)
    {
        Console.WriteLine("Переходимо в стан 'Готове'");
        context.SetState(new ReadyState());
    }
}

public class ReadyState : IOrderState
{
    public string Name => "Готове";

    public void Handle(OrderContext context)
    {
        Console.WriteLine("Переходимо в стан 'Видано'");
        context.SetState(new ServedState());
    }
}

public class ServedState : IOrderState
{
    public string Name => "Видано";

    public void Handle(OrderContext context)
    {
        Console.WriteLine("Замовлення вже видано. Далі змін не буде.");
    }
}
