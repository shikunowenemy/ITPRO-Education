public sealed class CargoAirplane: Airplane
{
    private int _weightLimit;
    private List<string> _cargo;

    public CargoAirplane(int weightLimit, List<string> cargo, int flightAltitude, int wingspan, string manufacture, string name, int weight, int maxSpeed) : base(flightAltitude, wingspan, manufacture, name, weight, maxSpeed)
    {
        this._weightLimit = weightLimit;
        this._cargo = cargo;
    }

    /// <summary>
    /// Вывод информации о грузовом самолете 
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