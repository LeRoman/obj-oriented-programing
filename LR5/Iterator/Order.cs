// Модель замовлення
public class Order
{
    public int Id { get; set; }
    public string Description { get; set; }

    public Order(int id, string description)
    {
        Id = id;
        Description = description;
    }
}
