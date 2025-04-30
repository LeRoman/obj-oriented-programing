public class DrinkDirector
{
    private readonly IDrinkBuilder _builder;

    public DrinkDirector(IDrinkBuilder builder)
    {
        _builder = builder;
    }

    public void BuildStandardLatte()
    {
        _builder.Reset();
        _builder.SetBase();
        _builder.SetSize("Середній");
        _builder.SetMilk("Коров’яче");
        _builder.SetSyrup("Ваніль");
    }
}