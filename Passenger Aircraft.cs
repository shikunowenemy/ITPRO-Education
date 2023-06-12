public sealed class PassengerAirplane : Airplane
{
    private string _direction;

    public PassengerAirplane(string direction, int flightAltitude, int wingspan, string manufacture, string name, int weight, int maxSpeed) : base(flightAltitude, wingspan, manufacture, name, weight, maxSpeed)
    {
        this._direction = direction;
    }

    /// <summary>
    /// Вывод информации о пассажирском самолете
    /// </summary>
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Направление: {_direction}");
    }
}