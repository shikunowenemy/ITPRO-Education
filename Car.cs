public abstract class Car : Transport
{
    protected char _category;
    protected int _power;

    public Car(char category, int power, string manufacture, string name, int weight, int maxSpeed) : base(manufacture, name, weight, maxSpeed)
    {
        this._category = category;
        this._power = power;
    }

    /// <summary>
    /// Вывод информации о автомобиле
    /// </summary>
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Категория: {_category}");
        Console.WriteLine($"Категория: {_power}");
    }
}