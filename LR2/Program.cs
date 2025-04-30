class Program
{
    static void Main()
    {
        // Побудова кастомного напою
        var builder = new CoffeeBuilder();
        var director = new DrinkDirector(builder);
        director.BuildStandardLatte();

        var latte = builder.GetDrink();
        latte.Show();

        // Прототип: клонування напою
        var customLatte = latte.Clone();
        customLatte.Syrup = "Карамель";
        customLatte.Show();
    }
}