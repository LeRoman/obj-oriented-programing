public class Order
{
    public decimal TotalAmount { get; set; }
    public string Syrup { get; set; }

    public Order(decimal amount)
    {
        TotalAmount = amount;
    }
}