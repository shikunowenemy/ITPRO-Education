public sealed class PassengerCar : Car
{
    private string _class;

    public PassengerCar(string @class, char category, int power, string manufacture, string name, int weight, int maxSpeed) : base(category, power, manufacture, name, weight, maxSpeed)
    {
        this._class = @class;
    }

    /// <summary>
    /// Вывод информации о легковом автомобиле
    /// </summary>
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Класс: {_class}");
    }
}