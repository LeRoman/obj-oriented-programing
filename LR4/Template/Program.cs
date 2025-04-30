class Program
{
    static void Main()
    {
        DrinkPreparation latte = new LattePreparation();
        latte.PrepareDrink();

        Console.WriteLine();

        DrinkPreparation tea = new GreenTeaPreparation();
        tea.PrepareDrink();
    }
}