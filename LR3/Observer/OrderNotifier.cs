public class OrderNotifier
{
    private List<IObserver> _observers = new();

    public void Subscribe(IObserver observer) => _observers.Add(observer);
    public void Unsubscribe(IObserver observer) => _observers.Remove(observer);

    public void Notify(Order order)
    {
        foreach (var observer in _observers)
        {
            observer.Update(order);
        }
    }
}