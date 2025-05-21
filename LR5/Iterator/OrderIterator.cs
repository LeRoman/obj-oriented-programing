public class OrderIterator : IOrderIterator
{
    private readonly List<Order> _orders;
    private int _position = 0;

    public OrderIterator(List<Order> orders)
    {
        _orders = orders;
    }

    public bool HasNext()
    {
        return _position < _orders.Count;
    }

    public Order Next()
    {
        return _orders[_position++];
    }
}
