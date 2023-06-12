public sealed class Train : Transport
{
    protected int _wagonsAmount;

    public Train(int wagonsAmount, string manufacture, string name, int weight, int maxSpeed) : base(manufacture, name, weight, maxSpeed)
    {
        this._wagonsAmount = wagonsAmount;
    }

    /// <summary>
    /// Вывод информации о поезде
    /// </summary>
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Количество вагонов: {_wagonsAmount}");
    }
}