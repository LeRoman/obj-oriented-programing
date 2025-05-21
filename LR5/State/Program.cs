
class Program
{
    static void Main()
    {
        var order = new OrderContext();

        order.ShowState(); // Нове
        order.Next();      //  Готується
        order.ShowState();
        order.Next();      //  Готове
        order.ShowState();
        order.Next();      //  Видано
        order.ShowState();
        order.Next();      //  Більше не переходить
    }
}
