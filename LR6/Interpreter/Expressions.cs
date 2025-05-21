public class DrinkEqualsExpression : IExpression
{
    private readonly string _drink;
    public DrinkEqualsExpression(string drink) => _drink = drink;

    public bool Interpret(Order order) => order.Drink.Equals(_drink, StringComparison.OrdinalIgnoreCase);
}

public class TotalGreaterThanExpression : IExpression
{
    private readonly decimal _amount;
    public TotalGreaterThanExpression(decimal amount) => _amount = amount;

    public bool Interpret(Order order) => order.Total > _amount;
}
