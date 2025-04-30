public class CustomDrink : IPrototype<CustomDrink>
{
    public string Base { get; set; }
    public string Size { get; set; }
    public string Milk { get; set; }
    public string Syrup { get; set; }

    public void Show()
    {
        Console.WriteLine($"Напій: {Base}, Розмір: {Size}, Молоко: {Milk}, Сироп: {Syrup}");
    }

    // Prototype
    public CustomDrink Clone()
    {
        return new CustomDrink() {Base=this.Base, Size=this.Size, Milk=this.Milk, Syrup=this.Syrup};
    }
}