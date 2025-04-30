public class LattePreparation : DrinkPreparation
{
    protected override void AddBase()
    {
        Console.WriteLine("Додаємо еспресо...");
    }

    protected override void AddIngredients()
    {
        Console.WriteLine("Додаємо молоко та ванільний сироп...");
    }
}