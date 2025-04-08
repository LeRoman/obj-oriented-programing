public class CoffeeFactory : IDrinkFactoryExtended
{
    public IDrink CreateDrink(string size, string milkType)
    {
        Console.WriteLine($"Приготування кави ({size}, {milkType})");
        return new Latte(size, milkType);
    }
}