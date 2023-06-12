public abstract class Transport
{
    protected string _manufacture, _name;
    protected int _weight, _maxSpeed, _capacity;

    protected Transport(string manufacture, string name, int weight, int maxSpeed)
    {
        this._manufacture = manufacture;
        this._name = name;
        this._weight = weight;
        this._maxSpeed = maxSpeed;
    }

    /// <summary>
    /// Вывод информации о транспорте
    /// </summary>
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Производитель: {_manufacture}");
        Console.WriteLine($"Название: {_name}");
        Console.WriteLine($"Вес: {_weight}");
        Console.WriteLine($"Максимальная скорость: {_maxSpeed}");
    }
}