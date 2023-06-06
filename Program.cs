using System.Linq;

double deposit, depositAmount;
List<double> holdings = new();
bool isCorrectValue;
double reward = 0;

Console.Write("Введите начальный вклад: ");

while (true)
{
    isCorrectValue = double.TryParse(Console.ReadLine(), out deposit);
    if (!isCorrectValue || deposit <= 0)
    {
        Console.WriteLine("Вы ввели некорректное значение");
        continue;
    }
    break;
}

holdings.Add(deposit);

Console.Write("Введите размер вклада: ");

while (true)
{
    isCorrectValue = double.TryParse(Console.ReadLine(), out depositAmount);
    if (!isCorrectValue || depositAmount <= 0)
    {
        Console.WriteLine("Вы ввели некорректное значение");
        continue;
    }
    break;
}

while (reward < 30)
{
    GetReward(holdings, depositAmount, ref reward);
}
int month = holdings.Count - 1;

if (month > 12)
{
    
}
else
{
    
}

foreach (var holding in holdings)
{
    Console.WriteLine(holding);
}

void GetReward (List<double> holdings, double depositAmount, ref double reward)
{
    reward = holdings.Last() / 100 * depositAmount;
    holdings.Add(holdings.Last() + reward);
}

string PrintMonth (int month)
{
    if (month == 0)
    return "";
}