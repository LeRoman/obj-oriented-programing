class Program
{
    static void Main()
    {
        // Factory Method
        IDrinkFactory espressoFactory = new EspressoFactory();
        IDrink espresso = espressoFactory.CreateDrink();
        espresso.Prepare();

        // Abstract Factory
        IDrinkFactoryExtended coffeeFactory = new CoffeeFactory();
        IDrink latte = coffeeFactory.CreateDrink("Великий", "Мигдальне молоко");
        latte.Prepare();
    }
}