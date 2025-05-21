//Конкретні обробники
public class CashierHandler : IRequestHandler
{
    private IRequestHandler _next;

    public void SetNext(IRequestHandler next) => _next = next;

    public void Handle(Request request)
    {
        if (request.Type == "зміна сиропу")
            Console.WriteLine("Касир: можу змінити сироп.");
        else
        {
            Console.WriteLine("Касир: не можу допомогти, передаю далі.");
            _next?.Handle(request);
        }
    }
}

public class BaristaHandler : IRequestHandler
{
    private IRequestHandler _next;

    public void SetNext(IRequestHandler next) => _next = next;

    public void Handle(Request request)
    {
        if (request.Type == "напій холодний")
            Console.WriteLine("Бариста: приготую новий напій.");
        else
        {
            Console.WriteLine("Бариста: не моє, передаю далі.");
            _next?.Handle(request);
        }
    }
}

public class ManagerHandler : IRequestHandler
{
    public void SetNext(IRequestHandler next) { }

    public void Handle(Request request)
    {
        Console.WriteLine("Менеджер: розглядаю звернення.");
    }
}
