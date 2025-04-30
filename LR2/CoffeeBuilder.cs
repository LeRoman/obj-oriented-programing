public class CoffeeBuilder : IDrinkBuilder
{
    private CustomDrink _drink = new CustomDrink();

    public void Reset()
    {
        _drink = new CustomDrink();
    }

    public void SetBase()
    {
        _drink.Base = "Кава";
    }

    public void SetSize(string size)
    {
        _drink.Size = size;
    }

    public void SetMilk(string milk)
    {
        _drink.Milk = milk;
    }

    public void SetSyrup(string syrup)
    {
        _drink.Syrup = syrup;
    }

    public CustomDrink GetDrink()
    {
        return _drink;
    }
}