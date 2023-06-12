public sealed class Truck : Car
{
    private int _weightLimit;
    private List<string> _cargo;

    public Truck(int weightLimit, List<string> cargo, char category, int power, string manufacture, string name, int weight, int maxSpeed) : base(category, power, manufacture, name, weight, maxSpeed)
    {
        this._weightLimit = weightLimit;
        this._cargo = cargo;
    }

    /// <summary>
    /// Вывод информации о грузовом автомобиле
    /// </summary>
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Грузоподъемность: {_weightLimit}");
        Console.WriteLine("Груз:");
        foreach (string item in _cargo)
        {
            Console.WriteLine(item);
        }
    }
}