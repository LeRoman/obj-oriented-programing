//Колекція замовлень
public class OrderCollection
{
    private readonly List<Order> _orders = new();

    public void Add(Order order)
    {
        _orders.Add(order);
    }

    public IOrderIterator CreateIterator()
    {
        return new OrderIterator(_orders);
    }
}
