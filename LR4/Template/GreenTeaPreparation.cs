public class GreenTeaPreparation : DrinkPreparation
{
    protected override void AddBase()
    {
        Console.WriteLine("Додаємо зелений чай...");
    }

    protected override void AddIngredients()
    {
        Console.WriteLine("Додаємо лимон...");
    }
}