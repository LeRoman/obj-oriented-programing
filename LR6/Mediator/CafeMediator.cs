public class CafeMediator
{
    private IColleague _cashier;
    private IColleague _barista;
    private IColleague _display;

    public void RegisterCashier(IColleague c) => _cashier = c;
    public void RegisterBarista(IColleague b) => _barista = b;
    public void RegisterDisplay(IColleague d) => _display = d;

    public void Notify(string sender, string message)
    {
        if (sender == "Cashier")
        {
            _barista?.Receive(message);
            _display?.Receive(message);
        }
    }
}
