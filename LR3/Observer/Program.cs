class Program
{
    static void Main()
    {
        var order = new Order(42.00m);

        var notifier = new OrderNotifier();
        notifier.Subscribe(new Barista());
        notifier.Subscribe(new Display());

        // Створено замовлення — всі підписники повідомлені
        notifier.Notify(order);
    }
}
