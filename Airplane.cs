public abstract class Airplane : Transport
{
    protected int _flightAltitude, _wingspan;

    public Airplane(int flightAltitude, int wingspan, string manufacture, string name, int weight, int maxSpeed) : base(manufacture, name, weight, maxSpeed)
    {
        this._flightAltitude = flightAltitude;
        this._wingspan = wingspan;
    }

    /// <summary>
    /// Вывод информации о самолете
    /// </summary>
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Максимальная высота: {_flightAltitude}");
        Console.WriteLine($"Размах крыльев: {_wingspan}");
    }
}