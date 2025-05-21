class Program
{
    static void Main()
    {
        var mediator = new CafeMediator();

        var cashier = new Cashier(mediator);
        var barista = new Barista();
        var display = new Display();

        mediator.RegisterCashier(cashier);
        mediator.RegisterBarista(barista);
        mediator.RegisterDisplay(display);

        cashier.CreateOrder("Напій: Латте, сума: 60 грн");
    }
}
