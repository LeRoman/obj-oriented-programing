// Модель замовлення
public class Order
{
    public string Drink { get; set; }
    public decimal Total { get; set; }

    public Order(string drink, decimal total)
    {
        Drink = drink;
        Total = total;
    }
}
