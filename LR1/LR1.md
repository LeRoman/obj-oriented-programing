### **Лабораторна робота 1**

---

### **Технічне завдання: Модуль створення напоїв у кав’ярні**

#### **1. Загальний опис**

Цей модуль відповідає за створення напоїв у системі керування кав’ярнею. Він дозволяє динамічно додавати нові типи напоїв, змінювати їхню рецептуру та інтегрувати в загальну систему замовлень.

#### **2. Функціональні можливості**

1. **Базові категорії напоїв**

   - Кава (Еспресо, Латте, Американо, Капучино)
   - Чай (Зелений, Чорний, Трав’яний)
   - Інші напої (Какао, Гарячий шоколад)

2. **Гнучке створення нових напоїв**

   - Використання фабричного методу для створення конкретних напоїв
   - Використання абстрактної фабрики для генерації напоїв разом із додатковими опціями (тип молока, сиропи, розмір чашки)

3. **Розширюваність**
   - Можливість додавати нові напої без зміни основного коду
   - Використання інтерфейсів та абстрактних класів для забезпечення модульності

#### **3. Нефункціональні вимоги**

- Код має бути реалізований із використанням **Factory Method** та **Abstract Factory**
- Має бути можливість легко додати нові напої без зміни існуючих класів
- Система має бути гнучкою та підтримувати майбутнє розширення

---

### **1. Декомпозиція модуля "Створення напоїв"**

**Основні компоненти:**

1. **Інтерфейс `IDrink`** – базовий інтерфейс для всіх напоїв.
2. **Конкретні класи напоїв** (наприклад, `Espresso`, `Latte`, `GreenTea`).
3. **Factory Method:**
   - **Інтерфейс `IDrinkFactory`** – описує метод `CreateDrink()`.
   - **Конкретні фабрики** для кожного типу напоїв (`CoffeeFactory`, `TeaFactory`).
4. **Abstract Factory:**
   - **Інтерфейс `IDrinkFactoryExtended`** – дозволяє створювати напої з додатковими параметрами (тип молока, сиропи).
   - **Конкретні реалізації** для різних типів кави чи чаю.

---

### **2. Приклад реалізації (C#)**

```csharp
// Базовий інтерфейс напою
public interface IDrink
{
    void Prepare();
}

// Конкретні класи напоїв
public class Espresso : IDrink
{
    public void Prepare() => Console.WriteLine("Приготування еспресо...");
}

public class Latte : IDrink
{
    public void Prepare() => Console.WriteLine("Приготування латте...");
}

// Factory Method: Базовий інтерфейс фабрики напоїв
public interface IDrinkFactory
{
    IDrink CreateDrink();
}

// Конкретні фабрики
public class EspressoFactory : IDrinkFactory
{
    public IDrink CreateDrink() => new Espresso();
}

public class LatteFactory : IDrinkFactory
{
    public IDrink CreateDrink() => new Latte();
}

// Abstract Factory: Розширений інтерфейс для створення напоїв із додатковими параметрами
public interface IDrinkFactoryExtended
{
    IDrink CreateDrink(string size, string milkType);
}

// Реалізація Abstract Factory для кави
public class CoffeeFactory : IDrinkFactoryExtended
{
    public IDrink CreateDrink(string size, string milkType)
    {
        Console.WriteLine($"Приготування кави ({size}, {milkType})");
        return new Latte();
    }
}

// Використання фабрик
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
```

---

### **Що тут зроблено?**

✔ **Factory Method** – створює конкретні фабрики для різних напоїв (`EspressoFactory`, `LatteFactory`).  
✔ **Abstract Factory** – дозволяє створювати напої з параметрами (розмір, тип молока).

---

Як тобі така реалізація? Чи потрібно щось уточнити або розширити? 😊
