public class EspressoFactory : CoffeeFactory
{
    public IDrink CreateDrink() => new Espresso();
}