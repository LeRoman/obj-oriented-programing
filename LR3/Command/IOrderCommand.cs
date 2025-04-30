public interface IOrderCommand
{
    void Execute();
    string Description { get; }
}