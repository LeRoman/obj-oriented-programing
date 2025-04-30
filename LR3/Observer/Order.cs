public class Order
{
    public decimal TotalAmount { get; set; }

    public Order(decimal amount)
    {
        TotalAmount = amount;
    }
}
