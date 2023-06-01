bool isCorrectValue;

Console.WriteLine("------Задание 1------");
int startNumber, endNumber;

while (true)
{
    Console.Write("Введите начальное число диапазона: ");
    isCorrectValue = int.TryParse(Console.ReadLine(), out startNumber);

    if (!isCorrectValue)
    {
        Console.WriteLine("Вы ввели некорретное значение");
        continue;
    }

    Console.Write("Введите конечное число диапазона: ");
    isCorrectValue = int.TryParse(Console.ReadLine(), out endNumber);

    if (!isCorrectValue || endNumber < startNumber)
    {
        Console.WriteLine("Вы ввели некорретное значение");
        continue;
    }

    for (int i = startNumber; i <= endNumber; i++)
    {
        int reminder = i % 2;
        if (reminder != 0)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    break;
}

Console.WriteLine("------Задание 2------");
while (true)
{
    int userFibonacciLength;

    Console.Write("Введите длину последовательности чисел Фибоначи: ");
    isCorrectValue = int.TryParse(Console.ReadLine(), out userFibonacciLength);

    if (!isCorrectValue || userFibonacciLength < 0)
    {
        Console.WriteLine("Вы ввели некорретное значение");
        continue;
    }

    switch (userFibonacciLength)
    {
        case 0:
            Console.WriteLine(0);
            break;
        case 1:
            Console.WriteLine(0 + " " + 1);
            break;
        default:
            int[] fibonacciNumbers = new int[userFibonacciLength];
            fibonacciNumbers[0] = 0;
            fibonacciNumbers[1] = 1;

            for (int i = 2; i < fibonacciNumbers.Length; i++)
            {
                fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
            }

            for (int i = 0; i < fibonacciNumbers.Length; i++)
            {
                Console.Write(fibonacciNumbers[i] + " ");
            }
            Console.WriteLine();
            break;
    }
    break;
}

Console.WriteLine("------Задание 3------");

int day = 1;
double userDistance = 10, stepDistance = 10, targetDistance = 100, sumDistance = 0;
while (sumDistance < targetDistance)
{
    sumDistance += userDistance;
    userDistance = userDistance / 100 * (100 + stepDistance);
    Console.WriteLine(sumDistance);
    day++;
}
day--;

Console.WriteLine($"{targetDistance} км лыжник пробежит в {day} день");

