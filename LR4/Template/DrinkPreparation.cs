public abstract class DrinkPreparation
{
    public void PrepareDrink()
    {
        BoilWater();
        AddBase();          
        AddIngredients();   
        PourInCup();
        Serve();
    }

    protected void BoilWater()
    {
        Console.WriteLine("Кип’ятимо воду...");
    }

    protected abstract void AddBase();
    protected abstract void AddIngredients();

    protected void PourInCup()
    {
        Console.WriteLine("Наливаємо напій у чашку...");
    }

    protected void Serve()
    {
        Console.WriteLine("Подано клієнту.");
    }
}
