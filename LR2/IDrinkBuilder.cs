public interface IDrinkBuilder
{
    void Reset();
    void SetBase();
    void SetSize(string size);
    void SetMilk(string milk);
    void SetSyrup(string syrup);
    CustomDrink GetDrink();
}