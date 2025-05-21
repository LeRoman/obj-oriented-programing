// Інтерфейс стану
public interface IOrderState
{
    void Handle(OrderContext context);
    string Name { get; }
}
