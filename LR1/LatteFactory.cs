public class LatteFactory : ICoffeeFactory
{
    public IDrink CreateDrink() => new Latte();
}